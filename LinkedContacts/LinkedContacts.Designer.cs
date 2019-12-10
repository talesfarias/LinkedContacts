namespace LinkedContacts
{
    partial class LinkedContacts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkedContacts));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFetchResults = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClearResults = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnectedTo = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvContacts = new System.Windows.Forms.ListView();
            this.chDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSMTP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLinked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGalLinked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblError = new System.Windows.Forms.Label();
            this.tvContacts = new System.Windows.Forms.TreeView();
            this.ilPicsList = new System.Windows.Forms.ImageList(this.components);
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.pUserInformation = new System.Windows.Forms.Panel();
            this.btnExpandNodes = new System.Windows.Forms.Button();
            this.lblTotalResults = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.tcPages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chContactId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.mainMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).BeginInit();
            this.pUserInformation.SuspendLayout();
            this.tcPages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.MenuOptions});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1261, 31);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFetchResults,
            this.MenuClearResults,
            this.MenuExit});
            this.actionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(78, 27);
            this.actionsToolStripMenuItem.Text = "Actions";
            this.actionsToolStripMenuItem.Click += new System.EventHandler(this.actionsToolStripMenuItem_Click);
            // 
            // MenuFetchResults
            // 
            this.MenuFetchResults.Name = "MenuFetchResults";
            this.MenuFetchResults.Size = new System.Drawing.Size(185, 28);
            this.MenuFetchResults.Text = "Fetch Results";
            this.MenuFetchResults.Click += new System.EventHandler(this.MenuFetchResults_Click);
            // 
            // MenuClearResults
            // 
            this.MenuClearResults.Name = "MenuClearResults";
            this.MenuClearResults.Size = new System.Drawing.Size(185, 28);
            this.MenuClearResults.Text = "Clear Results";
            this.MenuClearResults.Click += new System.EventHandler(this.MenuClearResults_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(185, 28);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuOptions
            // 
            this.MenuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettings,
            this.MenuAbout});
            this.MenuOptions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(82, 27);
            this.MenuOptions.Text = "Options";
            // 
            // MenuSettings
            // 
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(147, 28);
            this.MenuSettings.Text = "Settings";
            this.MenuSettings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(147, 28);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = false;
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblConnection,
            this.lblConnectedTo});
            this.StatusBar.Location = new System.Drawing.Point(0, 939);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.StatusBar.Size = new System.Drawing.Size(1261, 38);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "StatusBar";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 33);
            this.lblStatus.Text = "Status:";
            // 
            // lblConnection
            // 
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.Red;
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(138, 33);
            this.lblConnection.Text = "Nothing to show";
            // 
            // lblConnectedTo
            // 
            this.lblConnectedTo.Name = "lblConnectedTo";
            this.lblConnectedTo.Size = new System.Drawing.Size(0, 33);
            // 
            // errorMessage
            // 
            this.errorMessage.ContainerControl = this;
            // 
            // lvContacts
            // 
            this.lvContacts.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDisplayName,
            this.chSMTP,
            this.chPhone,
            this.chLinked,
            this.chGalLinked,
            this.chContactId});
            this.lvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvContacts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvContacts.ForeColor = System.Drawing.Color.Black;
            this.lvContacts.FullRowSelect = true;
            this.lvContacts.GridLines = true;
            this.lvContacts.HideSelection = false;
            this.errorMessage.SetIconAlignment(this.lvContacts, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.lvContacts.Location = new System.Drawing.Point(3, 3);
            this.lvContacts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvContacts.Name = "lvContacts";
            this.lvContacts.Size = new System.Drawing.Size(1247, 831);
            this.lvContacts.TabIndex = 3;
            this.lvContacts.TileSize = new System.Drawing.Size(10, 10);
            this.lvContacts.UseCompatibleStateImageBehavior = false;
            this.lvContacts.View = System.Windows.Forms.View.Details;
            this.lvContacts.Visible = false;
            // 
            // chDisplayName
            // 
            this.chDisplayName.Text = "Display Name";
            this.chDisplayName.Width = 250;
            // 
            // chSMTP
            // 
            this.chSMTP.Text = "Email Address";
            this.chSMTP.Width = 280;
            // 
            // chPhone
            // 
            this.chPhone.Text = "Business Phone";
            this.chPhone.Width = 140;
            // 
            // chLinked
            // 
            this.chLinked.Text = "Linked";
            this.chLinked.Width = 0;
            // 
            // chGalLinked
            // 
            this.chGalLinked.Text = "Linked to GAL";
            this.chGalLinked.Width = 140;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.SetIconAlignment(this.lblError, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblError.Location = new System.Drawing.Point(1244, 2);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(13, 27);
            this.lblError.TabIndex = 4;
            this.lblError.Text = " ";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tvContacts
            // 
            this.tvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvContacts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.SetIconAlignment(this.tvContacts, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.tvContacts.ImageKey = "user.png";
            this.tvContacts.ImageList = this.ilPicsList;
            this.tvContacts.Location = new System.Drawing.Point(3, 3);
            this.tvContacts.Name = "tvContacts";
            this.tvContacts.SelectedImageIndex = 0;
            this.tvContacts.Size = new System.Drawing.Size(1247, 831);
            this.tvContacts.TabIndex = 6;
            this.tvContacts.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvContacts_AfterCheck);
            // 
            // ilPicsList
            // 
            this.ilPicsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPicsList.ImageStream")));
            this.ilPicsList.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPicsList.Images.SetKeyName(0, "user.png");
            this.ilPicsList.Images.SetKeyName(1, "user_color.png");
            this.ilPicsList.Images.SetKeyName(2, "link.png");
            this.ilPicsList.Images.SetKeyName(3, "link24x24.png");
            // 
            // pUserInformation
            // 
            this.pUserInformation.AutoSize = true;
            this.pUserInformation.Controls.Add(this.btnExpandNodes);
            this.pUserInformation.Controls.Add(this.lblTotalResults);
            this.pUserInformation.Controls.Add(this.lblError);
            this.pUserInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pUserInformation.Location = new System.Drawing.Point(0, 904);
            this.pUserInformation.Margin = new System.Windows.Forms.Padding(4);
            this.pUserInformation.Name = "pUserInformation";
            this.pUserInformation.Size = new System.Drawing.Size(1261, 35);
            this.pUserInformation.TabIndex = 5;
            // 
            // btnExpandNodes
            // 
            this.btnExpandNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandNodes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandNodes.Location = new System.Drawing.Point(1055, 4);
            this.btnExpandNodes.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpandNodes.Name = "btnExpandNodes";
            this.btnExpandNodes.Size = new System.Drawing.Size(200, 28);
            this.btnExpandNodes.TabIndex = 6;
            this.btnExpandNodes.Text = "Expand all";
            this.btnExpandNodes.Visible = false;
            this.btnExpandNodes.Click += new System.EventHandler(this.btnExpandNodes_Click);
            // 
            // lblTotalResults
            // 
            this.lblTotalResults.AutoSize = true;
            this.lblTotalResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResults.Location = new System.Drawing.Point(4, 11);
            this.lblTotalResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalResults.Name = "lblTotalResults";
            this.lblTotalResults.Size = new System.Drawing.Size(0, 20);
            this.lblTotalResults.TabIndex = 5;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(983, 946);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(76, 20);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "Progress:";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProgress.Visible = false;
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoading.Location = new System.Drawing.Point(1067, 946);
            this.pbLoading.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(187, 20);
            this.pbLoading.TabIndex = 3;
            this.pbLoading.Visible = false;
            // 
            // tcPages
            // 
            this.tcPages.Controls.Add(this.tabPage1);
            this.tcPages.Controls.Add(this.tabPage2);
            this.tcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPages.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPages.Location = new System.Drawing.Point(0, 31);
            this.tcPages.Name = "tcPages";
            this.tcPages.SelectedIndex = 0;
            this.tcPages.Size = new System.Drawing.Size(1261, 873);
            this.tcPages.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcPages.TabIndex = 7;
            this.tcPages.Tag = "";
            this.tcPages.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcPages_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvContacts);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1253, 837);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "Table";
            this.tabPage1.Text = "All Contacts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tvContacts);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1253, 837);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "Tree";
            this.tabPage2.Text = "Linked Contacts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chContactId
            // 
            this.chContactId.Text = "ContactID";
            this.chContactId.Width = 0;
            // 
            // LinkedContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1261, 977);
            this.Controls.Add(this.tcPages);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pUserInformation);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(918, 783);
            this.Name = "LinkedContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkedContacts";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).EndInit();
            this.pUserInformation.ResumeLayout(false);
            this.pUserInformation.PerformLayout();
            this.tcPages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuOptions;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblConnection;
        private System.Windows.Forms.ErrorProvider errorMessage;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectedTo;
        private System.Windows.Forms.ListView lvContacts;
        private System.Windows.Forms.ColumnHeader chDisplayName;
        private System.Windows.Forms.ColumnHeader chSMTP;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ColumnHeader chLinked;
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.Panel pUserInformation;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblTotalResults;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFetchResults;
        private System.Windows.Forms.ToolStripMenuItem MenuClearResults;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.Button btnExpandNodes;
        private System.Windows.Forms.ColumnHeader chGalLinked;
        private System.Windows.Forms.TreeView tvContacts;
        private System.Windows.Forms.TabControl tcPages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList ilPicsList;
        private System.Windows.Forms.ColumnHeader chContactId;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

