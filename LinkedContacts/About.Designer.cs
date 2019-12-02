namespace LinkedContacts
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
            this.GBAbout = new System.Windows.Forms.GroupBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.GBAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // GBAbout
            // 
            this.GBAbout.Controls.Add(this.lblAbout);
            this.GBAbout.Controls.Add(this.picAbout);
            this.GBAbout.Location = new System.Drawing.Point(9, 10);
            this.GBAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBAbout.Name = "GBAbout";
            this.GBAbout.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBAbout.Size = new System.Drawing.Size(261, 259);
            this.GBAbout.TabIndex = 0;
            this.GBAbout.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(4, 178);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(252, 79);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = "Utility to unlink contacts on Exchange Online mailboxes.\r\n\r\nVersion 1.0 \r\n(Develo" +
    "ped by Tales Farias)";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picAbout
            // 
            this.picAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAbout.Image = ((System.Drawing.Image)(resources.GetObject("picAbout.Image")));
            this.picAbout.Location = new System.Drawing.Point(70, 17);
            this.picAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(132, 142);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAbout.TabIndex = 1;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // About
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 279);
            this.Controls.Add(this.GBAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            this.GBAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBAbout;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.Label lblAbout;
    }
}