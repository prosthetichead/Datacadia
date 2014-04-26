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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datacadia));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBrowseEXE = new System.Windows.Forms.Button();
            this.txtArcadiaEXEpath = new System.Windows.Forms.TextBox();
            this.btnBrowseDB = new System.Windows.Forms.Button();
            this.dbConnect = new System.Windows.Forms.Button();
            this.dbLocation = new System.Windows.Forms.TextBox();
            this.tabPlatforms = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLoadString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmuPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImagesPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVideosPath = new System.Windows.Forms.TextBox();
            this.txtExtensions = new System.Windows.Forms.TextBox();
            this.cboxActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRomsPath = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelPlatforms = new System.Windows.Forms.ToolStripLabel();
            this.btnPlatformsSave = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearPlatform = new System.Windows.Forms.Button();
            this.btnPlatformSave = new System.Windows.Forms.Button();
            this.tabGames = new System.Windows.Forms.TabPage();
            this.dataGridGames = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnActivateAvalableRoms = new System.Windows.Forms.Button();
            this.btnLoadFromHyperSpin = new System.Windows.Forms.Button();
            this.cboxXMLUpdate = new System.Windows.Forms.CheckBox();
            this.cboxXMLInsert = new System.Windows.Forms.CheckBox();
            this.btnLoadFromNoIntro = new System.Windows.Forms.Button();
            this.tabGenre = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAltGenreNames = new System.Windows.Forms.TextBox();
            this.toolStripGenre = new System.Windows.Forms.ToolStrip();
            this.comboBoxGenres = new System.Windows.Forms.ToolStripComboBox();
            this.btnSaveGenre = new System.Windows.Forms.ToolStripButton();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxPlatforms = new System.Windows.Forms.ListBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboxOnlyActive = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tabPlatforms.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGames)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabGenre.SuspendLayout();
            this.toolStripGenre.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(2, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 499);
            this.tabControl1.TabIndex = 1;
            // 
            // tabConnection
            // 
            this.tabConnection.BackColor = System.Drawing.Color.SlateGray;
            this.tabConnection.Controls.Add(this.label10);
            this.tabConnection.Controls.Add(this.btnBrowseEXE);
            this.tabConnection.Controls.Add(this.txtArcadiaEXEpath);
            this.tabConnection.Controls.Add(this.btnBrowseDB);
            this.tabConnection.Controls.Add(this.dbConnect);
            this.tabConnection.Controls.Add(this.dbLocation);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(1);
            this.tabConnection.Size = new System.Drawing.Size(721, 473);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(264, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "DATACADIA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseEXE
            // 
            this.btnBrowseEXE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseEXE.Location = new System.Drawing.Point(521, 33);
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
            this.txtArcadiaEXEpath.Location = new System.Drawing.Point(7, 33);
            this.txtArcadiaEXEpath.Name = "txtArcadiaEXEpath";
            this.txtArcadiaEXEpath.Size = new System.Drawing.Size(508, 22);
            this.txtArcadiaEXEpath.TabIndex = 4;
            this.txtArcadiaEXEpath.Text = "C:\\Users\\Ashley\\Documents\\Visual Studio 2012\\Projects\\Arcadia\\Release\\arcadia.exe" +
    "";
            // 
            // btnBrowseDB
            // 
            this.btnBrowseDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDB.Location = new System.Drawing.Point(521, 7);
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
            this.dbConnect.Location = new System.Drawing.Point(577, 7);
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
            this.dbLocation.Location = new System.Drawing.Point(7, 7);
            this.dbLocation.Name = "dbLocation";
            this.dbLocation.Size = new System.Drawing.Size(508, 22);
            this.dbLocation.TabIndex = 0;
            this.dbLocation.Text = "C:\\Users\\Ashley\\Documents\\Visual Studio 2012\\Projects\\Arcadia\\Release\\database.db" +
    "";
            // 
            // tabPlatforms
            // 
            this.tabPlatforms.Controls.Add(this.panel2);
            this.tabPlatforms.Controls.Add(this.panel3);
            this.tabPlatforms.Controls.Add(this.toolStrip1);
            this.tabPlatforms.Controls.Add(this.panel1);
            this.tabPlatforms.Controls.Add(this.btnPlatformSave);
            this.tabPlatforms.Location = new System.Drawing.Point(4, 22);
            this.tabPlatforms.Name = "tabPlatforms";
            this.tabPlatforms.Padding = new System.Windows.Forms.Padding(1);
            this.tabPlatforms.Size = new System.Drawing.Size(721, 473);
            this.tabPlatforms.TabIndex = 1;
            this.tabPlatforms.Text = "Platforms";
            this.tabPlatforms.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.txtLoadString);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 124);
            this.panel2.TabIndex = 29;
            // 
            // txtLoadString
            // 
            this.txtLoadString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoadString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoadString.Location = new System.Drawing.Point(74, 3);
            this.txtLoadString.Name = "txtLoadString";
            this.txtLoadString.Size = new System.Drawing.Size(642, 22);
            this.txtLoadString.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Load String";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEmuPath);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtImagesPath);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtVideosPath);
            this.panel3.Controls.Add(this.txtExtensions);
            this.panel3.Controls.Add(this.cboxActive);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtRomsPath);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 183);
            this.panel3.TabIndex = 29;
            // 
            // txtEmuPath
            // 
            this.txtEmuPath.Location = new System.Drawing.Point(113, 35);
            this.txtEmuPath.Name = "txtEmuPath";
            this.txtEmuPath.Size = new System.Drawing.Size(285, 22);
            this.txtEmuPath.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Emu Path";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Images Path";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtImagesPath
            // 
            this.txtImagesPath.Location = new System.Drawing.Point(113, 112);
            this.txtImagesPath.Name = "txtImagesPath";
            this.txtImagesPath.Size = new System.Drawing.Size(285, 22);
            this.txtImagesPath.TabIndex = 9;
            this.txtImagesPath.TextChanged += new System.EventHandler(this.txtImagesPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Videos Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "rom file extensions";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVideosPath
            // 
            this.txtVideosPath.Location = new System.Drawing.Point(113, 87);
            this.txtVideosPath.Name = "txtVideosPath";
            this.txtVideosPath.Size = new System.Drawing.Size(285, 22);
            this.txtVideosPath.TabIndex = 7;
            this.txtVideosPath.TextChanged += new System.EventHandler(this.txtVideosPath_TextChanged);
            // 
            // txtExtensions
            // 
            this.txtExtensions.Location = new System.Drawing.Point(113, 140);
            this.txtExtensions.Name = "txtExtensions";
            this.txtExtensions.Size = new System.Drawing.Size(285, 22);
            this.txtExtensions.TabIndex = 11;
            this.txtExtensions.TextChanged += new System.EventHandler(this.txtExtensions_TextChanged);
            // 
            // cboxActive
            // 
            this.cboxActive.AutoSize = true;
            this.cboxActive.Location = new System.Drawing.Point(343, 12);
            this.cboxActive.Name = "cboxActive";
            this.cboxActive.Size = new System.Drawing.Size(55, 17);
            this.cboxActive.TabIndex = 2;
            this.cboxActive.Text = "active";
            this.cboxActive.UseVisualStyleBackColor = true;
            this.cboxActive.CheckedChanged += new System.EventHandler(this.cboxActive_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Roms Path";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRomsPath
            // 
            this.txtRomsPath.Location = new System.Drawing.Point(113, 61);
            this.txtRomsPath.Name = "txtRomsPath";
            this.txtRomsPath.Size = new System.Drawing.Size(285, 22);
            this.txtRomsPath.TabIndex = 5;
            this.txtRomsPath.TextChanged += new System.EventHandler(this.txtRomsPath_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelPlatforms,
            this.btnPlatformsSave});
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(719, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelPlatforms
            // 
            this.toolStripLabelPlatforms.Name = "toolStripLabelPlatforms";
            this.toolStripLabelPlatforms.Size = new System.Drawing.Size(0, 22);
            // 
            // btnPlatformsSave
            // 
            this.btnPlatformsSave.Image = ((System.Drawing.Image)(resources.GetObject("btnPlatformsSave.Image")));
            this.btnPlatformsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlatformsSave.Name = "btnPlatformsSave";
            this.btnPlatformsSave.Size = new System.Drawing.Size(51, 22);
            this.btnPlatformsSave.Text = "Save";
            this.btnPlatformsSave.Click += new System.EventHandler(this.btnPlatformsSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnClearPlatform);
            this.panel1.Location = new System.Drawing.Point(511, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 46);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
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
            this.btnClearPlatform.Click += new System.EventHandler(this.btnClearPlatform_Click);
            // 
            // btnPlatformSave
            // 
            this.btnPlatformSave.Location = new System.Drawing.Point(25, 379);
            this.btnPlatformSave.Name = "btnPlatformSave";
            this.btnPlatformSave.Size = new System.Drawing.Size(116, 23);
            this.btnPlatformSave.TabIndex = 23;
            this.btnPlatformSave.Text = "Save Changes";
            this.btnPlatformSave.UseVisualStyleBackColor = true;
            // 
            // tabGames
            // 
            this.tabGames.Controls.Add(this.dataGridGames);
            this.tabGames.Controls.Add(this.groupBox1);
            this.tabGames.Location = new System.Drawing.Point(4, 22);
            this.tabGames.Name = "tabGames";
            this.tabGames.Padding = new System.Windows.Forms.Padding(1);
            this.tabGames.Size = new System.Drawing.Size(721, 473);
            this.tabGames.TabIndex = 2;
            this.tabGames.Text = "Games";
            this.tabGames.UseVisualStyleBackColor = true;
            // 
            // dataGridGames
            // 
            this.dataGridGames.AllowUserToAddRows = false;
            this.dataGridGames.AllowUserToDeleteRows = false;
            this.dataGridGames.AllowUserToResizeRows = false;
            this.dataGridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGames.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridGames.Location = new System.Drawing.Point(1, 52);
            this.dataGridGames.Name = "dataGridGames";
            this.dataGridGames.ReadOnly = true;
            this.dataGridGames.Size = new System.Drawing.Size(719, 420);
            this.dataGridGames.TabIndex = 22;
            this.dataGridGames.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridGames_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnActivateAvalableRoms);
            this.groupBox1.Controls.Add(this.btnLoadFromHyperSpin);
            this.groupBox1.Controls.Add(this.cboxXMLUpdate);
            this.groupBox1.Controls.Add(this.cboxXMLInsert);
            this.groupBox1.Controls.Add(this.btnLoadFromNoIntro);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 51);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load platform rom data from XML";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(153, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Recomend you do not insert from both";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnActivateAvalableRoms
            // 
            this.btnActivateAvalableRoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivateAvalableRoms.Enabled = false;
            this.btnActivateAvalableRoms.Location = new System.Drawing.Point(581, 18);
            this.btnActivateAvalableRoms.Name = "btnActivateAvalableRoms";
            this.btnActivateAvalableRoms.Size = new System.Drawing.Size(132, 23);
            this.btnActivateAvalableRoms.TabIndex = 21;
            this.btnActivateAvalableRoms.Text = "Activate Avalable Roms";
            this.btnActivateAvalableRoms.UseVisualStyleBackColor = true;
            this.btnActivateAvalableRoms.Click += new System.EventHandler(this.btnActivateAvalableRoms_Click);
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
            this.cboxXMLUpdate.Size = new System.Drawing.Size(63, 17);
            this.cboxXMLUpdate.TabIndex = 16;
            this.cboxXMLUpdate.Text = "update";
            this.cboxXMLUpdate.UseVisualStyleBackColor = true;
            // 
            // cboxXMLInsert
            // 
            this.cboxXMLInsert.AutoSize = true;
            this.cboxXMLInsert.Location = new System.Drawing.Point(7, 18);
            this.cboxXMLInsert.Name = "cboxXMLInsert";
            this.cboxXMLInsert.Size = new System.Drawing.Size(55, 17);
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
            this.tabGenre.Controls.Add(this.label11);
            this.tabGenre.Controls.Add(this.label1);
            this.tabGenre.Controls.Add(this.txtAltGenreNames);
            this.tabGenre.Controls.Add(this.toolStripGenre);
            this.tabGenre.Location = new System.Drawing.Point(4, 22);
            this.tabGenre.Name = "tabGenre";
            this.tabGenre.Padding = new System.Windows.Forms.Padding(1);
            this.tabGenre.Size = new System.Drawing.Size(721, 473);
            this.tabGenre.TabIndex = 3;
            this.tabGenre.Text = "Genre Settings";
            this.tabGenre.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(366, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Names should be writen in double quotes (\") and seperated by spaces";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alternative genre names";
            // 
            // txtAltGenreNames
            // 
            this.txtAltGenreNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAltGenreNames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAltGenreNames.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltGenreNames.Location = new System.Drawing.Point(1, 179);
            this.txtAltGenreNames.Multiline = true;
            this.txtAltGenreNames.Name = "txtAltGenreNames";
            this.txtAltGenreNames.Size = new System.Drawing.Size(719, 293);
            this.txtAltGenreNames.TabIndex = 2;
            // 
            // toolStripGenre
            // 
            this.toolStripGenre.BackColor = System.Drawing.Color.Transparent;
            this.toolStripGenre.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripGenre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxGenres,
            this.btnSaveGenre});
            this.toolStripGenre.Location = new System.Drawing.Point(1, 1);
            this.toolStripGenre.Name = "toolStripGenre";
            this.toolStripGenre.Size = new System.Drawing.Size(719, 25);
            this.toolStripGenre.TabIndex = 1;
            this.toolStripGenre.Text = "toolStripGenre";
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(121, 25);
            this.comboBoxGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenres_SelectedIndexChanged);
            // 
            // btnSaveGenre
            // 
            this.btnSaveGenre.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveGenre.Image")));
            this.btnSaveGenre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveGenre.Name = "btnSaveGenre";
            this.btnSaveGenre.Size = new System.Drawing.Size(51, 22);
            this.btnSaveGenre.Text = "Save";
            this.btnSaveGenre.Click += new System.EventHandler(this.btnSaveGenre_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.Black;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.infoBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.infoBox.Location = new System.Drawing.Point(0, 526);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(884, 113);
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
            this.listboxPlatforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxPlatforms.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxPlatforms.FormattingEnabled = true;
            this.listboxPlatforms.Location = new System.Drawing.Point(0, 0);
            this.listboxPlatforms.Name = "listboxPlatforms";
            this.listboxPlatforms.Size = new System.Drawing.Size(152, 499);
            this.listboxPlatforms.TabIndex = 20;
            this.listboxPlatforms.SelectedIndexChanged += new System.EventHandler(this.listboxPlatforms_SelectedIndexChanged);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Black;
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 523);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(884, 3);
            this.splitter2.TabIndex = 22;
            this.splitter2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.listboxPlatforms);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 499);
            this.panel4.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Controls.Add(this.cboxOnlyActive);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 465);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 34);
            this.panel6.TabIndex = 21;
            // 
            // cboxOnlyActive
            // 
            this.cboxOnlyActive.AutoSize = true;
            this.cboxOnlyActive.Checked = true;
            this.cboxOnlyActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxOnlyActive.Enabled = false;
            this.cboxOnlyActive.ForeColor = System.Drawing.Color.Black;
            this.cboxOnlyActive.Location = new System.Drawing.Point(12, 8);
            this.cboxOnlyActive.Name = "cboxOnlyActive";
            this.cboxOnlyActive.Size = new System.Drawing.Size(117, 17);
            this.cboxOnlyActive.TabIndex = 0;
            this.cboxOnlyActive.Text = "Show only active?";
            this.cboxOnlyActive.UseVisualStyleBackColor = true;
            this.cboxOnlyActive.CheckedChanged += new System.EventHandler(this.cboxOnlyActive_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(152, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 499);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tabControl1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(155, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(729, 499);
            this.panel5.TabIndex = 25;
            // 
            // datacadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "datacadia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datacadia";
            this.tabControl1.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.tabPlatforms.ResumeLayout(false);
            this.tabPlatforms.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabGames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGames)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabGenre.ResumeLayout(false);
            this.tabGenre.PerformLayout();
            this.toolStripGenre.ResumeLayout(false);
            this.toolStripGenre.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImagesPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExtensions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearPlatform;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabGames;
        private System.Windows.Forms.Button btnPlatformSave;
        private System.Windows.Forms.TextBox txtArcadiaEXEpath;
        private System.Windows.Forms.Button btnBrowseEXE;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmuPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLoadFromHyperSpin;
        private System.Windows.Forms.CheckBox cboxXMLUpdate;
        private System.Windows.Forms.CheckBox cboxXMLInsert;
        private System.Windows.Forms.Button btnLoadFromNoIntro;
        private System.Windows.Forms.ListBox listboxPlatforms;
        private System.Windows.Forms.Button btnActivateAvalableRoms;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView dataGridGames;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabGenre;
        private System.Windows.Forms.ToolStrip toolStripGenre;
        private System.Windows.Forms.ToolStripButton btnSaveGenre;
        private System.Windows.Forms.ToolStripComboBox comboBoxGenres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAltGenreNames;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLoadString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPlatforms;
        private System.Windows.Forms.ToolStripButton btnPlatformsSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cboxOnlyActive;

    }
}

