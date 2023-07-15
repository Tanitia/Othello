
namespace Assignment1TMoore
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.aboutPic = new System.Windows.Forms.PictureBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.abouttextBox = new System.Windows.Forms.TextBox();
            this.aboutOkayButton = new System.Windows.Forms.Button();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPic)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutPanel
            // 
            this.aboutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aboutPanel.Controls.Add(this.aboutOkayButton);
            this.aboutPanel.Controls.Add(this.abouttextBox);
            this.aboutPanel.Controls.Add(this.helpLabel);
            this.aboutPanel.Controls.Add(this.aboutPic);
            this.aboutPanel.Location = new System.Drawing.Point(12, 12);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(776, 426);
            this.aboutPanel.TabIndex = 0;
            // 
            // aboutPic
            // 
            this.aboutPic.Image = global::Assignment1TMoore.Properties.Resources.aboutScreenshot;
            this.aboutPic.Location = new System.Drawing.Point(-2, -2);
            this.aboutPic.Name = "aboutPic";
            this.aboutPic.Size = new System.Drawing.Size(383, 352);
            this.aboutPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutPic.TabIndex = 0;
            this.aboutPic.TabStop = false;
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.Location = new System.Drawing.Point(473, 17);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(232, 138);
            this.helpLabel.TabIndex = 1;
            this.helpLabel.Text = "ONeillo\r\n  v 1.0\r\n";
            // 
            // abouttextBox
            // 
            this.abouttextBox.Location = new System.Drawing.Point(406, 176);
            this.abouttextBox.Multiline = true;
            this.abouttextBox.Name = "abouttextBox";
            this.abouttextBox.Size = new System.Drawing.Size(351, 174);
            this.abouttextBox.TabIndex = 2;
            this.abouttextBox.Text = resources.GetString("abouttextBox.Text");
            // 
            // aboutOkayButton
            // 
            this.aboutOkayButton.Location = new System.Drawing.Point(330, 372);
            this.aboutOkayButton.Name = "aboutOkayButton";
            this.aboutOkayButton.Size = new System.Drawing.Size(123, 47);
            this.aboutOkayButton.TabIndex = 3;
            this.aboutOkayButton.Text = "Okay";
            this.aboutOkayButton.UseVisualStyleBackColor = true;
            this.aboutOkayButton.Click += new System.EventHandler(this.aboutOkayButton_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aboutPanel);
            this.Name = "About";
            this.Text = "About";
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.PictureBox aboutPic;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.TextBox abouttextBox;
        private System.Windows.Forms.Button aboutOkayButton;
    }
}