namespace Datacadia
{
    partial class Game_ImageAssets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_ImageAssets));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labSerchType = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFanArt = new System.Windows.Forms.ToolStripButton();
            this.btnScreenShot = new System.Windows.Forms.ToolStripButton();
            this.btnClearLogo = new System.Windows.Forms.ToolStripButton();
            this.btnReplaceWithSelected = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listView = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 28);
            this.panel2.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(359, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 22);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Done";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labSerchType);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.btnReplaceWithSelected);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.listView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 533);
            this.panel1.TabIndex = 5;
            // 
            // labSerchType
            // 
            this.labSerchType.AutoSize = true;
            this.labSerchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSerchType.Location = new System.Drawing.Point(12, 36);
            this.labSerchType.Name = "labSerchType";
            this.labSerchType.Size = new System.Drawing.Size(41, 13);
            this.labSerchType.TabIndex = 6;
            this.labSerchType.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFanArt,
            this.btnScreenShot,
            this.btnClearLogo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFanArt
            // 
            this.btnFanArt.Image = ((System.Drawing.Image)(resources.GetObject("btnFanArt.Image")));
            this.btnFanArt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFanArt.Name = "btnFanArt";
            this.btnFanArt.Size = new System.Drawing.Size(65, 22);
            this.btnFanArt.Text = "Fan Art";
            this.btnFanArt.Click += new System.EventHandler(this.btnFanArt_Click);
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Image = ((System.Drawing.Image)(resources.GetObject("btnScreenShot.Image")));
            this.btnScreenShot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(89, 22);
            this.btnScreenShot.Text = "Screen Shot";
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // btnClearLogo
            // 
            this.btnClearLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLogo.Image")));
            this.btnClearLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearLogo.Name = "btnClearLogo";
            this.btnClearLogo.Size = new System.Drawing.Size(84, 22);
            this.btnClearLogo.Text = "Clear Logo";
            this.btnClearLogo.Click += new System.EventHandler(this.btnClearLogo_Click);
            // 
            // btnReplaceWithSelected
            // 
            this.btnReplaceWithSelected.Location = new System.Drawing.Point(480, 466);
            this.btnReplaceWithSelected.Name = "btnReplaceWithSelected";
            this.btnReplaceWithSelected.Size = new System.Drawing.Size(87, 63);
            this.btnReplaceWithSelected.TabIndex = 4;
            this.btnReplaceWithSelected.Text = "Replace With Selected";
            this.btnReplaceWithSelected.UseVisualStyleBackColor = true;
            this.btnReplaceWithSelected.Click += new System.EventHandler(this.btnReplaceWithSelected_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 57);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(555, 403);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Location = new System.Drawing.Point(573, 36);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(208, 493);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // Game_ImageAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Game_ImageAssets";
            this.Text = "Image Assets from theGamesDB.net";
            this.Load += new System.EventHandler(this.Game_Images_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnReplaceWithSelected;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label labSerchType;
        private System.Windows.Forms.ToolStripButton btnFanArt;
        private System.Windows.Forms.ToolStripButton btnScreenShot;
        private System.Windows.Forms.ToolStripButton btnClearLogo;

    }
}