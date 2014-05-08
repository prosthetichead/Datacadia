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
using System.Net;
using System.Text.RegularExpressions;


namespace Datacadia
{
    public partial class datacadia : Form
    {
        dbHandle db;
        string arcadiaPath;
        long platform_id = 0;

        DataSet assetsDataSet;

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
            refreshAssetsDataSet();
        }
        public void refreshGamesDataSet()
        {
            //dataGridGames.AutoGenerateColumns = false;
            dataGridGames.Columns.Clear();
            dataGridGames.AutoGenerateColumns = false;

            //Hook up the db.dsGames dataset to the table
            db.refreshGameDataset(platform_id);
            dataGridGames.DataSource = db.dsGames.Tables[0];

            DataSet gameGenreDataSet = db.getDataSet("select genre_name, id from genres order by genre_name");
            DataGridViewComboBoxColumn colGenre = new DataGridViewComboBoxColumn();
            colGenre.HeaderText = "Genre";
            colGenre.DataSource = gameGenreDataSet.Tables[0].DefaultView;
            colGenre.FlatStyle = FlatStyle.Flat;

            colGenre.DataPropertyName = "genre_id";
            colGenre.DisplayMember = "genre_name";
            colGenre.ValueMember = "id";

            DataGridViewCheckBoxColumn colActive = new DataGridViewCheckBoxColumn();
            colActive.HeaderText = "Active";
            colActive.Name = "active";
            colActive.DataPropertyName = "active";
            colActive.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridGames.Columns.Add(colActive);

            DataGridViewCheckBoxColumn colFav = new DataGridViewCheckBoxColumn();
            colFav.HeaderText = "Favourite";
            colFav.Name = "favourite";
            colFav.DataPropertyName = "favourite";
            colFav.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridGames.Columns.Add(colFav);


            dataGridGames.Columns.Add("name", "Name");
            dataGridGames.Columns["name"].DataPropertyName = "name";

            dataGridGames.Columns.Add("file_name", "File Name");
            dataGridGames.Columns["file_name"].DataPropertyName = "file_name";

            dataGridGames.Columns.Add("gamedb_id", "GamesDB ID");
            dataGridGames.Columns["gamedb_id"].DataPropertyName = "gamedb_id";

            dataGridGames.Columns.Add("description", "Description");
            dataGridGames.Columns["description"].DataPropertyName = "description";

            dataGridGames.Columns.Add("release_year", "Release Year");
            dataGridGames.Columns["release_year"].DataPropertyName = "release_year";

            dataGridGames.Columns.Add("rating", "Rating");
            dataGridGames.Columns["rating"].DataPropertyName = "rating";

            dataGridGames.Columns.Add("players", "Players");
            dataGridGames.Columns["players"].DataPropertyName = "players";

            DataGridViewCheckBoxColumn colCo_op = new DataGridViewCheckBoxColumn();
            colCo_op.HeaderText = "Co-op";
            colCo_op.Name = "co_op";
            colCo_op.DataPropertyName = "co_op";
            colCo_op.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridGames.Columns.Add(colCo_op);

            dataGridGames.Columns.Add("publisher", "Publisher");
            dataGridGames.Columns["publisher"].DataPropertyName = "publisher";

            dataGridGames.Columns.Add("developer", "Developer");
            dataGridGames.Columns["developer"].DataPropertyName = "developer";

            dataGridGames.Columns.Add("gamedb_stars", "GamesDB Stars");
            dataGridGames.Columns["gamedb_stars"].DataPropertyName = "gamedb_stars";

            dataGridGames.Columns.Add(colGenre);

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
        public void refreshAssetsDataSet()
        {
            assetsDataSet = db.getDataSet("select * from assets");
            dataGridAssets.DataSource = assetsDataSet.Tables[0];


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
                tabGenre.Enabled = true;
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


                }
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

                foreach (XElement game_node in xmlDoc.Descendants("game"))
                {
                    dbHandle.gameData newItem = new dbHandle.gameData();
                    newItem.platform_id = platform_id;

                    if (game_node.Element("crc") != null)
                        newItem.crc = game_node.Element("crc").Value;
                    else
                        newItem.crc = "";

                    newItem.file_name = game_node.Attribute("name").Value;
                    newItem.name = game_node.Element("description").Value;
                    newItem.developer = game_node.Element("manufacturer").Value;
                    newItem.rating = game_node.Element("rating").Value;
                    if (!Int64.TryParse(game_node.Element("year").Value, out newItem.release_year))
                        newItem.release_year = 0;

                    string genre = game_node.Element("genre").Value;
                    newItem.genre_id = db.getGenreID(genre);

                    db.upsertGamesDataset(newItem);

                }
            }
            
        }
        private void listboxPlatforms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fill in details on platform Tab
            DataSet ds = db.getDataSet("select * from platforms where id = " + listboxPlatforms.SelectedValue);
            long? platform_id_null = listboxPlatforms.SelectedValue as long?;
            platform_id = platform_id_null.GetValueOrDefault();

            cboxActive.Checked = ds.Tables[0].Rows[0].Field<bool>("active");
            txtLoadString.Text = ds.Tables[0].Rows[0].Field<string>("load_string");
            txtRomsPath.Text = ds.Tables[0].Rows[0].Field<string>("roms_path");
            txtVideosPath.Text = ds.Tables[0].Rows[0].Field<string>("videos_path");
            txtImagesPath.Text = ds.Tables[0].Rows[0].Field<string>("images_path");
            txtExtensions.Text = ds.Tables[0].Rows[0].Field<string>("extension");
            txtEmuPath.Text = ds.Tables[0].Rows[0].Field<string>("emu_path");

            string icon_id = ds.Tables[0].Rows[0].Field<string>("icon_id");
            if (icon_id == null)
                icon_id = "ERROR";
            DataSet ds_icons = db.getDataSet("select * from assets where type = 'image' order by name");
            cboxPlatformIcon.DisplayMember = "name";
            cboxPlatformIcon.ValueMember = "id";
            cboxPlatformIcon.DataSource = ds_icons.Tables[0];
            cboxPlatformIcon.SelectedValue = icon_id;
            refreshGamesDataSet();

        }
        private void dataGridGames_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridGames.Columns[e.ColumnIndex].Name.Equals("active"))
            {
                bool active = Convert.ToBoolean(e.Value);

                if (!active)
                {
                    dataGridGames.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(204, 102, 102);
                    dataGridGames.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 51, 51);
                }
                else
                {
                    dataGridGames.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(118, 196, 108);
                    dataGridGames.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(88, 186, 83);
                }
            }
        }
        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get dataset for selected genre
            long? genre_id = comboBoxGenres.ComboBox.SelectedValue as long?;
            DataSet ds = db.getDataSet("select * from genres where id = " + comboBoxGenres.ComboBox.SelectedValue);

            // set txtAltGenre text
            txtAltGenreNames.Text = ds.Tables[0].Rows[0].Field<string>("alt_names");

        }
        private void btnSaveGenre_Click(object sender, EventArgs e)
        {
            long? genre_id = comboBoxGenres.ComboBox.SelectedValue as long?;

            var command = new SQLiteCommand("update genres set alt_names = @alt_names where id = @genre_id");
            command.Parameters.AddWithValue("@alt_names", txtAltGenreNames.Text);
            command.Parameters.AddWithValue("@genre_id", genre_id);

            db.sqlExecute(command);
            infoBox.AppendText("\ngenre " + comboBoxGenres.ComboBox.Text + " updated \n");
            infoBox.gotToBottom();
        }
        private void btnClearPlatform_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to delete all " + listboxPlatforms.Text + " game data from the database?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
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
            var command = new SQLiteCommand("update platforms set emu_path = @emu_path, icon_id = @icon_id, load_string = @load_string, roms_path = @roms_path, videos_path = @videos_path, images_path = @images_path, extension = @extension, active = @active where id = @platform_id");
            command.Parameters.AddWithValue("@load_string", txtLoadString.Text);
            command.Parameters.AddWithValue("@roms_path", txtRomsPath.Text);
            command.Parameters.AddWithValue("@videos_path", txtVideosPath.Text);
            command.Parameters.AddWithValue("@images_path", txtImagesPath.Text);
            command.Parameters.AddWithValue("@extension", txtExtensions.Text);
            command.Parameters.AddWithValue("@icon_id", cboxPlatformIcon.SelectedValue as string);
            command.Parameters.AddWithValue("@emu_path", txtEmuPath.Text);


            if (cboxActive.Checked)
                command.Parameters.AddWithValue("@active", 1);
            else
                command.Parameters.AddWithValue("@active", 0);

            command.Parameters.AddWithValue("@platform_id", platform_id);

            db.sqlExecute(command);

            infoBox.AppendText(listboxPlatforms.Text, Color.WhiteSmoke);
            infoBox.AppendText("\n Changes Saved \n", Color.GreenYellow);
        }
        private void cboxOnlyActive_CheckedChanged(object sender, EventArgs e)
        {
            refreshPlatformsDataSet();
        }
        private void btnCheckAvalableRoms_Click(object sender, EventArgs e)
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
        private void btnAssetsSave_Click(object sender, EventArgs e)
        {
            db.SaveDataTable(assetsDataSet, "assets");
            assetsDataSet.AcceptChanges();
        }
        
        //Game Tab
        // get meta data from theGamesDB.net
        private void btnGameOnGameDB_Click(object sender, EventArgs e)
        {
            string platform_name = listboxPlatforms.Text;
            int selectedrows = dataGridGames.FirstDisplayedScrollingRowIndex;

            foreach (DataGridViewRow r in dataGridGames.SelectedRows)
            {
                string game_fileName = r.Cells["file_name"].Value as string;
                string game_name = r.Cells["name"].Value as string;
                string gamedb_id = db.getGameDB_ID(platform_id, game_fileName);

                if (gamedb_id == "0")
                {

                    string searchString = Regex.Replace(game_name, "(\\[.*\\])|(\\(.*\\))", ""); /// Remove all the text between square and round brackets
                    GameDB_Search gameDB_Search = new GameDB_Search(searchString, platform_name, game_fileName);

                    if (gameDB_Search.ShowDialog() == DialogResult.OK)
                    {
                        gamedb_id = gameDB_Search.ReturnedID;
                    }
                    else
                    {
                        continue;
                    }
                    // Write new gamedb_id to table
                    var command = new SQLiteCommand("update games set gamedb_id = @gamedb_id where platform_id = @platform_id and file_name = @file_name");
                    command.Parameters.AddWithValue("@gamedb_id", gamedb_id);
                    command.Parameters.AddWithValue("@file_name", game_fileName);
                    command.Parameters.AddWithValue("@platform_id", platform_id);
                    db.sqlExecute(command);
                }


                // get xml for game from gamesdb.net
                string url = string.Format("http://thegamesdb.net/api/GetGame.php?id={0}", gamedb_id);
                string xml = new WebClient().DownloadString(url);
                StringReader stringReader = new StringReader(xml);
                XDocument xmlDoc = XDocument.Load(stringReader);
                XElement game_node = xmlDoc.Descendants("Game").First();

                dbHandle.gameData updateItem = new dbHandle.gameData();

                updateItem.file_name = game_fileName;
                updateItem.platform_id = platform_id;
                
                if (game_node.Element("Overview") != null)
                    updateItem.description = game_node.Element("Overview").Value;
                if (game_node.Element("ReleaseDate") != null)
                {
                    string strReleaseDate = game_node.Element("ReleaseDate").Value;
                    DateTime releaseDateDate;
                    if (DateTime.TryParse(strReleaseDate, out releaseDateDate))
                    {
                        updateItem.release_year = releaseDateDate.Year;
                    } 
                }
                if (game_node.Element("ESRB") != null)
                    updateItem.rating = game_node.Element("ESRB").Value;
                if (game_node.Element("Players") != null)
                    updateItem.players = game_node.Element("Players").Value;
                
                if (game_node.Element("Co-op") != null)
                {
                    if (game_node.Element("Co-op").Value == "Yes")
                        updateItem.co_op = true;
                    else
                        updateItem.co_op = false;
                }
                else
                    updateItem.co_op = false;

                if (game_node.Element("Publisher") != null)
                    updateItem.publisher = game_node.Element("Publisher").Value;
                if (game_node.Element("Developer") != null)
                    updateItem.developer = game_node.Element("Developer").Value;
                if (game_node.Element("Rating") != null)
                    updateItem.gamedb_stars = Convert.ToDouble( game_node.Element("Rating").Value );

                db.upsertGamesDataset(updateItem);

                infoBox.AppendText(game_fileName + " checked on http://thegamesdb.net/ ID number " + gamedb_id + "\n", Color.WhiteSmoke);
            }
            dataGridGames.FirstDisplayedScrollingRowIndex = selectedrows;
        }



        private void btnGameAssets_Click(object sender, EventArgs e)
        {
            string imagesPath = txtImagesPath.Text.Replace("%PATH%", arcadiaPath);
            foreach (DataGridViewRow r in dataGridGames.SelectedRows)
            {
                string game_fileName = r.Cells["file_name"].Value as string;
                string gamedb_id = db.getGameDB_ID(platform_id, game_fileName);

                Game_ImageAssets game_assets = new Game_ImageAssets(platform_id, game_fileName, gamedb_id, imagesPath);

                if (game_assets.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
        private void btnGamesSave_Click(object sender, EventArgs e)
        {
            db.saveGamesDataset();
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