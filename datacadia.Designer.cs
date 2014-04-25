namespace Datacadia
{
    partial class datacadia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBrowseEXE = new System.Windows.Forms.Button();
            this.txtArcadiaEXEpath = new System.Windows.Forms.TextBox();
            this.btnBrowseDB = new System.Windows.Forms.Button();
            this.dbConnect = new System.Windows.Forms.Button();
            this.dbLocation = new System.Windows.Forms.TextBox();
            this.tabPlatforms = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmuPath = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLoadStringHelp = new System.Windows.Forms.Button();
            this.btnPlatformSave = new System.Windows.Forms.Button();
            this.txtLoadString = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cboxActive = new System.Windows.Forms.CheckBox();
            this.txtRomsPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExtensions = new System.Windows.Forms.TextBox();
            this.txtVideosPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImagesPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearPlatform = new System.Windows.Forms.Button();
            this.tabGames = new System.Windows.Forms.TabPage();
            this.dataGridGames = new System.Windows.Forms.DataGridView();
            this.btnActivateAvalableRoms = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLoadFromHyperSpin = new System.Windows.Forms.Button();
            this.cboxXMLUpdate = new System.Windows.Forms.CheckBox();
            this.cboxXMLInsert = new System.Windows.Forms.CheckBox();
            this.btnLoadFromNoIntro = new System.Windows.Forms.Button();
            this.tabGenre = new System.Windows.Forms.TabPage();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxPlatforms = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabControl1.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tabPlatforms.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGames)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConnection);
            this.tabControl1.Controls.Add(this.tabPlatforms);
            this.tabControl1.Controls.Add(this.tabGames);
            this.tabControl1.Controls.Add(this.tabGenre);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tabControl1.Location = new System.Drawing.Point(173, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 502);
            this.tabControl1.TabIndex = 1;
            // 
            // tabConnection
            // 
            this.tabConnection.BackColor = System.Drawing.Color.White;
            this.tabConnection.Controls.Add(this.label10);
            this.tabConnection.Controls.Add(this.btnBrowseEXE);
            this.tabConnection.Controls.Add(this.txtArcadiaEXEpath);
            this.tabConnection.Controls.Add(this.btnBrowseDB);
            this.tabConnection.Controls.Add(this.dbConnect);
            this.tabConnection.Controls.Add(this.dbLocation);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Size = new System.Drawing.Size(703, 476);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "connection";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(263, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "DATACADIA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseEXE
            // 
            this.btnBrowseEXE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseEXE.Location = new System.Drawing.Point(504, 32);
            this.btnBrowseEXE.Name = "btnBrowseEXE";
            this.btnBrowseEXE.Size = new System.Drawing.Size(50, 20);
            this.btnBrowseEXE.TabIndex = 5;
            this.btnBrowseEXE.Text = "Browse";
            this.btnBrowseEXE.UseVisualStyleBackColor = true;
            this.btnBrowseEXE.Click += new System.EventHandler(this.btnBrowseEXE_Click);
            // 
            // txtArcadiaEXEpath
            // 
            this.txtArcadiaEXEpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArcadiaEXEpath.Location = new System.Drawing.Point(6, 32);
            this.txtArcadiaEXEpath.Name = "txtArcadiaEXEpath";
            this.txtArcadiaEXEpath.Size = new System.Drawing.Size(492, 20);
            this.txtArcadiaEXEpath.TabIndex = 4;
            this.txtArcadiaEXEpath.Text = "C:\\Users\\Ashley\\Documents\\Visual Studio 2012\\Projects\\Arcadia\\Release\\arcadia.exe" +
    "";
            // 
            // btnBrowseDB
            // 
            this.btnBrowseDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDB.Location = new System.Drawing.Point(504, 6);
            this.btnBrowseDB.Name = "btnBrowseDB";
            this.btnBrowseDB.Size = new System.Drawing.Size(50, 20);
            this.btnBrowseDB.TabIndex = 3;
            this.btnBrowseDB.Text = "Browse";
            this.btnBrowseDB.UseVisualStyleBackColor = true;
            this.btnBrowseDB.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dbConnect
            // 
            this.dbConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dbConnect.BackColor = System.Drawing.Color.YellowGreen;
            this.dbConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbConnect.ForeColor = System.Drawing.Color.Black;
            this.dbConnect.Location = new System.Drawing.Point(560, 6);
            this.dbConnect.Name = "dbConnect";
            this.dbConnect.Size = new System.Drawing.Size(135, 46);
            this.dbConnect.TabIndex = 1;
            this.dbConnect.Text = "connect";
            this.dbConnect.UseVisualStyleBackColor = false;
            this.dbConnect.Click += new System.EventHandler(this.dbConnect_Click);
            // 
            // dbLocation
            // 
            this.dbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbLocation.Location = new System.Drawing.Point(6, 6);
            this.dbLocation.Name = "dbLocation";
            this.dbLocation.Size = new System.Drawing.Size(492, 20);
            this.dbLocation.TabIndex = 0;
            this.dbLocation.Text = "C:\\Users\\Ashley\\Documents\\Visual Studio 2012\\Projects\\Arcadia\\Release\\database.db" +
    "";
            // 
            // tabPlatforms
            // 
            this.tabPlatforms.Controls.Add(this.groupBox2);
            this.tabPlatforms.Controls.Add(this.panel1);
            this.tabPlatforms.Location = new System.Drawing.Point(4, 22);
            this.tabPlatforms.Margin = new System.Windows.Forms.Padding(0);
            this.tabPlatforms.Name = "tabPlatforms";
            this.tabPlatforms.Size = new System.Drawing.Size(664, 376);
            this.tabPlatforms.TabIndex = 1;
            this.tabPlatforms.Text = "platforms";
            this.tabPlatforms.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmuPath);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnLoadStringHelp);
            this.groupBox2.Controls.Add(this.btnPlatformSave);
            this.groupBox2.Controls.Add(this.txtLoadString);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.cboxActive);
            this.groupBox2.Controls.Add(this.txtRomsPath);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtExtensions);
            this.groupBox2.Controls.Add(this.txtVideosPath);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtImagesPath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 234);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Platform\'s Settings";
            // 
            // txtEmuPath
            // 
            this.txtEmuPath.Location = new System.Drawing.Point(70, 76);
            this.txtEmuPath.Name = "txtEmuPath";
            this.txtEmuPath.Size = new System.Drawing.Size(285, 20);
            this.txtEmuPath.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(355, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 20);
            this.button5.TabIndex = 27;
            this.button5.Text = "Browse";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Emu Path";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLoadStringHelp
            // 
            this.btnLoadStringHelp.BackColor = System.Drawing.Color.Gold;
            this.btnLoadStringHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStringHelp.Location = new System.Drawing.Point(393, 39);
            this.btnLoadStringHelp.Name = "btnLoadStringHelp";
            this.btnLoadStringHelp.Size = new System.Drawing.Size(17, 23);
            this.btnLoadStringHelp.TabIndex = 24;
            this.btnLoadStringHelp.Text = "?";
            this.btnLoadStringHelp.UseVisualStyleBackColor = false;
            // 
            // btnPlatformSave
            // 
            this.btnPlatformSave.Location = new System.Drawing.Point(294, 205);
            this.btnPlatformSave.Name = "btnPlatformSave";
            this.btnPlatformSave.Size = new System.Drawing.Size(116, 23);
            this.btnPlatformSave.TabIndex = 23;
            this.btnPlatformSave.Text = "Save Changes";
            this.btnPlatformSave.UseVisualStyleBackColor = true;
            this.btnPlatformSave.Click += new System.EventHandler(this.btnPlatformSave_Click);
            // 
            // txtLoadString
            // 
            this.txtLoadString.Location = new System.Drawing.Point(70, 41);
            this.txtLoadString.Name = "txtLoadString";
            this.txtLoadString.Size = new System.Drawing.Size(320, 20);
            this.txtLoadString.TabIndex = 3;
            this.txtLoadString.TextChanged += new System.EventHandler(this.txtLoadString_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 20);
            this.button4.TabIndex = 22;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Load String";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 20);
            this.button3.TabIndex = 21;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cboxActive
            // 
            this.cboxActive.AutoSize = true;
            this.cboxActive.Location = new System.Drawing.Point(355, 12);
            this.cboxActive.Name = "cboxActive";
            this.cboxActive.Size = new System.Drawing.Size(55, 17);
            this.cboxActive.TabIndex = 2;
            this.cboxActive.Text = "active";
            this.cboxActive.UseVisualStyleBackColor = true;
            this.cboxActive.CheckedChanged += new System.EventHandler(this.cboxActive_CheckedChanged);
            // 
            // txtRomsPath
            // 
            this.txtRomsPath.Location = new System.Drawing.Point(70, 102);
            this.txtRomsPath.Name = "txtRomsPath";
            this.txtRomsPath.Size = new System.Drawing.Size(285, 20);
            this.txtRomsPath.TabIndex = 5;
            this.txtRomsPath.TextChanged += new System.EventHandler(this.txtRomsPath_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 20);
            this.button2.TabIndex = 20;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Roms Path";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExtensions
            // 
            this.txtExtensions.Location = new System.Drawing.Point(97, 179);
            this.txtExtensions.Name = "txtExtensions";
            this.txtExtensions.Size = new System.Drawing.Size(313, 20);
            this.txtExtensions.TabIndex = 11;
            this.txtExtensions.TextChanged += new System.EventHandler(this.txtExtensions_TextChanged);
            // 
            // txtVideosPath
            // 
            this.txtVideosPath.Location = new System.Drawing.Point(70, 128);
            this.txtVideosPath.Name = "txtVideosPath";
            this.txtVideosPath.Size = new System.Drawing.Size(285, 20);
            this.txtVideosPath.TabIndex = 7;
            this.txtVideosPath.TextChanged += new System.EventHandler(this.txtVideosPath_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "rom file extensions";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Videos Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtImagesPath
            // 
            this.txtImagesPath.Location = new System.Drawing.Point(70, 153);
            this.txtImagesPath.Name = "txtImagesPath";
            this.txtImagesPath.Size = new System.Drawing.Size(285, 20);
            this.txtImagesPath.TabIndex = 9;
            this.txtImagesPath.TextChanged += new System.EventHandler(this.txtImagesPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Images Path";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnClearPlatform);
            this.panel1.Location = new System.Drawing.Point(472, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 46);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "-DANGER ZONE-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearPlatform
            // 
            this.btnClearPlatform.Location = new System.Drawing.Point(3, 18);
            this.btnClearPlatform.Name = "btnClearPlatform";
            this.btnClearPlatform.Size = new System.Drawing.Size(178, 25);
            this.btnClearPlatform.TabIndex = 13;
            this.btnClearPlatform.Text = "Clear Platform\'s Games";
            this.btnClearPlatform.UseVisualStyleBackColor = true;
            // 
            // tabGames
            // 
            this.tabGames.Controls.Add(this.dataGridGames);
            this.tabGames.Controls.Add(this.btnActivateAvalableRoms);
            this.tabGames.Controls.Add(this.groupBox1);
            this.tabGames.Location = new System.Drawing.Point(4, 22);
            this.tabGames.Name = "tabGames";
            this.tabGames.Padding = new System.Windows.Forms.Padding(3);
            this.tabGames.Size = new System.Drawing.Size(664, 376);
            this.tabGames.TabIndex = 2;
            this.tabGames.Text = "games";
            this.tabGames.UseVisualStyleBackColor = true;
            // 
            // dataGridGames
            // 
            this.dataGridGames.AllowUserToAddRows = false;
            this.dataGridGames.AllowUserToDeleteRows = false;
            this.dataGridGames.AllowUserToResizeRows = false;
            this.dataGridGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGames.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridGames.Location = new System.Drawing.Point(3, 85);
            this.dataGridGames.Name = "dataGridGames";
            this.dataGridGames.ReadOnly = true;
            this.dataGridGames.Size = new System.Drawing.Size(658, 288);
            this.dataGridGames.TabIndex = 22;
            this.dataGridGames.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridGames_CellFormatting);
            // 
            // btnActivateAvalableRoms
            // 
            this.btnActivateAvalableRoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivateAvalableRoms.Enabled = false;
            this.btnActivateAvalableRoms.Location = new System.Drawing.Point(524, 56);
            this.btnActivateAvalableRoms.Name = "btnActivateAvalableRoms";
            this.btnActivateAvalableRoms.Size = new System.Drawing.Size(132, 23);
            this.btnActivateAvalableRoms.TabIndex = 21;
            this.btnActivateAvalableRoms.Text = "Activate Avalable Roms";
            this.btnActivateAvalableRoms.UseVisualStyleBackColor = true;
            this.btnActivateAvalableRoms.Click += new System.EventHandler(this.btnActivateAvalableRoms_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLoadFromHyperSpin);
            this.groupBox1.Controls.Add(this.cboxXMLUpdate);
            this.groupBox1.Controls.Add(this.cboxXMLInsert);
            this.groupBox1.Controls.Add(this.btnLoadFromNoIntro);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 41);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load platform rom data from XML";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(392, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Recomend you do not insert from both";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLoadFromHyperSpin
            // 
            this.btnLoadFromHyperSpin.Location = new System.Drawing.Point(261, 12);
            this.btnLoadFromHyperSpin.Name = "btnLoadFromHyperSpin";
            this.btnLoadFromHyperSpin.Size = new System.Drawing.Size(125, 23);
            this.btnLoadFromHyperSpin.TabIndex = 17;
            this.btnLoadFromHyperSpin.Text = "Load Hyperspin XML";
            this.btnLoadFromHyperSpin.UseVisualStyleBackColor = true;
            this.btnLoadFromHyperSpin.Click += new System.EventHandler(this.btnLoadFromHyperSpin_Click);
            // 
            // cboxXMLUpdate
            // 
            this.cboxXMLUpdate.AutoSize = true;
            this.cboxXMLUpdate.Location = new System.Drawing.Point(65, 18);
            this.cboxXMLUpdate.Name = "cboxXMLUpdate";
            this.cboxXMLUpdate.Size = new System.Drawing.Size(59, 17);
            this.cboxXMLUpdate.TabIndex = 16;
            this.cboxXMLUpdate.Text = "update";
            this.cboxXMLUpdate.UseVisualStyleBackColor = true;
            // 
            // cboxXMLInsert
            // 
            this.cboxXMLInsert.AutoSize = true;
            this.cboxXMLInsert.Location = new System.Drawing.Point(7, 18);
            this.cboxXMLInsert.Name = "cboxXMLInsert";
            this.cboxXMLInsert.Size = new System.Drawing.Size(52, 17);
            this.cboxXMLInsert.TabIndex = 15;
            this.cboxXMLInsert.Text = "Insert";
            this.cboxXMLInsert.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromNoIntro
            // 
            this.btnLoadFromNoIntro.Location = new System.Drawing.Point(130, 12);
            this.btnLoadFromNoIntro.Name = "btnLoadFromNoIntro";
            this.btnLoadFromNoIntro.Size = new System.Drawing.Size(125, 23);
            this.btnLoadFromNoIntro.TabIndex = 14;
            this.btnLoadFromNoIntro.Text = "Load No-Intro XML";
            this.btnLoadFromNoIntro.UseVisualStyleBackColor = true;
            this.btnLoadFromNoIntro.Click += new System.EventHandler(this.btnLoadFromNoIntro_Click);
            // 
            // tabGenre
            // 
            this.tabGenre.Location = new System.Drawing.Point(4, 22);
            this.tabGenre.Name = "tabGenre";
            this.tabGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenre.Size = new System.Drawing.Size(664, 376);
            this.tabGenre.TabIndex = 3;
            this.tabGenre.Text = "genre";
            this.tabGenre.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.Black;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.infoBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.infoBox.Location = new System.Drawing.Point(173, 526);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(711, 113);
            this.infoBox.TabIndex = 17;
            this.infoBox.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.toolStripStatus,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // listboxPlatforms
            // 
            this.listboxPlatforms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxPlatforms.Dock = System.Windows.Forms.DockStyle.Left;
            this.listboxPlatforms.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxPlatforms.FormattingEnabled = true;
            this.listboxPlatforms.Location = new System.Drawing.Point(0, 24);
            this.listboxPlatforms.Name = "listboxPlatforms";
            this.listboxPlatforms.Size = new System.Drawing.Size(173, 615);
            this.listboxPlatforms.TabIndex = 20;
            this.listboxPlatforms.SelectedIndexChanged += new System.EventHandler(this.listboxPlatforms_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(173, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 502);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(176, 523);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(708, 3);
            this.splitter2.TabIndex = 22;
            this.splitter2.TabStop = false;
            // 
            // datacadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.listboxPlatforms);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "datacadia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datacadia";
            this.tabControl1.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.tabPlatforms.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabGames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGames)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.TabPage tabPlatforms;
        private System.Windows.Forms.Button dbConnect;
        private System.Windows.Forms.TextBox dbLocation;
        private System.Windows.Forms.Button btnBrowseDB;
        private System.Windows.Forms.CheckBox cboxActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVideosPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRomsPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoadString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImagesPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExtensions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearPlatform;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabGames;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPlatformSave;
        private System.Windows.Forms.TextBox txtArcadiaEXEpath;
        private System.Windows.Forms.Button btnBrowseEXE;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadStringHelp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmuPath;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLoadFromHyperSpin;
        private System.Windows.Forms.CheckBox cboxXMLUpdate;
        private System.Windows.Forms.CheckBox cboxXMLInsert;
        private System.Windows.Forms.Button btnLoadFromNoIntro;
        private System.Windows.Forms.ListBox listboxPlatforms;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnActivateAvalableRoms;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView dataGridGames;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabGenre;

    }
}

