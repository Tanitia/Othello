
namespace Assignment1TMoore
{
    partial class othelloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(othelloForm));
            this.pinkPanel = new System.Windows.Forms.Panel();
            this.blackToPlayImage = new System.Windows.Forms.PictureBox();
            this.whiteToPlayImage = new System.Windows.Forms.PictureBox();
            this.blackLabel = new System.Windows.Forms.Label();
            this.whiteLabel = new System.Windows.Forms.Label();
            this.blackTextBox = new System.Windows.Forms.TextBox();
            this.whiteTextBox = new System.Windows.Forms.TextBox();
            this.blackPlayerBox = new System.Windows.Forms.PictureBox();
            this.whitePlayerBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.pinkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackToPlayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteToPlayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePlayerBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pinkPanel
            // 
            this.pinkPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pinkPanel.Controls.Add(this.blackToPlayImage);
            this.pinkPanel.Controls.Add(this.whiteToPlayImage);
            this.pinkPanel.Controls.Add(this.blackLabel);
            this.pinkPanel.Controls.Add(this.whiteLabel);
            this.pinkPanel.Controls.Add(this.blackTextBox);
            this.pinkPanel.Controls.Add(this.whiteTextBox);
            this.pinkPanel.Controls.Add(this.blackPlayerBox);
            this.pinkPanel.Controls.Add(this.whitePlayerBox);
            this.pinkPanel.Location = new System.Drawing.Point(23, 753);
            this.pinkPanel.Name = "pinkPanel";
            this.pinkPanel.Size = new System.Drawing.Size(776, 100);
            this.pinkPanel.TabIndex = 0;
            // 
            // blackToPlayImage
            // 
            this.blackToPlayImage.Image = global::Assignment1TMoore.Properties.Resources.to_play;
            this.blackToPlayImage.InitialImage = global::Assignment1TMoore.Properties.Resources.to_play;
            this.blackToPlayImage.Location = new System.Drawing.Point(572, 0);
            this.blackToPlayImage.Name = "blackToPlayImage";
            this.blackToPlayImage.Size = new System.Drawing.Size(162, 60);
            this.blackToPlayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackToPlayImage.TabIndex = 7;
            this.blackToPlayImage.TabStop = false;
            // 
            // whiteToPlayImage
            // 
            this.whiteToPlayImage.Image = global::Assignment1TMoore.Properties.Resources.to_play;
            this.whiteToPlayImage.InitialImage = global::Assignment1TMoore.Properties.Resources.to_play;
            this.whiteToPlayImage.Location = new System.Drawing.Point(166, 0);
            this.whiteToPlayImage.Name = "whiteToPlayImage";
            this.whiteToPlayImage.Size = new System.Drawing.Size(162, 60);
            this.whiteToPlayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.whiteToPlayImage.TabIndex = 6;
            this.whiteToPlayImage.TabStop = false;
            // 
            // blackLabel
            // 
            this.blackLabel.AutoSize = true;
            this.blackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackLabel.Location = new System.Drawing.Point(446, 49);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(36, 39);
            this.blackLabel.TabIndex = 5;
            this.blackLabel.Text = "2";
            // 
            // whiteLabel
            // 
            this.whiteLabel.AutoSize = true;
            this.whiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteLabel.Location = new System.Drawing.Point(27, 49);
            this.whiteLabel.Name = "whiteLabel";
            this.whiteLabel.Size = new System.Drawing.Size(36, 39);
            this.whiteLabel.TabIndex = 4;
            this.whiteLabel.Text = "2";
            // 
            // blackTextBox
            // 
            this.blackTextBox.Location = new System.Drawing.Point(587, 66);
            this.blackTextBox.Name = "blackTextBox";
            this.blackTextBox.Size = new System.Drawing.Size(133, 22);
            this.blackTextBox.TabIndex = 3;
            // 
            // whiteTextBox
            // 
            this.whiteTextBox.Location = new System.Drawing.Point(177, 66);
            this.whiteTextBox.Name = "whiteTextBox";
            this.whiteTextBox.Size = new System.Drawing.Size(133, 22);
            this.whiteTextBox.TabIndex = 2;
            // 
            // blackPlayerBox
            // 
            this.blackPlayerBox.Image = global::Assignment1TMoore.Properties.Resources._0;
            this.blackPlayerBox.InitialImage = global::Assignment1TMoore.Properties.Resources._0;
            this.blackPlayerBox.Location = new System.Drawing.Point(515, 37);
            this.blackPlayerBox.Name = "blackPlayerBox";
            this.blackPlayerBox.Size = new System.Drawing.Size(51, 51);
            this.blackPlayerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackPlayerBox.TabIndex = 1;
            this.blackPlayerBox.TabStop = false;
            // 
            // whitePlayerBox
            // 
            this.whitePlayerBox.BackColor = System.Drawing.Color.White;
            this.whitePlayerBox.Image = global::Assignment1TMoore.Properties.Resources._1;
            this.whitePlayerBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("whitePlayerBox.InitialImage")));
            this.whitePlayerBox.Location = new System.Drawing.Point(109, 37);
            this.whitePlayerBox.Name = "whitePlayerBox";
            this.whitePlayerBox.Size = new System.Drawing.Size(51, 51);
            this.whitePlayerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.whitePlayerBox.TabIndex = 0;
            this.whitePlayerBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuItem,
            this.settingsMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(822, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameMenuItem
            // 
            this.gameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.saveGameMenuItem,
            this.restoreGameMenuItem,
            this.exitMenuItem});
            this.gameMenuItem.Name = "gameMenuItem";
            this.gameMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameMenuItem.Text = "Game";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(185, 26);
            this.newMenuItem.Text = "New";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // saveGameMenuItem
            // 
            this.saveGameMenuItem.Name = "saveGameMenuItem";
            this.saveGameMenuItem.Size = new System.Drawing.Size(185, 26);
            this.saveGameMenuItem.Text = "Save Game";
            this.saveGameMenuItem.Click += new System.EventHandler(this.saveGameMenuItem_Click);
            // 
            // restoreGameMenuItem
            // 
            this.restoreGameMenuItem.Name = "restoreGameMenuItem";
            this.restoreGameMenuItem.Size = new System.Drawing.Size(185, 26);
            this.restoreGameMenuItem.Text = "Restore Game";
            this.restoreGameMenuItem.Click += new System.EventHandler(this.restoreGameMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(185, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speakMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsMenuItem.Text = "Settings";
            // 
            // speakMenuItem
            // 
            this.speakMenuItem.CheckOnClick = true;
            this.speakMenuItem.Name = "speakMenuItem";
            this.speakMenuItem.Size = new System.Drawing.Size(132, 26);
            this.speakMenuItem.Text = "Speak";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // othelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(822, 865);
            this.Controls.Add(this.pinkPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "othelloForm";
            this.Text = "Oneillio v 1.0";
            this.pinkPanel.ResumeLayout(false);
            this.pinkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackToPlayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteToPlayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePlayerBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pinkPanel;
        private System.Windows.Forms.PictureBox blackPlayerBox;
        private System.Windows.Forms.PictureBox whitePlayerBox;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label whiteLabel;
        private System.Windows.Forms.TextBox blackTextBox;
        private System.Windows.Forms.TextBox whiteTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.PictureBox whiteToPlayImage;
        private System.Windows.Forms.PictureBox blackToPlayImage;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

