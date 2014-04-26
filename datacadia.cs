using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using System.IO;
using System.Xml.Linq;
using System.Threading;



namespace Datacadia
{
    public partial class datacadia : Form
    {
        dbHandle db;
        string arcadiaPath;
        long? platform_id = 0;

        DataSet gameDataSet;

        public datacadia()
        {
            InitializeComponent();
            db = new dbHandle();
            tabPlatforms.Enabled = false;
            tabGames.Enabled = false;
            tabGenre.Enabled = false;
        }


        public void updateInfoBox(string text, Color colour)
        {
            infoBox.AppendText(text + "\n", colour);
        }
        public void refreshAllDataSets()
        {
            // fill in details of genres
            DataSet dsGenres = db.getDataSet("select id, genre_name from genres order by genre_name");
            comboBoxGenres.ComboBox.DisplayMember = "genre_name";
            comboBoxGenres.ComboBox.ValueMember = "id";
            comboBoxGenres.ComboBox.DataSource = dsGenres.Tables[0];

            refreshPlatformsDataSet();
            refreshGamesDataSet();
        }
        public void refreshGamesDataSet()
        {
            // fill in details of games tab
            gameDataSet = db.getDataSet("select games.active, games.name, games.file_name, games.region, genres.genre_name as genre, games.clone_of as clone from games, genres where games.genre_id = genres.id and platform_id = " + listboxPlatforms.SelectedValue);
            dataGridGames.DataSource = gameDataSet.Tables[0].DefaultView;
        }
        public void refreshPlatformsDataSet()
        {
            // Set up platforms dropdown.
            DataSet ds;
            if (cboxOnlyActive.Checked)
                ds = db.getDataSet("select id, name from platforms where active = 1 order by name");
            else
                ds = db.getDataSet("select id, name from platforms order by name");

            listboxPlatforms.DisplayMember = "name";
            listboxPlatforms.ValueMember = "id";
            listboxPlatforms.DataSource = ds.Tables[0];
        }



        private void dbConnect_Click(object sender, EventArgs e)
        {
            if (db.connect(dbLocation.Text))
            {
                dbLocation.ReadOnly = true;
                txtArcadiaEXEpath.ReadOnly = true;
                btnBrowseDB.Enabled = false;
                btnBrowseEXE.Enabled = false;

                arcadiaPath = Path.GetDirectoryName(txtArcadiaEXEpath.Text);
                


                infoBox.AppendText("Connected to Arcadia Database \n", Color.LavenderBlush);

                tabPlatforms.Enabled = true;
                tabGames.Enabled = true;
                cboxOnlyActive.Enabled = true;

                refreshAllDataSets();
            }
            else
                System.Windows.Forms.MessageBox.Show("Cant find file");
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "database file|database.db|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                dbLocation.Text = openFileDialog1.FileName;
        }
        private void btnBrowseEXE_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Arcadia EXE|Arcadia.exe";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtArcadiaEXEpath.Text = openFileDialog1.FileName;
        }

        private void btnLoadFromNoIntro_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "xml|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XDocument xmlDoc = XDocument.Load(openFileDialog1.FileName);
                infoBox.AppendText("LOADED XML FILE \n " + openFileDialog1.FileName + "\n");

                string release_name;
                string crc;
                string file_name;
                string region;
                string clone_of;
                int countUpdated = 0;
                int countInserted = 0;
                int countSkiped = 0;

                progressBar.Maximum = xmlDoc.Descendants("game").Count();
                

                foreach (XElement game_node in xmlDoc.Descendants("game"))
                {
                    progressBar.Value += 1;
                    crc = game_node.Element("rom").Attribute("crc").Value;
                    file_name = game_node.Attribute("name").Value;
                    if (game_node.Attribute("cloneof") != null)
                        clone_of = game_node.Attribute("cloneof").Value;
                    else
                        clone_of = "none";

                    if (game_node.Element("release") != null)
                    {
                        release_name = game_node.Element("release").Attribute("name").Value;
                        region = game_node.Element("release").Attribute("region").Value;
                    }
                    else
                    {
                        release_name = file_name;
                        region = "No_Release";
                    }

                    
                    //Check if game is already in our database using file_name or crc;
                    if (db.gameExists(platform_id, file_name))
                    {
                        if (cboxXMLUpdate.Checked == true)
                        {
                            var command = new SQLiteCommand("update games set name = @name, region = @region, clone_of = @clone_of where platform_id = @platform_id and file_name = @file_name");
                            command.Parameters.AddWithValue("@crc", crc);
                            command.Parameters.AddWithValue("@platform_id", platform_id);
                            command.Parameters.AddWithValue("@name", release_name);
                            command.Parameters.AddWithValue("@region", region);
                            command.Parameters.AddWithValue("@file_name", file_name);
                            command.Parameters.AddWithValue("@clone_of", clone_of);
                            db.sqlExecute(command);
                            infoBox.AppendText(release_name, Color.WhiteSmoke);
                            infoBox.AppendText("\n  Updated existing record \n", Color.GreenYellow);
                            countUpdated++;
                        }
                        else
                        {
                            infoBox.AppendText(release_name, Color.WhiteSmoke);
                            infoBox.AppendText("\n  Not Updated as update not checked \n", Color.Coral);
                            countSkiped++;
                        }
                        
                    }
                    else
                    {
                        if (cboxXMLInsert.Checked == true)
                        {
                            var command = new SQLiteCommand("INSERT INTO games (crc, platform_id, name, region, file_name, clone_of) VALUES (@crc, @platform_id, @name, @region, @file_name, @clone_of)");
                            command.Parameters.AddWithValue("@crc", crc);
                            command.Parameters.AddWithValue("@platform_id", platform_id);
                            command.Parameters.AddWithValue("@name", release_name);
                            command.Parameters.AddWithValue("@region", region);
                            command.Parameters.AddWithValue("@file_name", file_name);
                            command.Parameters.AddWithValue("@clone_of", clone_of);
                            db.sqlExecute(command);
                            infoBox.AppendText(release_name, Color.WhiteSmoke);
                            infoBox.AppendText("\n  Inserted \n", Color.GreenYellow);
                            countInserted++;

                        }
                        else
                        {
                            infoBox.AppendText(release_name, Color.WhiteSmoke);
                            infoBox.AppendText("\n  Not Inserted as insert not checked \n", Color.Coral);
                            countSkiped++;
                        }
                    }
                }

                progressBar.Value = 0;
                infoBox.AppendText("\n No-Intro XML Load Completed \n");
                infoBox.AppendText("  " + countInserted + " Item(s) Inserted : " + countUpdated + " Item(s) Updated : " + countSkiped + " Item(s) Skipped \n", Color.LemonChiffon);
                infoBox.gotToBottom();
                refreshGamesDataSet();                
            }
        }

        private void btnLoadFromHyperSpin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "xml|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XDocument xmlDoc = XDocument.Load(openFileDialog1.FileName);
                infoBox.AppendText("LOADED XML FILE \n " + openFileDialog1.FileName + "\n");

                string file_name;
                string name;
                string crc;
                string manufacturer;
                string year;
                string genre;
                string rating;
                
                int countUpdated = 0;
                int countInserted = 0;
                int countSkiped = 0;


                progressBar.Maximum = xmlDoc.Descendants("game").Count();
                foreach (XElement game_node in xmlDoc.Descendants("game"))
                {
                    progressBar.Value += 1;
                    if (game_node.Element("crc") != null)
                        crc = game_node.Element("crc").Value;
                    else
                        crc = "";
                    file_name = game_node.Attribute("name").Value;
                    name = game_node.Element("description").Value;
                    manufacturer = game_node.Element("manufacturer").Value;
                    year = game_node.Element("year").Value;
                    genre = game_node.Element("genre").Value;
                    rating = game_node.Element("rating").Value;
                    long genre_id = db.getGenreID(genre);


                    infoBox.AppendText(name, Color.WhiteSmoke);
                    if (genre_id == 0)
                    {
                        infoBox.AppendText("\n ALERT: " + genre + " genre could not be mapped to a genre ID", Color.Coral);
                    }

                    //Check if game is already in our database using file_name or crc;
                    if (db.gameExists(platform_id, file_name))
                    {
                        if (cboxXMLUpdate.Checked == true)
                        {
                            var command = new SQLiteCommand("update games set name = @name, developer = @manufacturer, release_year = @year, genre_id = @genre_id, rating = @rating where platform_id = @platform_id and file_name = @file_name");

                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@manufacturer", manufacturer);
                            command.Parameters.AddWithValue("@year", year);
                            command.Parameters.AddWithValue("@genre_id", genre_id);
                            command.Parameters.AddWithValue("@rating", rating);                            
                            command.Parameters.AddWithValue("@platform_id", platform_id);
                            command.Parameters.AddWithValue("@file_name", file_name);

                            db.sqlExecute(command);

                            infoBox.AppendText("\n  Updated existing record \n", Color.GreenYellow);
                            countUpdated++;
                        }
                        else
                        {
                            infoBox.AppendText("\n  Not Updated as update not checked \n", Color.Coral);
                            countSkiped++;
                        }
                    }
                    else
                    {
                        if (cboxXMLInsert.Checked == true)
                        {
                            var command = new SQLiteCommand("INSERT INTO games (crc, platform_id, name, developer, file_name, release_year, genre_id, rating, region) VALUES (@crc, @platform_id, @name, @manufacturer, @file_name, @year, @genre_id, @rating, @region)");
                            command.Parameters.AddWithValue("@crc", crc);
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@manufacturer", manufacturer);
                            command.Parameters.AddWithValue("@year", year);
                            command.Parameters.AddWithValue("@genre_id", genre_id);
                            command.Parameters.AddWithValue("@rating", rating);
                            command.Parameters.AddWithValue("@platform_id", platform_id);
                            command.Parameters.AddWithValue("@file_name", file_name);
                            command.Parameters.AddWithValue("@region", "NULL");
                            db.sqlExecute(command);
                            
                            infoBox.AppendText("\n  Inserted \n", Color.GreenYellow);
                            countInserted++;
                        }
                        else
                        {
                            infoBox.AppendText(name, Color.WhiteSmoke);
                            infoBox.AppendText("\n  Not Inserted as insert not checked \n", Color.Coral);
                            countSkiped++;
                        }
                    }
                }
                progressBar.Value = 0;
                infoBox.AppendText("\n\nHyperspin XML Load Completed \n");
                infoBox.AppendText("  " + countInserted + " Item(s) Inserted : " + countUpdated + " Item(s) Updated : " + countSkiped + " Item(s) Skipped \n", Color.LemonChiffon);
                infoBox.gotToBottom();
                refreshGamesDataSet();
            }
        }



        private void txtLoadString_TextChanged(object sender, EventArgs e)
        {
            btnPlatformSave.Text = "Save Changes";
            btnPlatformSave.Enabled = true;
        }
        private void txtRomsPath_TextChanged(object sender, EventArgs e)
        {
            btnPlatformSave.Text = "Save Changes";
            btnPlatformSave.Enabled = true;

            if (txtRomsPath.Text == "" || txtRomsPath.Text == null)
            {
                btnActivateAvalableRoms.Enabled = false;
            }
            else
                btnActivateAvalableRoms.Enabled = true;

        }
        private void txtVideosPath_TextChanged(object sender, EventArgs e)
        {
            btnPlatformSave.Text = "Save Changes";
            btnPlatformSave.Enabled = true;
        }
        private void txtImagesPath_TextChanged(object sender, EventArgs e)
        {
            btnPlatformSave.Text = "Save Changes";
            btnPlatformSave.Enabled = true;
        }
        private void txtExtensions_TextChanged(object sender, EventArgs e)
        {
            btnPlatformSave.Text = "Save Changes";
            btnPlatformSave.Enabled = true;
        }
        private void cboxActive_CheckedChanged(object sender, EventArgs e)
        {
            btnPlatformSave.Text = "Save Changes";
            btnPlatformSave.Enabled = true;
        }

        private void btnActivateAvalableRoms_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            string romsPath = txtRomsPath.Text.Replace("%PATH%", arcadiaPath);
            string[] files = Directory.GetFiles(romsPath, "*.*");

            infoBox.AppendText("\nActivating Avaliable roms in " + romsPath + "\n");
            infoBox.AppendText(" " + files.Length + " files to check \n");
            progressBar.Maximum = files.Length;

            foreach (string file in files)
            {
                    progressBar.Value += 1;
                    infoBox.AppendText(file, Color.WhiteSmoke);
                    string file_name = Path.GetFileNameWithoutExtension(file);
                    var command = new SQLiteCommand("update games set active = 1 where platform_id = @platform_id and file_name = @file_name");
                    command.Parameters.AddWithValue("@file_name", file_name);
                    command.Parameters.AddWithValue("@platform_id", platform_id);

                    db.sqlExecute(command);
                    infoBox.AppendText("\n Marked Active \n", Color.GreenYellow);

                    Application.DoEvents();
            }

            progressBar.Value = 0;
            infoBox.AppendText("\n\nRom Activation Complete\n");
            infoBox.gotToBottom();
            refreshGamesDataSet();
        }

        private void listboxPlatforms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fill in details on platform Tab
            DataSet ds = db.getDataSet("select * from platforms where id = " + listboxPlatforms.SelectedValue);            
            platform_id = listboxPlatforms.SelectedValue as long?;

            cboxActive.Checked = ds.Tables[0].Rows[0].Field<bool>("active");
            txtLoadString.Text = ds.Tables[0].Rows[0].Field<string>("load_string");
            txtRomsPath.Text = ds.Tables[0].Rows[0].Field<string>("roms_path");
            txtVideosPath.Text = ds.Tables[0].Rows[0].Field<string>("videos_path");
            txtImagesPath.Text = ds.Tables[0].Rows[0].Field<string>("images_path");
            txtExtensions.Text = ds.Tables[0].Rows[0].Field<string>("extension");

            refreshGamesDataSet();

        }

        private void dataGridGames_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridGames.Columns[e.ColumnIndex].Name.Equals("active"))
            {
                bool active = Convert.ToBoolean(e.Value);
                Debug.WriteLine(active);
                Debug.WriteLine(e.Value);
                if (!active)
                {
                    dataGridGames.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dataGridGames.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }
                else
                {
                    dataGridGames.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.CadetBlue;
                    dataGridGames.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                }
            }
        }


        /* --Genre Tab
         * combobox Genres Changed
         */
        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get dataset for selected genre
            long? genre_id = comboBoxGenres.ComboBox.SelectedValue as long?;
            DataSet ds = db.getDataSet("select * from genres where id = " + comboBoxGenres.ComboBox.SelectedValue);

            // set txtAltGenre text
            txtAltGenreNames.Text = ds.Tables[0].Rows[0].Field<string>("alt_names");

        }
        /* --Genre Tab
        * Save Button Clicked
        */
        private void btnSaveGenre_Click(object sender, EventArgs e)
        {
            long? genre_id = comboBoxGenres.ComboBox.SelectedValue as long?;

            var command = new SQLiteCommand("update genres set alt_names = @alt_names where id = @genre_id");
            command.Parameters.AddWithValue("@alt_names", txtAltGenreNames.Text);
            command.Parameters.AddWithValue("@genre_id", genre_id);

            db.sqlExecute(command);
            infoBox.AppendText("\ngenre "+ comboBoxGenres.ComboBox.Text + " updated \n");
            infoBox.gotToBottom();
        }

        private void btnClearPlatform_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to delete all "+ listboxPlatforms.Text + " game data from the database?", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                var command = new SQLiteCommand("delete from games where platform_id = @platform_id");
                command.Parameters.AddWithValue("@platform_id", platform_id);
                db.sqlExecute(command);

                infoBox.AppendText("\nAll " + listboxPlatforms.Text + " game data has been removed from the database \n");
                infoBox.gotToBottom();

                refreshGamesDataSet();
            }
        }

        private void btnPlatformsSave_Click(object sender, EventArgs e)
        {
            var command = new SQLiteCommand("update platforms set load_string = @load_string, roms_path = @roms_path, videos_path = @videos_path, images_path = @images_path, extension = @extension, active = @active where id = @platform_id");
            command.Parameters.AddWithValue("@load_string", txtLoadString.Text);
            command.Parameters.AddWithValue("@roms_path", txtRomsPath.Text);
            command.Parameters.AddWithValue("@videos_path", txtVideosPath.Text);
            command.Parameters.AddWithValue("@images_path", txtImagesPath.Text);
            command.Parameters.AddWithValue("@extension", txtExtensions.Text);
            if (cboxActive.Checked)
                command.Parameters.AddWithValue("@active", 1);
            else
                command.Parameters.AddWithValue("@active", 0);

            command.Parameters.AddWithValue("@platform_id", platform_id);

            db.sqlExecute(command);

            btnPlatformSave.Text = "Saved";
            btnPlatformSave.Enabled = false;

            infoBox.AppendText(listboxPlatforms.Text, Color.WhiteSmoke);
            infoBox.AppendText("\n Changes Saved \n", Color.GreenYellow);
        }

        private void cboxOnlyActive_CheckedChanged(object sender, EventArgs e)
        {
            refreshPlatformsDataSet();
        }



    }
}

public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }

    public static void gotToBottom(this RichTextBox box)
    {
        box.SelectionStart = box.Text.Length; //Set the current caret position at the end
        box.ScrollToCaret(); //Now scroll it automatically
    }
}