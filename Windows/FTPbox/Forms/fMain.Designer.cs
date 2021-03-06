﻿namespace FTPbox.Forms
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.gLanguage = new System.Windows.Forms.GroupBox();
            this.bTranslate = new System.Windows.Forms.Button();
            this.cLanguages = new System.Windows.Forms.ComboBox();
            this.gLinks = new System.Windows.Forms.GroupBox();
            this.rOpenLocal = new System.Windows.Forms.RadioButton();
            this.labLinkClicked = new System.Windows.Forms.Label();
            this.rCopy2Clipboard = new System.Windows.Forms.RadioButton();
            this.rOpenInBrowser = new System.Windows.Forms.RadioButton();
            this.gApp = new System.Windows.Forms.GroupBox();
            this.bBrowseLogs = new System.Windows.Forms.Button();
            this.chkEnableLogging = new System.Windows.Forms.CheckBox();
            this.chkShowNots = new System.Windows.Forms.CheckBox();
            this.chkStartUp = new System.Windows.Forms.CheckBox();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.gWebInt = new System.Windows.Forms.GroupBox();
            this.labViewInBrowser = new System.Windows.Forms.LinkLabel();
            this.chkWebInt = new System.Windows.Forms.CheckBox();
            this.bRemoveAccount = new System.Windows.Forms.Button();
            this.bAddAccount = new System.Windows.Forms.Button();
            this.cProfiles = new System.Windows.Forms.ComboBox();
            this.lProfile = new System.Windows.Forms.Label();
            this.gAccount = new System.Windows.Forms.GroupBox();
            this.lMode = new System.Windows.Forms.Label();
            this.labMode = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.lHost = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.labPort = new System.Windows.Forms.Label();
            this.labUN = new System.Windows.Forms.Label();
            this.labHost = new System.Windows.Forms.Label();
            this.gDetails = new System.Windows.Forms.GroupBox();
            this.tParent = new System.Windows.Forms.TextBox();
            this.labFullPath = new System.Windows.Forms.Label();
            this.lLocPath = new System.Windows.Forms.Label();
            this.lRemPath = new System.Windows.Forms.Label();
            this.labLocPath = new System.Windows.Forms.Label();
            this.labRemPath = new System.Windows.Forms.Label();
            this.tabFilters = new System.Windows.Forms.TabPage();
            this.gFileFilters = new System.Windows.Forms.GroupBox();
            this.bConfigureSelectiveSync = new System.Windows.Forms.Button();
            this.bConfigureExtensions = new System.Windows.Forms.Button();
            this.labSelectiveSync = new System.Windows.Forms.Label();
            this.labAlsoIgnore = new System.Windows.Forms.Label();
            this.cIgnoreOldFiles = new System.Windows.Forms.CheckBox();
            this.dtpLastModTime = new System.Windows.Forms.DateTimePicker();
            this.labSelectExtensions = new System.Windows.Forms.Label();
            this.cIgnoreTempFiles = new System.Windows.Forms.CheckBox();
            this.cIgnoreDotfiles = new System.Windows.Forms.CheckBox();
            this.tabBandwidth = new System.Windows.Forms.TabPage();
            this.gSyncing = new System.Windows.Forms.GroupBox();
            this.labSeconds = new System.Windows.Forms.Label();
            this.labSyncWhen = new System.Windows.Forms.Label();
            this.nSyncFrequency = new System.Windows.Forms.NumericUpDown();
            this.cAuto = new System.Windows.Forms.RadioButton();
            this.cManually = new System.Windows.Forms.RadioButton();
            this.gLimits = new System.Windows.Forms.GroupBox();
            this.labNoLimits = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUpLimit = new System.Windows.Forms.NumericUpDown();
            this.nDownLimit = new System.Windows.Forms.NumericUpDown();
            this.labUpSpeed = new System.Windows.Forms.Label();
            this.labDownSpeed = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.labSupportMail = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lVersion = new System.Windows.Forms.Label();
            this.labLangUsed = new System.Windows.Forms.Label();
            this.labContact = new System.Windows.Forms.Label();
            this.labSite = new System.Windows.Forms.Label();
            this.labTeam = new System.Windows.Forms.Label();
            this.labCurVersion = new System.Windows.Forms.Label();
            this.gContribute = new System.Windows.Forms.GroupBox();
            this.labDonate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gNotes = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labContactMe = new System.Windows.Forms.Label();
            this.labFree = new System.Windows.Forms.Label();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gLanguage.SuspendLayout();
            this.gLinks.SuspendLayout();
            this.gApp.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.gWebInt.SuspendLayout();
            this.gAccount.SuspendLayout();
            this.gDetails.SuspendLayout();
            this.tabFilters.SuspendLayout();
            this.gFileFilters.SuspendLayout();
            this.tabBandwidth.SuspendLayout();
            this.gSyncing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSyncFrequency)).BeginInit();
            this.gLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDownLimit)).BeginInit();
            this.tabAbout.SuspendLayout();
            this.gContribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gNotes.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Controls.Add(this.tabFilters);
            this.tabControl1.Controls.Add(this.tabBandwidth);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 392);
            this.tabControl1.TabIndex = 12;
            // 
            // tabGeneral
            // 
            this.tabGeneral.AccessibleDescription = "";
            this.tabGeneral.Controls.Add(this.gLanguage);
            this.tabGeneral.Controls.Add(this.gLinks);
            this.tabGeneral.Controls.Add(this.gApp);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(464, 366);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // gLanguage
            // 
            this.gLanguage.Controls.Add(this.bTranslate);
            this.gLanguage.Controls.Add(this.cLanguages);
            this.gLanguage.Location = new System.Drawing.Point(8, 221);
            this.gLanguage.Name = "gLanguage";
            this.gLanguage.Size = new System.Drawing.Size(449, 54);
            this.gLanguage.TabIndex = 13;
            this.gLanguage.TabStop = false;
            this.gLanguage.Text = "Language";
            // 
            // bTranslate
            // 
            this.bTranslate.Location = new System.Drawing.Point(191, 17);
            this.bTranslate.Name = "bTranslate";
            this.bTranslate.Size = new System.Drawing.Size(89, 23);
            this.bTranslate.TabIndex = 11;
            this.bTranslate.Text = "Translate";
            this.bTranslate.UseVisualStyleBackColor = true;
            this.bTranslate.Click += new System.EventHandler(this.bTranslate_Click);
            // 
            // cLanguages
            // 
            this.cLanguages.AccessibleDescription = "";
            this.cLanguages.AccessibleName = "Encryption";
            this.cLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLanguages.FormattingEnabled = true;
            this.cLanguages.Items.AddRange(new object[] {
            "None",
            "require explicit FTP over TLS",
            "require implicit FTP over TLS"});
            this.cLanguages.Location = new System.Drawing.Point(9, 19);
            this.cLanguages.Name = "cLanguages";
            this.cLanguages.Size = new System.Drawing.Size(176, 21);
            this.cLanguages.TabIndex = 1;
            // 
            // gLinks
            // 
            this.gLinks.AccessibleDescription = "";
            this.gLinks.Controls.Add(this.rOpenLocal);
            this.gLinks.Controls.Add(this.labLinkClicked);
            this.gLinks.Controls.Add(this.rCopy2Clipboard);
            this.gLinks.Controls.Add(this.rOpenInBrowser);
            this.gLinks.Location = new System.Drawing.Point(8, 6);
            this.gLinks.Name = "gLinks";
            this.gLinks.Size = new System.Drawing.Size(449, 111);
            this.gLinks.TabIndex = 12;
            this.gLinks.TabStop = false;
            this.gLinks.Text = "Links";
            // 
            // rOpenLocal
            // 
            this.rOpenLocal.AccessibleDescription = "";
            this.rOpenLocal.AccessibleName = "open the local file";
            this.rOpenLocal.Location = new System.Drawing.Point(22, 86);
            this.rOpenLocal.Name = "rOpenLocal";
            this.rOpenLocal.Size = new System.Drawing.Size(408, 17);
            this.rOpenLocal.TabIndex = 3;
            this.rOpenLocal.Text = "open the local file";
            this.rOpenLocal.UseVisualStyleBackColor = true;
            this.rOpenLocal.CheckedChanged += new System.EventHandler(this.rOpenLocal_CheckedChanged);
            // 
            // labLinkClicked
            // 
            this.labLinkClicked.AccessibleDescription = "";
            this.labLinkClicked.Location = new System.Drawing.Point(9, 19);
            this.labLinkClicked.Name = "labLinkClicked";
            this.labLinkClicked.Size = new System.Drawing.Size(437, 13);
            this.labLinkClicked.TabIndex = 18;
            this.labLinkClicked.Text = "When tray notification or recent file is clicked:";
            // 
            // rCopy2Clipboard
            // 
            this.rCopy2Clipboard.AccessibleDescription = "";
            this.rCopy2Clipboard.AccessibleName = "copy link to clipboard";
            this.rCopy2Clipboard.Location = new System.Drawing.Point(22, 63);
            this.rCopy2Clipboard.Name = "rCopy2Clipboard";
            this.rCopy2Clipboard.Size = new System.Drawing.Size(408, 17);
            this.rCopy2Clipboard.TabIndex = 2;
            this.rCopy2Clipboard.Text = "copy link to clipboard";
            this.rCopy2Clipboard.UseVisualStyleBackColor = true;
            this.rCopy2Clipboard.CheckedChanged += new System.EventHandler(this.rCopy2Clipboard_CheckedChanged);
            // 
            // rOpenInBrowser
            // 
            this.rOpenInBrowser.AccessibleDescription = "";
            this.rOpenInBrowser.AccessibleName = "open link in default browser";
            this.rOpenInBrowser.Checked = true;
            this.rOpenInBrowser.Location = new System.Drawing.Point(22, 40);
            this.rOpenInBrowser.Name = "rOpenInBrowser";
            this.rOpenInBrowser.Size = new System.Drawing.Size(408, 17);
            this.rOpenInBrowser.TabIndex = 1;
            this.rOpenInBrowser.TabStop = true;
            this.rOpenInBrowser.Text = "Open link in default browser";
            this.rOpenInBrowser.UseVisualStyleBackColor = true;
            this.rOpenInBrowser.CheckedChanged += new System.EventHandler(this.rOpenInBrowser_CheckedChanged);
            // 
            // gApp
            // 
            this.gApp.AccessibleDescription = "";
            this.gApp.Controls.Add(this.bBrowseLogs);
            this.gApp.Controls.Add(this.chkEnableLogging);
            this.gApp.Controls.Add(this.chkShowNots);
            this.gApp.Controls.Add(this.chkStartUp);
            this.gApp.Location = new System.Drawing.Point(8, 123);
            this.gApp.Name = "gApp";
            this.gApp.Size = new System.Drawing.Size(449, 92);
            this.gApp.TabIndex = 3;
            this.gApp.TabStop = false;
            this.gApp.Text = "Application";
            // 
            // bBrowseLogs
            // 
            this.bBrowseLogs.Location = new System.Drawing.Point(191, 61);
            this.bBrowseLogs.Name = "bBrowseLogs";
            this.bBrowseLogs.Size = new System.Drawing.Size(89, 23);
            this.bBrowseLogs.TabIndex = 10;
            this.bBrowseLogs.Text = "View Log";
            this.bBrowseLogs.UseVisualStyleBackColor = true;
            this.bBrowseLogs.Click += new System.EventHandler(this.bBrowseLogs_Click);
            // 
            // chkEnableLogging
            // 
            this.chkEnableLogging.Location = new System.Drawing.Point(9, 65);
            this.chkEnableLogging.Name = "chkEnableLogging";
            this.chkEnableLogging.Size = new System.Drawing.Size(434, 17);
            this.chkEnableLogging.TabIndex = 9;
            this.chkEnableLogging.Text = "Enable logging";
            this.chkEnableLogging.UseVisualStyleBackColor = true;
            this.chkEnableLogging.CheckedChanged += new System.EventHandler(this.chkEnableLogging_CheckedChanged);
            // 
            // chkShowNots
            // 
            this.chkShowNots.AccessibleDescription = "";
            this.chkShowNots.AccessibleName = "show notifications";
            this.chkShowNots.Checked = true;
            this.chkShowNots.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowNots.Location = new System.Drawing.Point(9, 42);
            this.chkShowNots.Name = "chkShowNots";
            this.chkShowNots.Size = new System.Drawing.Size(434, 17);
            this.chkShowNots.TabIndex = 7;
            this.chkShowNots.Text = "Show notifications";
            this.chkShowNots.UseVisualStyleBackColor = true;
            this.chkShowNots.CheckedChanged += new System.EventHandler(this.chkShowNots_CheckedChanged);
            // 
            // chkStartUp
            // 
            this.chkStartUp.AccessibleDescription = "";
            this.chkStartUp.AccessibleName = "start on system startup";
            this.chkStartUp.Location = new System.Drawing.Point(9, 19);
            this.chkStartUp.Name = "chkStartUp";
            this.chkStartUp.Size = new System.Drawing.Size(434, 17);
            this.chkStartUp.TabIndex = 6;
            this.chkStartUp.Text = "Start on system start up";
            this.chkStartUp.UseVisualStyleBackColor = true;
            this.chkStartUp.CheckedChanged += new System.EventHandler(this.chkStartUp_CheckedChanged);
            // 
            // tabAccount
            // 
            this.tabAccount.AccessibleDescription = "";
            this.tabAccount.Controls.Add(this.gWebInt);
            this.tabAccount.Controls.Add(this.bRemoveAccount);
            this.tabAccount.Controls.Add(this.bAddAccount);
            this.tabAccount.Controls.Add(this.cProfiles);
            this.tabAccount.Controls.Add(this.lProfile);
            this.tabAccount.Controls.Add(this.gAccount);
            this.tabAccount.Controls.Add(this.gDetails);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(464, 366);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // gWebInt
            // 
            this.gWebInt.AccessibleDescription = "";
            this.gWebInt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gWebInt.Controls.Add(this.labViewInBrowser);
            this.gWebInt.Controls.Add(this.chkWebInt);
            this.gWebInt.Location = new System.Drawing.Point(8, 294);
            this.gWebInt.Name = "gWebInt";
            this.gWebInt.Size = new System.Drawing.Size(447, 57);
            this.gWebInt.TabIndex = 18;
            this.gWebInt.TabStop = false;
            this.gWebInt.Text = "Web Interface";
            // 
            // labViewInBrowser
            // 
            this.labViewInBrowser.AccessibleDescription = "opens the web interface in browser";
            this.labViewInBrowser.AccessibleName = "View in browser";
            this.labViewInBrowser.AutoSize = true;
            this.labViewInBrowser.Location = new System.Drawing.Point(188, 25);
            this.labViewInBrowser.Name = "labViewInBrowser";
            this.labViewInBrowser.Size = new System.Drawing.Size(87, 13);
            this.labViewInBrowser.TabIndex = 5;
            this.labViewInBrowser.TabStop = true;
            this.labViewInBrowser.Text = "(View in browser)";
            this.labViewInBrowser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labViewInBrowser_LinkClicked);
            // 
            // chkWebInt
            // 
            this.chkWebInt.AccessibleDescription = "";
            this.chkWebInt.AccessibleName = "use the web interface?";
            this.chkWebInt.Location = new System.Drawing.Point(9, 24);
            this.chkWebInt.Name = "chkWebInt";
            this.chkWebInt.Size = new System.Drawing.Size(434, 17);
            this.chkWebInt.TabIndex = 4;
            this.chkWebInt.Text = "Use the web interface";
            this.chkWebInt.UseVisualStyleBackColor = true;
            this.chkWebInt.CheckedChanged += new System.EventHandler(this.chkWebInt_CheckedChanged);
            // 
            // bRemoveAccount
            // 
            this.bRemoveAccount.Location = new System.Drawing.Point(380, 10);
            this.bRemoveAccount.Name = "bRemoveAccount";
            this.bRemoveAccount.Size = new System.Drawing.Size(75, 23);
            this.bRemoveAccount.TabIndex = 17;
            this.bRemoveAccount.Text = "Remove";
            this.bRemoveAccount.UseVisualStyleBackColor = true;
            this.bRemoveAccount.Click += new System.EventHandler(this.bRemoveAccount_Click);
            // 
            // bAddAccount
            // 
            this.bAddAccount.Location = new System.Drawing.Point(299, 10);
            this.bAddAccount.Name = "bAddAccount";
            this.bAddAccount.Size = new System.Drawing.Size(75, 23);
            this.bAddAccount.TabIndex = 16;
            this.bAddAccount.Text = "Add New";
            this.bAddAccount.UseVisualStyleBackColor = true;
            this.bAddAccount.Click += new System.EventHandler(this.bAddAccount_Click);
            // 
            // cProfiles
            // 
            this.cProfiles.AccessibleDescription = "";
            this.cProfiles.AccessibleName = "Profiles";
            this.cProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cProfiles.FormattingEnabled = true;
            this.cProfiles.Location = new System.Drawing.Point(103, 11);
            this.cProfiles.Name = "cProfiles";
            this.cProfiles.Size = new System.Drawing.Size(190, 21);
            this.cProfiles.TabIndex = 15;
            this.cProfiles.SelectedIndexChanged += new System.EventHandler(this.cProfiles_SelectedIndexChanged);
            // 
            // lProfile
            // 
            this.lProfile.AccessibleDescription = "";
            this.lProfile.Location = new System.Drawing.Point(14, 14);
            this.lProfile.Name = "lProfile";
            this.lProfile.Size = new System.Drawing.Size(441, 13);
            this.lProfile.TabIndex = 14;
            this.lProfile.Text = "Profile:";
            // 
            // gAccount
            // 
            this.gAccount.AccessibleDescription = "";
            this.gAccount.AccessibleName = "";
            this.gAccount.Controls.Add(this.lMode);
            this.gAccount.Controls.Add(this.labMode);
            this.gAccount.Controls.Add(this.lPort);
            this.gAccount.Controls.Add(this.lHost);
            this.gAccount.Controls.Add(this.lUsername);
            this.gAccount.Controls.Add(this.labPort);
            this.gAccount.Controls.Add(this.labUN);
            this.gAccount.Controls.Add(this.labHost);
            this.gAccount.Location = new System.Drawing.Point(8, 38);
            this.gAccount.Name = "gAccount";
            this.gAccount.Size = new System.Drawing.Size(447, 102);
            this.gAccount.TabIndex = 3;
            this.gAccount.TabStop = false;
            this.gAccount.Text = "FTP Account";
            // 
            // lMode
            // 
            this.lMode.AccessibleDescription = "";
            this.lMode.Location = new System.Drawing.Point(92, 75);
            this.lMode.Name = "lMode";
            this.lMode.Size = new System.Drawing.Size(274, 13);
            this.lMode.TabIndex = 13;
            this.lMode.Text = "N/A";
            // 
            // labMode
            // 
            this.labMode.AccessibleDescription = "";
            this.labMode.Location = new System.Drawing.Point(6, 75);
            this.labMode.Name = "labMode";
            this.labMode.Size = new System.Drawing.Size(435, 13);
            this.labMode.TabIndex = 12;
            this.labMode.Text = "Mode:";
            // 
            // lPort
            // 
            this.lPort.AccessibleDescription = "";
            this.lPort.Location = new System.Drawing.Point(92, 57);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(274, 13);
            this.lPort.TabIndex = 10;
            this.lPort.Text = "N/A";
            // 
            // lHost
            // 
            this.lHost.AccessibleDescription = "";
            this.lHost.Location = new System.Drawing.Point(92, 21);
            this.lHost.Name = "lHost";
            this.lHost.Size = new System.Drawing.Size(274, 13);
            this.lHost.TabIndex = 9;
            this.lHost.Text = "N/A";
            // 
            // lUsername
            // 
            this.lUsername.AccessibleDescription = "";
            this.lUsername.Location = new System.Drawing.Point(92, 39);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(274, 13);
            this.lUsername.TabIndex = 8;
            this.lUsername.Text = "N/A";
            // 
            // labPort
            // 
            this.labPort.AccessibleDescription = "";
            this.labPort.Location = new System.Drawing.Point(6, 57);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(435, 13);
            this.labPort.TabIndex = 6;
            this.labPort.Text = "Port:";
            // 
            // labUN
            // 
            this.labUN.AccessibleDescription = "";
            this.labUN.Location = new System.Drawing.Point(6, 39);
            this.labUN.Name = "labUN";
            this.labUN.Size = new System.Drawing.Size(435, 13);
            this.labUN.TabIndex = 5;
            this.labUN.Text = "Username:";
            // 
            // labHost
            // 
            this.labHost.AccessibleDescription = "";
            this.labHost.Location = new System.Drawing.Point(6, 21);
            this.labHost.Name = "labHost";
            this.labHost.Size = new System.Drawing.Size(435, 13);
            this.labHost.TabIndex = 4;
            this.labHost.Text = "Host:";
            // 
            // gDetails
            // 
            this.gDetails.AccessibleDescription = "";
            this.gDetails.Controls.Add(this.tParent);
            this.gDetails.Controls.Add(this.labFullPath);
            this.gDetails.Controls.Add(this.lLocPath);
            this.gDetails.Controls.Add(this.lRemPath);
            this.gDetails.Controls.Add(this.labLocPath);
            this.gDetails.Controls.Add(this.labRemPath);
            this.gDetails.Location = new System.Drawing.Point(8, 146);
            this.gDetails.Name = "gDetails";
            this.gDetails.Size = new System.Drawing.Size(447, 142);
            this.gDetails.TabIndex = 0;
            this.gDetails.TabStop = false;
            this.gDetails.Text = "Details";
            // 
            // tParent
            // 
            this.tParent.AccessibleDescription = "";
            this.tParent.AccessibleName = "account\'s http path";
            this.tParent.Location = new System.Drawing.Point(29, 109);
            this.tParent.Name = "tParent";
            this.tParent.Size = new System.Drawing.Size(400, 20);
            this.tParent.TabIndex = 7;
            this.tParent.TextChanged += new System.EventHandler(this.tParent_TextChanged);
            // 
            // labFullPath
            // 
            this.labFullPath.AccessibleDescription = "";
            this.labFullPath.Location = new System.Drawing.Point(6, 93);
            this.labFullPath.Name = "labFullPath";
            this.labFullPath.Size = new System.Drawing.Size(437, 13);
            this.labFullPath.TabIndex = 8;
            this.labFullPath.Text = "Account\'s full path:";
            // 
            // lLocPath
            // 
            this.lLocPath.AccessibleDescription = "";
            this.lLocPath.Location = new System.Drawing.Point(26, 75);
            this.lLocPath.Name = "lLocPath";
            this.lLocPath.Size = new System.Drawing.Size(397, 13);
            this.lLocPath.TabIndex = 6;
            this.lLocPath.Text = "N/A";
            // 
            // lRemPath
            // 
            this.lRemPath.AccessibleDescription = "";
            this.lRemPath.Location = new System.Drawing.Point(26, 37);
            this.lRemPath.Name = "lRemPath";
            this.lRemPath.Size = new System.Drawing.Size(397, 13);
            this.lRemPath.TabIndex = 5;
            this.lRemPath.Text = "N/A";
            // 
            // labLocPath
            // 
            this.labLocPath.AccessibleDescription = "";
            this.labLocPath.Location = new System.Drawing.Point(6, 55);
            this.labLocPath.Name = "labLocPath";
            this.labLocPath.Size = new System.Drawing.Size(435, 13);
            this.labLocPath.TabIndex = 1;
            this.labLocPath.Text = "Local Path:";
            // 
            // labRemPath
            // 
            this.labRemPath.AccessibleDescription = "";
            this.labRemPath.Location = new System.Drawing.Point(6, 19);
            this.labRemPath.Name = "labRemPath";
            this.labRemPath.Size = new System.Drawing.Size(435, 13);
            this.labRemPath.TabIndex = 0;
            this.labRemPath.Text = "Remote Path:";
            // 
            // tabFilters
            // 
            this.tabFilters.Controls.Add(this.gFileFilters);
            this.tabFilters.Location = new System.Drawing.Point(4, 22);
            this.tabFilters.Name = "tabFilters";
            this.tabFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilters.Size = new System.Drawing.Size(464, 366);
            this.tabFilters.TabIndex = 5;
            this.tabFilters.Text = "Filters";
            this.tabFilters.UseVisualStyleBackColor = true;
            // 
            // gFileFilters
            // 
            this.gFileFilters.Controls.Add(this.bConfigureSelectiveSync);
            this.gFileFilters.Controls.Add(this.bConfigureExtensions);
            this.gFileFilters.Controls.Add(this.labSelectiveSync);
            this.gFileFilters.Controls.Add(this.labAlsoIgnore);
            this.gFileFilters.Controls.Add(this.cIgnoreOldFiles);
            this.gFileFilters.Controls.Add(this.dtpLastModTime);
            this.gFileFilters.Controls.Add(this.labSelectExtensions);
            this.gFileFilters.Controls.Add(this.cIgnoreTempFiles);
            this.gFileFilters.Controls.Add(this.cIgnoreDotfiles);
            this.gFileFilters.Location = new System.Drawing.Point(8, 6);
            this.gFileFilters.Name = "gFileFilters";
            this.gFileFilters.Size = new System.Drawing.Size(447, 145);
            this.gFileFilters.TabIndex = 5;
            this.gFileFilters.TabStop = false;
            this.gFileFilters.Text = "File Filters";
            // 
            // bConfigureSelectiveSync
            // 
            this.bConfigureSelectiveSync.Location = new System.Drawing.Point(325, 19);
            this.bConfigureSelectiveSync.Name = "bConfigureSelectiveSync";
            this.bConfigureSelectiveSync.Size = new System.Drawing.Size(107, 23);
            this.bConfigureSelectiveSync.TabIndex = 13;
            this.bConfigureSelectiveSync.Text = "Configure";
            this.bConfigureSelectiveSync.UseVisualStyleBackColor = true;
            this.bConfigureSelectiveSync.Click += new System.EventHandler(this.bConfigureSelectiveSync_Click);
            // 
            // bConfigureExtensions
            // 
            this.bConfigureExtensions.Location = new System.Drawing.Point(325, 48);
            this.bConfigureExtensions.Name = "bConfigureExtensions";
            this.bConfigureExtensions.Size = new System.Drawing.Size(107, 23);
            this.bConfigureExtensions.TabIndex = 12;
            this.bConfigureExtensions.Text = "Configure";
            this.bConfigureExtensions.UseVisualStyleBackColor = true;
            this.bConfigureExtensions.Click += new System.EventHandler(this.bConfigureExtensions_Click);
            // 
            // labSelectiveSync
            // 
            this.labSelectiveSync.Location = new System.Drawing.Point(6, 24);
            this.labSelectiveSync.Name = "labSelectiveSync";
            this.labSelectiveSync.Size = new System.Drawing.Size(435, 13);
            this.labSelectiveSync.TabIndex = 11;
            this.labSelectiveSync.Text = "Selective Sync";
            // 
            // labAlsoIgnore
            // 
            this.labAlsoIgnore.Location = new System.Drawing.Point(6, 82);
            this.labAlsoIgnore.Name = "labAlsoIgnore";
            this.labAlsoIgnore.Size = new System.Drawing.Size(435, 13);
            this.labAlsoIgnore.TabIndex = 10;
            this.labAlsoIgnore.Text = "Also Ignore:";
            // 
            // cIgnoreOldFiles
            // 
            this.cIgnoreOldFiles.Location = new System.Drawing.Point(22, 144);
            this.cIgnoreOldFiles.Name = "cIgnoreOldFiles";
            this.cIgnoreOldFiles.Size = new System.Drawing.Size(408, 17);
            this.cIgnoreOldFiles.TabIndex = 9;
            this.cIgnoreOldFiles.Text = "Files modified before:";
            this.cIgnoreOldFiles.UseVisualStyleBackColor = true;
            this.cIgnoreOldFiles.Visible = false;
            this.cIgnoreOldFiles.CheckedChanged += new System.EventHandler(this.cIgnoreOldFiles_CheckedChanged);
            // 
            // dtpLastModTime
            // 
            this.dtpLastModTime.CustomFormat = "d MMMM yyyy - HH:mm";
            this.dtpLastModTime.Enabled = false;
            this.dtpLastModTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastModTime.Location = new System.Drawing.Point(40, 167);
            this.dtpLastModTime.Name = "dtpLastModTime";
            this.dtpLastModTime.Size = new System.Drawing.Size(186, 20);
            this.dtpLastModTime.TabIndex = 8;
            this.dtpLastModTime.Visible = false;
            this.dtpLastModTime.ValueChanged += new System.EventHandler(this.dtpLastModTime_ValueChanged);
            // 
            // labSelectExtensions
            // 
            this.labSelectExtensions.Location = new System.Drawing.Point(6, 53);
            this.labSelectExtensions.Name = "labSelectExtensions";
            this.labSelectExtensions.Size = new System.Drawing.Size(435, 13);
            this.labSelectExtensions.TabIndex = 5;
            this.labSelectExtensions.Text = "Ignored Extensions";
            // 
            // cIgnoreTempFiles
            // 
            this.cIgnoreTempFiles.Location = new System.Drawing.Point(22, 98);
            this.cIgnoreTempFiles.Name = "cIgnoreTempFiles";
            this.cIgnoreTempFiles.Size = new System.Drawing.Size(408, 17);
            this.cIgnoreTempFiles.TabIndex = 0;
            this.cIgnoreTempFiles.Text = "Temporary files";
            this.cIgnoreTempFiles.UseVisualStyleBackColor = true;
            this.cIgnoreTempFiles.CheckedChanged += new System.EventHandler(this.cIgnoreTempFiles_CheckedChanged);
            // 
            // cIgnoreDotfiles
            // 
            this.cIgnoreDotfiles.Location = new System.Drawing.Point(22, 121);
            this.cIgnoreDotfiles.Name = "cIgnoreDotfiles";
            this.cIgnoreDotfiles.Size = new System.Drawing.Size(408, 17);
            this.cIgnoreDotfiles.TabIndex = 1;
            this.cIgnoreDotfiles.Text = "Dotfiles";
            this.cIgnoreDotfiles.UseVisualStyleBackColor = true;
            this.cIgnoreDotfiles.CheckedChanged += new System.EventHandler(this.cIgnoreDotfiles_CheckedChanged);
            // 
            // tabBandwidth
            // 
            this.tabBandwidth.Controls.Add(this.gSyncing);
            this.tabBandwidth.Controls.Add(this.gLimits);
            this.tabBandwidth.Location = new System.Drawing.Point(4, 22);
            this.tabBandwidth.Name = "tabBandwidth";
            this.tabBandwidth.Padding = new System.Windows.Forms.Padding(3);
            this.tabBandwidth.Size = new System.Drawing.Size(464, 366);
            this.tabBandwidth.TabIndex = 3;
            this.tabBandwidth.Text = "Bandwidth";
            this.tabBandwidth.UseVisualStyleBackColor = true;
            // 
            // gSyncing
            // 
            this.gSyncing.Controls.Add(this.labSeconds);
            this.gSyncing.Controls.Add(this.labSyncWhen);
            this.gSyncing.Controls.Add(this.nSyncFrequency);
            this.gSyncing.Controls.Add(this.cAuto);
            this.gSyncing.Controls.Add(this.cManually);
            this.gSyncing.Location = new System.Drawing.Point(8, 6);
            this.gSyncing.Name = "gSyncing";
            this.gSyncing.Size = new System.Drawing.Size(447, 124);
            this.gSyncing.TabIndex = 2;
            this.gSyncing.TabStop = false;
            this.gSyncing.Text = "Syncing";
            // 
            // labSeconds
            // 
            this.labSeconds.Location = new System.Drawing.Point(116, 91);
            this.labSeconds.Name = "labSeconds";
            this.labSeconds.Size = new System.Drawing.Size(222, 13);
            this.labSeconds.TabIndex = 5;
            this.labSeconds.Text = "seconds";
            // 
            // labSyncWhen
            // 
            this.labSyncWhen.Location = new System.Drawing.Point(6, 22);
            this.labSyncWhen.Name = "labSyncWhen";
            this.labSyncWhen.Size = new System.Drawing.Size(435, 13);
            this.labSyncWhen.TabIndex = 4;
            this.labSyncWhen.Text = "Synchronize remote files:";
            // 
            // nSyncFrequency
            // 
            this.nSyncFrequency.AccessibleName = "synchronization interval in seconds";
            this.nSyncFrequency.Location = new System.Drawing.Point(35, 89);
            this.nSyncFrequency.Maximum = new decimal(new int[] {
            79228,
            0,
            0,
            0});
            this.nSyncFrequency.Name = "nSyncFrequency";
            this.nSyncFrequency.Size = new System.Drawing.Size(75, 20);
            this.nSyncFrequency.TabIndex = 2;
            this.nSyncFrequency.ValueChanged += new System.EventHandler(this.nSyncFrequency_ValueChanged);
            // 
            // cAuto
            // 
            this.cAuto.AccessibleName = "synchronize automatically";
            this.cAuto.Location = new System.Drawing.Point(22, 66);
            this.cAuto.Name = "cAuto";
            this.cAuto.Size = new System.Drawing.Size(411, 17);
            this.cAuto.TabIndex = 1;
            this.cAuto.TabStop = true;
            this.cAuto.Text = "automatically every";
            this.cAuto.UseVisualStyleBackColor = true;
            this.cAuto.CheckedChanged += new System.EventHandler(this.cAuto_CheckedChanged);
            // 
            // cManually
            // 
            this.cManually.AccessibleName = "synchronize manually";
            this.cManually.Location = new System.Drawing.Point(22, 43);
            this.cManually.Name = "cManually";
            this.cManually.Size = new System.Drawing.Size(411, 17);
            this.cManually.TabIndex = 0;
            this.cManually.TabStop = true;
            this.cManually.Text = "manually";
            this.cManually.UseVisualStyleBackColor = true;
            this.cManually.CheckedChanged += new System.EventHandler(this.cManually_CheckedChanged);
            // 
            // gLimits
            // 
            this.gLimits.Controls.Add(this.labNoLimits);
            this.gLimits.Controls.Add(this.label4);
            this.gLimits.Controls.Add(this.label3);
            this.gLimits.Controls.Add(this.nUpLimit);
            this.gLimits.Controls.Add(this.nDownLimit);
            this.gLimits.Controls.Add(this.labUpSpeed);
            this.gLimits.Controls.Add(this.labDownSpeed);
            this.gLimits.Location = new System.Drawing.Point(8, 136);
            this.gLimits.Name = "gLimits";
            this.gLimits.Size = new System.Drawing.Size(447, 158);
            this.gLimits.TabIndex = 1;
            this.gLimits.TabStop = false;
            this.gLimits.Text = "Speed Limits";
            // 
            // labNoLimits
            // 
            this.labNoLimits.Location = new System.Drawing.Point(22, 132);
            this.labNoLimits.Name = "labNoLimits";
            this.labNoLimits.Size = new System.Drawing.Size(411, 13);
            this.labNoLimits.TabIndex = 14;
            this.labNoLimits.Text = "( set to 0 for no limits )";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(119, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "kb/s";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(119, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "kb/s";
            // 
            // nUpLimit
            // 
            this.nUpLimit.AccessibleName = "upload speed limit";
            this.nUpLimit.Location = new System.Drawing.Point(35, 100);
            this.nUpLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpLimit.Name = "nUpLimit";
            this.nUpLimit.Size = new System.Drawing.Size(75, 20);
            this.nUpLimit.TabIndex = 9;
            this.nUpLimit.ValueChanged += new System.EventHandler(this.nUpLimit_ValueChanged);
            // 
            // nDownLimit
            // 
            this.nDownLimit.AccessibleName = "download speed limit";
            this.nDownLimit.Location = new System.Drawing.Point(35, 45);
            this.nDownLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nDownLimit.Name = "nDownLimit";
            this.nDownLimit.Size = new System.Drawing.Size(75, 20);
            this.nDownLimit.TabIndex = 6;
            this.nDownLimit.ValueChanged += new System.EventHandler(this.nDownLimit_ValueChanged);
            // 
            // labUpSpeed
            // 
            this.labUpSpeed.Location = new System.Drawing.Point(9, 77);
            this.labUpSpeed.Name = "labUpSpeed";
            this.labUpSpeed.Size = new System.Drawing.Size(432, 13);
            this.labUpSpeed.TabIndex = 6;
            this.labUpSpeed.Text = "Limit Upload Speed:";
            // 
            // labDownSpeed
            // 
            this.labDownSpeed.Location = new System.Drawing.Point(6, 22);
            this.labDownSpeed.Name = "labDownSpeed";
            this.labDownSpeed.Size = new System.Drawing.Size(435, 13);
            this.labDownSpeed.TabIndex = 3;
            this.labDownSpeed.Text = "Limit Download Speed:";
            // 
            // tabAbout
            // 
            this.tabAbout.AccessibleDescription = "";
            this.tabAbout.Controls.Add(this.labSupportMail);
            this.tabAbout.Controls.Add(this.linkLabel4);
            this.tabAbout.Controls.Add(this.linkLabel3);
            this.tabAbout.Controls.Add(this.label19);
            this.tabAbout.Controls.Add(this.label21);
            this.tabAbout.Controls.Add(this.lVersion);
            this.tabAbout.Controls.Add(this.labLangUsed);
            this.tabAbout.Controls.Add(this.labContact);
            this.tabAbout.Controls.Add(this.labSite);
            this.tabAbout.Controls.Add(this.labTeam);
            this.tabAbout.Controls.Add(this.labCurVersion);
            this.tabAbout.Controls.Add(this.gContribute);
            this.tabAbout.Controls.Add(this.gNotes);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(464, 366);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // labSupportMail
            // 
            this.labSupportMail.AccessibleDescription = "";
            this.labSupportMail.Location = new System.Drawing.Point(272, 113);
            this.labSupportMail.Name = "labSupportMail";
            this.labSupportMail.Size = new System.Drawing.Size(129, 13);
            this.labSupportMail.TabIndex = 14;
            this.labSupportMail.Text = "support@ftpbox.org";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AccessibleDescription = "";
            this.linkLabel4.Location = new System.Drawing.Point(272, 67);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(129, 13);
            this.linkLabel4.TabIndex = 9;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "ftpbox.org";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AccessibleDescription = "";
            this.linkLabel3.Location = new System.Drawing.Point(272, 44);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(129, 13);
            this.linkLabel3.TabIndex = 8;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "FTPbox team";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label19
            // 
            this.label19.AccessibleDescription = "";
            this.label19.Location = new System.Drawing.Point(272, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "C# / .NET";
            // 
            // label21
            // 
            this.label21.AccessibleDescription = "";
            this.label21.Location = new System.Drawing.Point(272, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(129, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "admin@ftpbox.org";
            // 
            // lVersion
            // 
            this.lVersion.AccessibleDescription = "";
            this.lVersion.Location = new System.Drawing.Point(272, 21);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(129, 13);
            this.lVersion.TabIndex = 8;
            this.lVersion.Text = "X.X.X (build X)";
            // 
            // labLangUsed
            // 
            this.labLangUsed.AccessibleDescription = "";
            this.labLangUsed.AutoSize = true;
            this.labLangUsed.Location = new System.Drawing.Point(102, 136);
            this.labLangUsed.Name = "labLangUsed";
            this.labLangUsed.Size = new System.Drawing.Size(84, 13);
            this.labLangUsed.TabIndex = 7;
            this.labLangUsed.Text = "Language used:";
            // 
            // labContact
            // 
            this.labContact.AccessibleDescription = "";
            this.labContact.AutoSize = true;
            this.labContact.Location = new System.Drawing.Point(102, 90);
            this.labContact.Name = "labContact";
            this.labContact.Size = new System.Drawing.Size(47, 13);
            this.labContact.TabIndex = 5;
            this.labContact.Text = "Contact:";
            // 
            // labSite
            // 
            this.labSite.AccessibleDescription = "";
            this.labSite.AutoSize = true;
            this.labSite.Location = new System.Drawing.Point(102, 67);
            this.labSite.Name = "labSite";
            this.labSite.Size = new System.Drawing.Size(84, 13);
            this.labSite.TabIndex = 4;
            this.labSite.Text = "Official Website:";
            // 
            // labTeam
            // 
            this.labTeam.AccessibleDescription = "";
            this.labTeam.AutoSize = true;
            this.labTeam.Location = new System.Drawing.Point(102, 44);
            this.labTeam.Name = "labTeam";
            this.labTeam.Size = new System.Drawing.Size(59, 13);
            this.labTeam.TabIndex = 3;
            this.labTeam.Text = "The Team:";
            // 
            // labCurVersion
            // 
            this.labCurVersion.AccessibleDescription = "";
            this.labCurVersion.AutoSize = true;
            this.labCurVersion.Location = new System.Drawing.Point(102, 21);
            this.labCurVersion.Name = "labCurVersion";
            this.labCurVersion.Size = new System.Drawing.Size(82, 13);
            this.labCurVersion.TabIndex = 2;
            this.labCurVersion.Text = "Current Version:";
            // 
            // gContribute
            // 
            this.gContribute.AccessibleDescription = "";
            this.gContribute.Controls.Add(this.labDonate);
            this.gContribute.Controls.Add(this.pictureBox1);
            this.gContribute.Controls.Add(this.linkLabel2);
            this.gContribute.Controls.Add(this.linkLabel1);
            this.gContribute.Location = new System.Drawing.Point(8, 192);
            this.gContribute.Name = "gContribute";
            this.gContribute.Size = new System.Drawing.Size(447, 48);
            this.gContribute.TabIndex = 1;
            this.gContribute.TabStop = false;
            this.gContribute.Text = "Contribute";
            // 
            // labDonate
            // 
            this.labDonate.AutoSize = true;
            this.labDonate.Location = new System.Drawing.Point(6, 54);
            this.labDonate.Name = "labDonate";
            this.labDonate.Size = new System.Drawing.Size(45, 13);
            this.labDonate.TabIndex = 4;
            this.labDonate.Text = "Donate:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "opens donate page";
            this.pictureBox1.AccessibleName = "Donate button";
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::FTPbox.Properties.Resources.donate;
            this.pictureBox1.Location = new System.Drawing.Point(367, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AccessibleDescription = "";
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(177, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 13);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Request a feature";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleDescription = "";
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Report a bug";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // gNotes
            // 
            this.gNotes.AccessibleDescription = "";
            this.gNotes.Controls.Add(this.label11);
            this.gNotes.Controls.Add(this.labContactMe);
            this.gNotes.Controls.Add(this.labFree);
            this.gNotes.Location = new System.Drawing.Point(8, 246);
            this.gNotes.Name = "gNotes";
            this.gNotes.Size = new System.Drawing.Size(447, 69);
            this.gNotes.TabIndex = 0;
            this.gNotes.TabStop = false;
            this.gNotes.Text = "Notes";
            // 
            // label11
            // 
            this.label11.AccessibleDescription = "";
            this.label11.Location = new System.Drawing.Point(6, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(435, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Copyright © 2013 - ftpbox.org";
            // 
            // labContactMe
            // 
            this.labContactMe.AccessibleDescription = "";
            this.labContactMe.Location = new System.Drawing.Point(6, 35);
            this.labContactMe.Name = "labContactMe";
            this.labContactMe.Size = new System.Drawing.Size(435, 13);
            this.labContactMe.TabIndex = 2;
            this.labContactMe.Text = "- Feel free to contact me for anything.";
            // 
            // labFree
            // 
            this.labFree.AccessibleDescription = "";
            this.labFree.Location = new System.Drawing.Point(6, 19);
            this.labFree.Name = "labFree";
            this.labFree.Size = new System.Drawing.Size(435, 13);
            this.labFree.TabIndex = 0;
            this.labFree.Text = "- FTPbox is free and open-source";
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray.ContextMenuStrip = this.trayMenu;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "FTPbox";
            this.tray.Visible = true;
            this.tray.BalloonTipClicked += new System.EventHandler(this.tray_BalloonTipClicked);
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.recentFilesToolStripMenuItem,
            this.SyncToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(143, 126);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.AccessibleDescription = "Dropbdown menu";
            this.recentFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem1.Text = "Not available";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem2.Text = "Not available";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem3.Text = "Not available";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem4.Text = "Not available";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem5.Text = "Not available";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // SyncToolStripMenuItem
            // 
            this.SyncToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SyncToolStripMenuItem.Name = "SyncToolStripMenuItem";
            this.SyncToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.SyncToolStripMenuItem.Text = "Start syncing";
            this.SyncToolStripMenuItem.Click += new System.EventHandler(this.SyncToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 384);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTPbox Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.RightToLeftLayoutChanged += new System.EventHandler(this.fMain_RightToLeftLayoutChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.gLanguage.ResumeLayout(false);
            this.gLinks.ResumeLayout(false);
            this.gApp.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.gWebInt.ResumeLayout(false);
            this.gWebInt.PerformLayout();
            this.gAccount.ResumeLayout(false);
            this.gDetails.ResumeLayout(false);
            this.gDetails.PerformLayout();
            this.tabFilters.ResumeLayout(false);
            this.gFileFilters.ResumeLayout(false);
            this.tabBandwidth.ResumeLayout(false);
            this.gSyncing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nSyncFrequency)).EndInit();
            this.gLimits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUpLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDownLimit)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.gContribute.ResumeLayout(false);
            this.gContribute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gNotes.ResumeLayout(false);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox gApp;
        private System.Windows.Forms.CheckBox chkShowNots;
        private System.Windows.Forms.CheckBox chkStartUp;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.GroupBox gDetails;
        private System.Windows.Forms.Label lLocPath;
        private System.Windows.Forms.Label lRemPath;
        private System.Windows.Forms.Label labLocPath;
        private System.Windows.Forms.Label labRemPath;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label labSupportMail;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Label labLangUsed;
        private System.Windows.Forms.Label labContact;
        private System.Windows.Forms.Label labSite;
        private System.Windows.Forms.Label labTeam;
        private System.Windows.Forms.Label labCurVersion;
        private System.Windows.Forms.GroupBox gContribute;
        private System.Windows.Forms.Label labDonate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labContactMe;
        private System.Windows.Forms.Label labFree;
        private System.IO.FileSystemWatcher fswFiles;
        private System.IO.FileSystemWatcher fswFolders;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabBandwidth;
        private System.Windows.Forms.GroupBox gLinks;
        private System.Windows.Forms.RadioButton rCopy2Clipboard;
        private System.Windows.Forms.RadioButton rOpenInBrowser;
        private System.Windows.Forms.GroupBox gAccount;
        private System.Windows.Forms.Label lMode;
        private System.Windows.Forms.Label labMode;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.Label lHost;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Label labUN;
        private System.Windows.Forms.Label labHost;
        private System.Windows.Forms.GroupBox gLimits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUpLimit;
        private System.Windows.Forms.NumericUpDown nDownLimit;
        private System.Windows.Forms.Label labUpSpeed;
        private System.Windows.Forms.Label labDownSpeed;
        private System.Windows.Forms.RadioButton rOpenLocal;
        private System.Windows.Forms.GroupBox gSyncing;
        private System.Windows.Forms.NumericUpDown nSyncFrequency;
        private System.Windows.Forms.RadioButton cAuto;
        private System.Windows.Forms.RadioButton cManually;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label labSyncWhen;
        private System.Windows.Forms.Label labSeconds;
        private System.Windows.Forms.Label labNoLimits;
        private System.Windows.Forms.TabPage tabFilters;
        private System.Windows.Forms.GroupBox gFileFilters;
        private System.Windows.Forms.Label labSelectExtensions;
        private System.Windows.Forms.CheckBox cIgnoreTempFiles;
        private System.Windows.Forms.CheckBox cIgnoreDotfiles;
        private System.Windows.Forms.Label labAlsoIgnore;
        private System.Windows.Forms.CheckBox cIgnoreOldFiles;
        private System.Windows.Forms.DateTimePicker dtpLastModTime;
        private System.Windows.Forms.Label lProfile;
        private System.Windows.Forms.Label labLinkClicked;
        private System.Windows.Forms.ComboBox cProfiles;
        private System.Windows.Forms.CheckBox chkEnableLogging;
        private System.Windows.Forms.Button bBrowseLogs;
        private System.Windows.Forms.Button bAddAccount;
        private System.Windows.Forms.Button bRemoveAccount;
        private System.Windows.Forms.GroupBox gWebInt;
        private System.Windows.Forms.LinkLabel labViewInBrowser;
        private System.Windows.Forms.CheckBox chkWebInt;
        private System.Windows.Forms.TextBox tParent;
        private System.Windows.Forms.Label labFullPath;
        private System.Windows.Forms.GroupBox gLanguage;
        private System.Windows.Forms.ComboBox cLanguages;
        private System.Windows.Forms.Button bTranslate;
        private System.Windows.Forms.Button bConfigureExtensions;
        private System.Windows.Forms.Label labSelectiveSync;
        private System.Windows.Forms.Button bConfigureSelectiveSync;
    }
}