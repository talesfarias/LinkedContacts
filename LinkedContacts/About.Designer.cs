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
            this.linkLabelGit = new System.Windows.Forms.LinkLabel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.GBAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // GBAbout
            // 
            this.GBAbout.Controls.Add(this.linkLabelGit);
            this.GBAbout.Controls.Add(this.lblAbout);
            this.GBAbout.Controls.Add(this.picAbout);
            this.GBAbout.Location = new System.Drawing.Point(12, 12);
            this.GBAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBAbout.Name = "GBAbout";
            this.GBAbout.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBAbout.Size = new System.Drawing.Size(375, 363);
            this.GBAbout.TabIndex = 0;
            this.GBAbout.TabStop = false;
            // 
            // linkLabelGit
            // 
            this.linkLabelGit.AutoSize = true;
            this.linkLabelGit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGit.Location = new System.Drawing.Point(73, 316);
            this.linkLabelGit.Name = "linkLabelGit";
            this.linkLabelGit.Size = new System.Drawing.Size(237, 20);
            this.linkLabelGit.TabIndex = 3;
            this.linkLabelGit.TabStop = true;
            this.linkLabelGit.Text = "More about this project on GitHub";
            this.linkLabelGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGit_LinkClicked);
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(5, 219);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(364, 97);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = "This tool helps you to identify Linked Contacts for a given Exchange mailbox.\r\n\r\n" +
    "Version 0.1.0";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picAbout
            // 
            this.picAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAbout.Image = ((System.Drawing.Image)(resources.GetObject("picAbout.Image")));
            this.picAbout.Location = new System.Drawing.Point(106, 43);
            this.picAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(169, 160);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAbout.TabIndex = 1;
            this.picAbout.TabStop = false;
            // 
            // About
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 386);
            this.Controls.Add(this.GBAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.About_Load);
            this.GBAbout.ResumeLayout(false);
            this.GBAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBAbout;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.LinkLabel linkLabelGit;
        private System.Windows.Forms.Label lblAbout;
    }
}