
namespace Assignment1TMooreAboutWindow
{
    partial class aboutWindow
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
            this.helpOKButton = new System.Windows.Forms.Button();
            this.greyBackgroundPanel = new System.Windows.Forms.Panel();
            this.descLabel2 = new System.Windows.Forms.Label();
            this.descLabel1 = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.helpBox = new System.Windows.Forms.PictureBox();
            this.greyBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // helpOKButton
            // 
            this.helpOKButton.Location = new System.Drawing.Point(331, 385);
            this.helpOKButton.Name = "helpOKButton";
            this.helpOKButton.Size = new System.Drawing.Size(135, 53);
            this.helpOKButton.TabIndex = 0;
            this.helpOKButton.Text = "OK";
            this.helpOKButton.UseVisualStyleBackColor = true;
            this.helpOKButton.Click += new System.EventHandler(this.helpOKButton_Click);
            // 
            // greyBackgroundPanel
            // 
            this.greyBackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greyBackgroundPanel.Controls.Add(this.descLabel2);
            this.greyBackgroundPanel.Controls.Add(this.descLabel1);
            this.greyBackgroundPanel.Controls.Add(this.titleLabel2);
            this.greyBackgroundPanel.Controls.Add(this.titleLabel1);
            this.greyBackgroundPanel.Controls.Add(this.helpBox);
            this.greyBackgroundPanel.Location = new System.Drawing.Point(12, 12);
            this.greyBackgroundPanel.Name = "greyBackgroundPanel";
            this.greyBackgroundPanel.Size = new System.Drawing.Size(776, 367);
            this.greyBackgroundPanel.TabIndex = 1;
            // 
            // descLabel2
            // 
            this.descLabel2.Location = new System.Drawing.Point(377, 210);
            this.descLabel2.Name = "descLabel2";
            this.descLabel2.Size = new System.Drawing.Size(389, 113);
            this.descLabel2.TabIndex = 4;
            this.descLabel2.Text = "This \"ONeillo v1.0\" application uses most, if not all of the techniques explained" +
    " and demonstrated throughout the year. (The GUIImageArray used within the applic" +
    "ation was provided to the Students.";
            // 
            // descLabel1
            // 
            this.descLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descLabel1.Location = new System.Drawing.Point(377, 154);
            this.descLabel1.Name = "descLabel1";
            this.descLabel1.Size = new System.Drawing.Size(392, 209);
            this.descLabel1.TabIndex = 3;
            this.descLabel1.Text = "The \"ONeillo v1.0\" application was developed by Dr Peter O\'Neill of Sheffield Hal" +
    "lam University, for his level 4 Students on the module, \"Programming for Computi" +
    "ng.\" ";
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.Location = new System.Drawing.Point(496, 74);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(128, 55);
            this.titleLabel2.TabIndex = 2;
            this.titleLabel2.Text = "v 1.0";
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(479, 19);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(180, 55);
            this.titleLabel1.TabIndex = 1;
            this.titleLabel1.Text = "ONeillo";
            // 
            // helpBox
            // 
            this.helpBox.BackColor = System.Drawing.SystemColors.Control;
            this.helpBox.Location = new System.Drawing.Point(3, 3);
            this.helpBox.Name = "helpBox";
            this.helpBox.Size = new System.Drawing.Size(372, 360);
            this.helpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helpBox.TabIndex = 0;
            this.helpBox.TabStop = false;
            // 
            // aboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greyBackgroundPanel);
            this.Controls.Add(this.helpOKButton);
            this.Name = "aboutWindow";
            this.Text = "About";
            this.greyBackgroundPanel.ResumeLayout(false);
            this.greyBackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helpOKButton;
        private System.Windows.Forms.Panel greyBackgroundPanel;
        private System.Windows.Forms.PictureBox helpBox;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label descLabel2;
        private System.Windows.Forms.Label descLabel1;
    }
}

