namespace LinkedContacts
{
    partial class AppSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettings));
            this.GBSettings = new System.Windows.Forms.GroupBox();
            this.ckbOAuth = new System.Windows.Forms.CheckBox();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.ckbShowLinked = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.ckbLogging = new System.Windows.Forms.CheckBox();
            this.btnLoggingLocation = new System.Windows.Forms.Button();
            this.ckbDirectConnection = new System.Windows.Forms.CheckBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUPN = new System.Windows.Forms.TextBox();
            this.lblUPN = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.gbAppRegistration = new System.Windows.Forms.GroupBox();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.tbTenant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GBSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAppRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSettings
            // 
            this.GBSettings.Controls.Add(this.gbAppRegistration);
            this.GBSettings.Controls.Add(this.ckbOAuth);
            this.GBSettings.Controls.Add(this.btnResetSettings);
            this.GBSettings.Controls.Add(this.ckbShowLinked);
            this.GBSettings.Controls.Add(this.groupBox1);
            this.GBSettings.Controls.Add(this.ckbDirectConnection);
            this.GBSettings.Controls.Add(this.btSave);
            this.GBSettings.Controls.Add(this.tbPassword);
            this.GBSettings.Controls.Add(this.tbEmail);
            this.GBSettings.Controls.Add(this.tbUPN);
            this.GBSettings.Controls.Add(this.lblUPN);
            this.GBSettings.Controls.Add(this.lblPassword);
            this.GBSettings.Controls.Add(this.lblEmail);
            this.GBSettings.Location = new System.Drawing.Point(12, 12);
            this.GBSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSettings.Name = "GBSettings";
            this.GBSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSettings.Size = new System.Drawing.Size(564, 627);
            this.GBSettings.TabIndex = 0;
            this.GBSettings.TabStop = false;
            // 
            // ckbOAuth
            // 
            this.ckbOAuth.AutoSize = true;
            this.ckbOAuth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOAuth.Location = new System.Drawing.Point(16, 257);
            this.ckbOAuth.Name = "ckbOAuth";
            this.ckbOAuth.Size = new System.Drawing.Size(125, 21);
            this.ckbOAuth.TabIndex = 14;
            this.ckbOAuth.Text = "Use OAuth 2.0";
            this.ckbOAuth.UseVisualStyleBackColor = true;
            this.ckbOAuth.CheckedChanged += new System.EventHandler(this.ckbOAuth_CheckedChanged);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.AutoSize = true;
            this.btnResetSettings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSettings.Location = new System.Drawing.Point(16, 540);
            this.btnResetSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(152, 33);
            this.btnResetSettings.TabIndex = 13;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // ckbShowLinked
            // 
            this.ckbShowLinked.AutoSize = true;
            this.ckbShowLinked.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowLinked.Location = new System.Drawing.Point(16, 222);
            this.ckbShowLinked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbShowLinked.Name = "ckbShowLinked";
            this.ckbShowLinked.Size = new System.Drawing.Size(198, 21);
            this.ckbShowLinked.TabIndex = 12;
            this.ckbShowLinked.Text = "Show linked contacts only";
            this.ckbShowLinked.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLocation);
            this.groupBox1.Controls.Add(this.ckbLogging);
            this.groupBox1.Controls.Add(this.btnLoggingLocation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 416);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(529, 112);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logging";
            // 
            // tbLocation
            // 
            this.tbLocation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(116, 63);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(407, 25);
            this.tbLocation.TabIndex = 10;
            // 
            // ckbLogging
            // 
            this.ckbLogging.AutoSize = true;
            this.ckbLogging.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLogging.Location = new System.Drawing.Point(13, 30);
            this.ckbLogging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbLogging.Name = "ckbLogging";
            this.ckbLogging.Size = new System.Drawing.Size(83, 21);
            this.ckbLogging.TabIndex = 8;
            this.ckbLogging.Text = "Enabled";
            this.ckbLogging.UseVisualStyleBackColor = true;
            // 
            // btnLoggingLocation
            // 
            this.btnLoggingLocation.AutoSize = true;
            this.btnLoggingLocation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggingLocation.Location = new System.Drawing.Point(12, 59);
            this.btnLoggingLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoggingLocation.Name = "btnLoggingLocation";
            this.btnLoggingLocation.Size = new System.Drawing.Size(97, 33);
            this.btnLoggingLocation.TabIndex = 9;
            this.btnLoggingLocation.Text = "Location";
            this.btnLoggingLocation.UseVisualStyleBackColor = true;
            this.btnLoggingLocation.Click += new System.EventHandler(this.btnLoggingLocation_Click);
            // 
            // ckbDirectConnection
            // 
            this.ckbDirectConnection.AutoSize = true;
            this.ckbDirectConnection.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDirectConnection.Location = new System.Drawing.Point(16, 189);
            this.ckbDirectConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbDirectConnection.Name = "ckbDirectConnection";
            this.ckbDirectConnection.Size = new System.Drawing.Size(200, 21);
            this.ckbDirectConnection.TabIndex = 7;
            this.ckbDirectConnection.Text = "Direct connection to O365";
            this.ckbDirectConnection.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.AutoSize = true;
            this.btSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(275, 583);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 33);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(179, 130);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(285, 25);
            this.tbPassword.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(179, 89);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(285, 25);
            this.tbEmail.TabIndex = 4;
            // 
            // tbUPN
            // 
            this.tbUPN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUPN.Location = new System.Drawing.Point(179, 46);
            this.tbUPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUPN.Name = "tbUPN";
            this.tbUPN.Size = new System.Drawing.Size(285, 25);
            this.tbUPN.TabIndex = 3;
            // 
            // lblUPN
            // 
            this.lblUPN.AutoSize = true;
            this.lblUPN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUPN.Location = new System.Drawing.Point(13, 50);
            this.lblUPN.Name = "lblUPN";
            this.lblUPN.Size = new System.Drawing.Size(142, 17);
            this.lblUPN.TabIndex = 2;
            this.lblUPN.Text = "User Principal Name";
            this.lblUPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(85, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(51, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail address";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "\"Select the location to save the logs\"";
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // gbAppRegistration
            // 
            this.gbAppRegistration.Controls.Add(this.label2);
            this.gbAppRegistration.Controls.Add(this.label1);
            this.gbAppRegistration.Controls.Add(this.tbTenant);
            this.gbAppRegistration.Controls.Add(this.tbClientId);
            this.gbAppRegistration.Enabled = false;
            this.gbAppRegistration.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAppRegistration.Location = new System.Drawing.Point(16, 289);
            this.gbAppRegistration.Name = "gbAppRegistration";
            this.gbAppRegistration.Size = new System.Drawing.Size(529, 120);
            this.gbAppRegistration.TabIndex = 15;
            this.gbAppRegistration.TabStop = false;
            this.gbAppRegistration.Text = "App Registration";
            // 
            // tbClientId
            // 
            this.tbClientId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientId.Location = new System.Drawing.Point(93, 37);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(392, 25);
            this.tbClientId.TabIndex = 0;
            // 
            // tbTenant
            // 
            this.tbTenant.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenant.Location = new System.Drawing.Point(93, 82);
            this.tbTenant.Name = "tbTenant";
            this.tbTenant.Size = new System.Drawing.Size(392, 25);
            this.tbTenant.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ClientId ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tenant";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 650);
            this.Controls.Add(this.GBSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.GBSettings.ResumeLayout(false);
            this.GBSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAppRegistration.ResumeLayout(false);
            this.gbAppRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBSettings;
        private System.Windows.Forms.Label lblUPN;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoggingLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        public System.Windows.Forms.TextBox tbPassword;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.TextBox tbUPN;
        public System.Windows.Forms.CheckBox ckbLogging;
        public System.Windows.Forms.CheckBox ckbDirectConnection;
        public System.Windows.Forms.TextBox tbLocation;
        public System.Windows.Forms.CheckBox ckbShowLinked;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.CheckBox ckbOAuth;
        private System.Windows.Forms.GroupBox gbAppRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenant;
        private System.Windows.Forms.TextBox tbClientId;
    }
}