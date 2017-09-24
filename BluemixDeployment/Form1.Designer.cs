namespace BluemixDeployment
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbOrg = new System.Windows.Forms.ComboBox();
            this.LbOrg = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cbSpaces = new System.Windows.Forms.ComboBox();
            this.LbSpaces = new System.Windows.Forms.Label();
            this.cbApps = new System.Windows.Forms.ComboBox();
            this.lbApps = new System.Windows.Forms.Label();
            this.BtnNewApp = new System.Windows.Forms.Button();
            this.tbAppName = new System.Windows.Forms.TextBox();
            this.lbAppName = new System.Windows.Forms.Label();
            this.cbBuildPack = new System.Windows.Forms.ComboBox();
            this.lbBuildPack = new System.Windows.Forms.Label();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.lbServices = new System.Windows.Forms.Label();
            this.cbServiceIntances = new System.Windows.Forms.ComboBox();
            this.lbServiceInstances = new System.Windows.Forms.Label();
            this.btnNewSrvInst = new System.Windows.Forms.Button();
            this.lbNameSrvInst = new System.Windows.Forms.Label();
            this.tbNewSrvInst = new System.Windows.Forms.TextBox();
            this.lbServicePlans = new System.Windows.Forms.Label();
            this.cbServicesPlans = new System.Windows.Forms.ComboBox();
            this.btnNewSrvKeys = new System.Windows.Forms.Button();
            this.lbNewSrvKeys = new System.Windows.Forms.Label();
            this.tbSrvKeysName = new System.Windows.Forms.TextBox();
            this.btnGetLstClassifier = new System.Windows.Forms.Button();
            this.lvClassifiers = new System.Windows.Forms.ListView();
            this.Hid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hcreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hurl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Huser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hpwd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNLCTest = new System.Windows.Forms.Button();
            this.tbTextClassify = new System.Windows.Forms.TextBox();
            this.btnChooseFileQuestions = new System.Windows.Forms.Button();
            this.openFileDialogQuestion = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNLC = new System.Windows.Forms.TabPage();
            this.btnListDialogs = new System.Windows.Forms.Button();
            this.lvDialogs = new System.Windows.Forms.ListView();
            this.chDialogId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDialogName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.tbNLCQuestion = new System.Windows.Forms.TextBox();
            this.btnNLCClassify = new System.Windows.Forms.Button();
            this.btnNLCBrowseTrainingFile = new System.Windows.Forms.Button();
            this.tbNLCFilePath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbNLCLanguage = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNLCClassifierName = new System.Windows.Forms.TextBox();
            this.btnNLCDeleteClassifier = new System.Windows.Forms.Button();
            this.btnNLCCreateClassifier = new System.Windows.Forms.Button();
            this.tabPageRnR = new System.Windows.Forms.TabPage();
            this.cbxRnRRanker = new System.Windows.Forms.CheckBox();
            this.btnRnRBrowseRankerFile = new System.Windows.Forms.Button();
            this.tbRnRRankerFilePath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRnRDeleteRanker = new System.Windows.Forms.Button();
            this.tbRnRRankerName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRnRCreateRanker = new System.Windows.Forms.Button();
            this.lvRnRRankers = new System.Windows.Forms.ListView();
            this.chRnRRnakerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRnRRankerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRnRRankerCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRnRRankers = new System.Windows.Forms.Button();
            this.btnRnRBrowseConfigFile = new System.Windows.Forms.Button();
            this.tbRnRConfigFilePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRnRQuery = new System.Windows.Forms.TextBox();
            this.btnRnRBrowseIndexFile = new System.Windows.Forms.Button();
            this.tbRnRIndexFilePath = new System.Windows.Forms.TextBox();
            this.btnRnRQuery = new System.Windows.Forms.Button();
            this.btnRnRIndexing = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRnRDeleteCollection = new System.Windows.Forms.Button();
            this.tbRnRCollectionName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRnRCreateCollection = new System.Windows.Forms.Button();
            this.btnRnRCollections = new System.Windows.Forms.Button();
            this.cbRnRCollections = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRnRDeleteConfig = new System.Windows.Forms.Button();
            this.tbRnRConfigName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRnRCreateConfig = new System.Windows.Forms.Button();
            this.BtnRnRConfigs = new System.Windows.Forms.Button();
            this.cbRnRConfigs = new System.Windows.Forms.ComboBox();
            this.btnDeleteRnRCluster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRnrClusterSize = new System.Windows.Forms.ComboBox();
            this.tbRnrClusterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateRnRCluster = new System.Windows.Forms.Button();
            this.lvRnRClusters = new System.Windows.Forms.ListView();
            this.chRnRClusterId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRnRClusterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRnRClusterSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRnRClusterStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRnRClusters = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.btnWCSWorkspaceBrowseFile = new System.Windows.Forms.Button();
            this.tbWCSWorkspaceFilePath = new System.Windows.Forms.TextBox();
            this.btnWCSDeleteWorkspace = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.cbWCSWorkspaceVersion = new System.Windows.Forms.ComboBox();
            this.tbWCSWorkspaceName = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnWCSWorkspaceCreate = new System.Windows.Forms.Button();
            this.btnWCSListWorkspaces = new System.Windows.Forms.Button();
            this.lvWCSWorkspaces = new System.Windows.Forms.ListView();
            this.chWCSId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWCSName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWCSLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWCSDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWCSCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.tbRecastConvId = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbRecastConvMessage = new System.Windows.Forms.TextBox();
            this.btnRecastConversation = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.tbRecastAnalyzeText = new System.Windows.Forms.TextBox();
            this.btnRecastAnalyzeText = new System.Windows.Forms.Button();
            this.cbxRecastExpSelectAll = new System.Windows.Forms.CheckBox();
            this.btnRecastExpCreate = new System.Windows.Forms.Button();
            this.btnRecastExpDelete = new System.Windows.Forms.Button();
            this.btnRecastExpUpdate = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.tbRecastExpLanguage = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbRecastExpId = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbRecastExpSource = new System.Windows.Forms.TextBox();
            this.btnRecastIntentCreate = new System.Windows.Forms.Button();
            this.btnRecastIntentDelete = new System.Windows.Forms.Button();
            this.btnRecastIntentUpdate = new System.Windows.Forms.Button();
            this.btnRecastIntentGet = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.tbRecastIntentDesc = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbRecastIntentId = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbRecastIntentName = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbRecastIntentSlug = new System.Windows.Forms.TextBox();
            this.btnRecastBrowseExpFile = new System.Windows.Forms.Button();
            this.tbRecastLoadExpFilePath = new System.Windows.Forms.TextBox();
            this.btnRecastLoadExpressions = new System.Windows.Forms.Button();
            this.lvRecastIntents = new System.Windows.Forms.ListView();
            this.chRecastIntentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRecastIntentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRecastIntentSlug = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRecastIntentDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRecastBotUpdate = new System.Windows.Forms.Button();
            this.cbxRecastBotPublic = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbRecastBotStrict = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbRecastBotLanguage = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbRecastBotDescription = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbRecastBotId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbRecastRequestToken = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbRecastBotDevToken = new System.Windows.Forms.TextBox();
            this.lvRecastExpressions = new System.Windows.Forms.ListView();
            this.chRecastExpId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRecastExpSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRecastExpLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRecastExpressions = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbRecastUser = new System.Windows.Forms.TextBox();
            this.lbBotSlug = new System.Windows.Forms.Label();
            this.tbRecastBotSlug = new System.Windows.Forms.TextBox();
            this.btnRecastBotGet = new System.Windows.Forms.Button();
            this.openFileDialogRnRConfigFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogRnRIndexFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogNLCTrainingFile = new System.Windows.Forms.OpenFileDialog();
            this.btnListServiceInstance = new System.Windows.Forms.Button();
            this.btnListApplications = new System.Windows.Forms.Button();
            this.btnDeleteApplication = new System.Windows.Forms.Button();
            this.btnDeleteServiceInstance = new System.Windows.Forms.Button();
            this.btnListServiceKeys = new System.Windows.Forms.Button();
            this.btnDeleteServiceKeys = new System.Windows.Forms.Button();
            this.cbServiceKeys = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialogRnRRankerFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogRecastExpFile = new System.Windows.Forms.OpenFileDialog();
            this.label30 = new System.Windows.Forms.Label();
            this.openFileDialogWCSFilePath = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageNLC.SuspendLayout();
            this.tabPageRnR.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 1101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(26, 767);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(933, 267);
            this.tbLog.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(977, 865);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 121);
            this.dataGridView1.TabIndex = 2;
            // 
            // cbOrg
            // 
            this.cbOrg.FormattingEnabled = true;
            this.cbOrg.Location = new System.Drawing.Point(231, 14);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Size = new System.Drawing.Size(214, 21);
            this.cbOrg.TabIndex = 3;
            this.cbOrg.SelectedIndexChanged += new System.EventHandler(this.cbOrg_SelectedIndexChanged);
            // 
            // LbOrg
            // 
            this.LbOrg.AutoSize = true;
            this.LbOrg.Location = new System.Drawing.Point(181, 17);
            this.LbOrg.Name = "LbOrg";
            this.LbOrg.Size = new System.Drawing.Size(33, 13);
            this.LbOrg.TabIndex = 4;
            this.LbOrg.Text = "Org : ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbSpaces
            // 
            this.cbSpaces.FormattingEnabled = true;
            this.cbSpaces.Location = new System.Drawing.Point(575, 14);
            this.cbSpaces.Name = "cbSpaces";
            this.cbSpaces.Size = new System.Drawing.Size(214, 21);
            this.cbSpaces.TabIndex = 7;
            this.cbSpaces.SelectedIndexChanged += new System.EventHandler(this.cbSpaces_SelectedIndexChanged);
            // 
            // LbSpaces
            // 
            this.LbSpaces.AutoSize = true;
            this.LbSpaces.Location = new System.Drawing.Point(513, 17);
            this.LbSpaces.Name = "LbSpaces";
            this.LbSpaces.Size = new System.Drawing.Size(49, 13);
            this.LbSpaces.TabIndex = 8;
            this.LbSpaces.Text = "Spaces :";
            // 
            // cbApps
            // 
            this.cbApps.FormattingEnabled = true;
            this.cbApps.Location = new System.Drawing.Point(1319, 86);
            this.cbApps.Name = "cbApps";
            this.cbApps.Size = new System.Drawing.Size(214, 21);
            this.cbApps.TabIndex = 9;
            this.cbApps.SelectedIndexChanged += new System.EventHandler(this.cbApps_SelectedIndexChanged);
            // 
            // lbApps
            // 
            this.lbApps.AutoSize = true;
            this.lbApps.Location = new System.Drawing.Point(1256, 91);
            this.lbApps.Name = "lbApps";
            this.lbApps.Size = new System.Drawing.Size(37, 13);
            this.lbApps.TabIndex = 10;
            this.lbApps.Text = "Apps :";
            // 
            // BtnNewApp
            // 
            this.BtnNewApp.Location = new System.Drawing.Point(1055, 116);
            this.BtnNewApp.Name = "BtnNewApp";
            this.BtnNewApp.Size = new System.Drawing.Size(141, 23);
            this.BtnNewApp.TabIndex = 11;
            this.BtnNewApp.Text = "New Application";
            this.BtnNewApp.UseVisualStyleBackColor = true;
            this.BtnNewApp.Click += new System.EventHandler(this.BtnNewApp_Click);
            // 
            // tbAppName
            // 
            this.tbAppName.Location = new System.Drawing.Point(1319, 118);
            this.tbAppName.Name = "tbAppName";
            this.tbAppName.Size = new System.Drawing.Size(214, 20);
            this.tbAppName.TabIndex = 12;
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.Location = new System.Drawing.Point(1251, 122);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(44, 13);
            this.lbAppName.TabIndex = 13;
            this.lbAppName.Text = "Name : ";
            // 
            // cbBuildPack
            // 
            this.cbBuildPack.FormattingEnabled = true;
            this.cbBuildPack.Location = new System.Drawing.Point(936, 14);
            this.cbBuildPack.Name = "cbBuildPack";
            this.cbBuildPack.Size = new System.Drawing.Size(295, 21);
            this.cbBuildPack.TabIndex = 14;
            // 
            // lbBuildPack
            // 
            this.lbBuildPack.AutoSize = true;
            this.lbBuildPack.Location = new System.Drawing.Point(866, 17);
            this.lbBuildPack.Name = "lbBuildPack";
            this.lbBuildPack.Size = new System.Drawing.Size(61, 13);
            this.lbBuildPack.TabIndex = 15;
            this.lbBuildPack.Text = "BuildPack :";
            // 
            // cbServices
            // 
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(231, 41);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(214, 21);
            this.cbServices.TabIndex = 16;
            this.cbServices.SelectedIndexChanged += new System.EventHandler(this.cbServices_SelectedIndexChanged);
            // 
            // lbServices
            // 
            this.lbServices.AutoSize = true;
            this.lbServices.Location = new System.Drawing.Point(160, 44);
            this.lbServices.Name = "lbServices";
            this.lbServices.Size = new System.Drawing.Size(54, 13);
            this.lbServices.TabIndex = 17;
            this.lbServices.Text = "Services :";
            // 
            // cbServiceIntances
            // 
            this.cbServiceIntances.FormattingEnabled = true;
            this.cbServiceIntances.Location = new System.Drawing.Point(267, 84);
            this.cbServiceIntances.Name = "cbServiceIntances";
            this.cbServiceIntances.Size = new System.Drawing.Size(214, 21);
            this.cbServiceIntances.TabIndex = 18;
            this.cbServiceIntances.SelectedIndexChanged += new System.EventHandler(this.cbServiceIntances_SelectedIndexChanged);
            // 
            // lbServiceInstances
            // 
            this.lbServiceInstances.AutoSize = true;
            this.lbServiceInstances.Location = new System.Drawing.Point(160, 87);
            this.lbServiceInstances.Name = "lbServiceInstances";
            this.lbServiceInstances.Size = new System.Drawing.Size(101, 13);
            this.lbServiceInstances.TabIndex = 19;
            this.lbServiceInstances.Text = "Service Instances : ";
            // 
            // btnNewSrvInst
            // 
            this.btnNewSrvInst.Location = new System.Drawing.Point(12, 120);
            this.btnNewSrvInst.Name = "btnNewSrvInst";
            this.btnNewSrvInst.Size = new System.Drawing.Size(142, 23);
            this.btnNewSrvInst.TabIndex = 20;
            this.btnNewSrvInst.Text = "New Service Instance";
            this.btnNewSrvInst.UseVisualStyleBackColor = true;
            this.btnNewSrvInst.Click += new System.EventHandler(this.btnNewSrvInst_Click);
            // 
            // lbNameSrvInst
            // 
            this.lbNameSrvInst.AutoSize = true;
            this.lbNameSrvInst.Location = new System.Drawing.Point(216, 127);
            this.lbNameSrvInst.Name = "lbNameSrvInst";
            this.lbNameSrvInst.Size = new System.Drawing.Size(44, 13);
            this.lbNameSrvInst.TabIndex = 22;
            this.lbNameSrvInst.Text = "Name : ";
            // 
            // tbNewSrvInst
            // 
            this.tbNewSrvInst.Location = new System.Drawing.Point(267, 123);
            this.tbNewSrvInst.Name = "tbNewSrvInst";
            this.tbNewSrvInst.Size = new System.Drawing.Size(214, 20);
            this.tbNewSrvInst.TabIndex = 21;
            // 
            // lbServicePlans
            // 
            this.lbServicePlans.AutoSize = true;
            this.lbServicePlans.Location = new System.Drawing.Point(485, 46);
            this.lbServicePlans.Name = "lbServicePlans";
            this.lbServicePlans.Size = new System.Drawing.Size(81, 13);
            this.lbServicePlans.TabIndex = 23;
            this.lbServicePlans.Text = "Service Plans : ";
            // 
            // cbServicesPlans
            // 
            this.cbServicesPlans.FormattingEnabled = true;
            this.cbServicesPlans.Location = new System.Drawing.Point(575, 43);
            this.cbServicesPlans.Name = "cbServicesPlans";
            this.cbServicesPlans.Size = new System.Drawing.Size(214, 21);
            this.cbServicesPlans.TabIndex = 24;
            // 
            // btnNewSrvKeys
            // 
            this.btnNewSrvKeys.Location = new System.Drawing.Point(530, 121);
            this.btnNewSrvKeys.Name = "btnNewSrvKeys";
            this.btnNewSrvKeys.Size = new System.Drawing.Size(142, 23);
            this.btnNewSrvKeys.TabIndex = 25;
            this.btnNewSrvKeys.Text = "New Service Keys";
            this.btnNewSrvKeys.UseVisualStyleBackColor = true;
            this.btnNewSrvKeys.Click += new System.EventHandler(this.btnNewSrvKeys_Click);
            // 
            // lbNewSrvKeys
            // 
            this.lbNewSrvKeys.AutoSize = true;
            this.lbNewSrvKeys.Location = new System.Drawing.Point(732, 131);
            this.lbNewSrvKeys.Name = "lbNewSrvKeys";
            this.lbNewSrvKeys.Size = new System.Drawing.Size(44, 13);
            this.lbNewSrvKeys.TabIndex = 27;
            this.lbNewSrvKeys.Text = "Name : ";
            // 
            // tbSrvKeysName
            // 
            this.tbSrvKeysName.Location = new System.Drawing.Point(793, 124);
            this.tbSrvKeysName.Name = "tbSrvKeysName";
            this.tbSrvKeysName.Size = new System.Drawing.Size(214, 20);
            this.tbSrvKeysName.TabIndex = 26;
            // 
            // btnGetLstClassifier
            // 
            this.btnGetLstClassifier.Location = new System.Drawing.Point(16, 95);
            this.btnGetLstClassifier.Name = "btnGetLstClassifier";
            this.btnGetLstClassifier.Size = new System.Drawing.Size(142, 23);
            this.btnGetLstClassifier.TabIndex = 28;
            this.btnGetLstClassifier.Text = "Get List Classifier";
            this.btnGetLstClassifier.UseVisualStyleBackColor = true;
            this.btnGetLstClassifier.Click += new System.EventHandler(this.btnGetLstClassifier_Click);
            // 
            // lvClassifiers
            // 
            this.lvClassifiers.CheckBoxes = true;
            this.lvClassifiers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hid,
            this.Hname,
            this.Hcreated,
            this.Hurl,
            this.Huser,
            this.Hpwd});
            this.lvClassifiers.FullRowSelect = true;
            this.lvClassifiers.GridLines = true;
            this.lvClassifiers.Location = new System.Drawing.Point(178, 95);
            this.lvClassifiers.MultiSelect = false;
            this.lvClassifiers.Name = "lvClassifiers";
            this.lvClassifiers.Size = new System.Drawing.Size(567, 129);
            this.lvClassifiers.TabIndex = 29;
            this.lvClassifiers.UseCompatibleStateImageBehavior = false;
            this.lvClassifiers.View = System.Windows.Forms.View.Details;
            // 
            // Hid
            // 
            this.Hid.Text = "Id";
            this.Hid.Width = 185;
            // 
            // Hname
            // 
            this.Hname.Text = "Name";
            this.Hname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hname.Width = 213;
            // 
            // Hcreated
            // 
            this.Hcreated.Text = "Created";
            this.Hcreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hcreated.Width = 164;
            // 
            // Hurl
            // 
            this.Hurl.Width = 0;
            // 
            // Huser
            // 
            this.Huser.Width = 0;
            // 
            // Hpwd
            // 
            this.Hpwd.Width = 0;
            // 
            // btnNLCTest
            // 
            this.btnNLCTest.Location = new System.Drawing.Point(16, 305);
            this.btnNLCTest.Name = "btnNLCTest";
            this.btnNLCTest.Size = new System.Drawing.Size(182, 23);
            this.btnNLCTest.TabIndex = 30;
            this.btnNLCTest.Text = "Test";
            this.btnNLCTest.UseVisualStyleBackColor = true;
            this.btnNLCTest.Click += new System.EventHandler(this.btnNLCTest_Click);
            // 
            // tbTextClassify
            // 
            this.tbTextClassify.Location = new System.Drawing.Point(225, 308);
            this.tbTextClassify.Name = "tbTextClassify";
            this.tbTextClassify.Size = new System.Drawing.Size(284, 20);
            this.tbTextClassify.TabIndex = 31;
            // 
            // btnChooseFileQuestions
            // 
            this.btnChooseFileQuestions.Location = new System.Drawing.Point(552, 304);
            this.btnChooseFileQuestions.Name = "btnChooseFileQuestions";
            this.btnChooseFileQuestions.Size = new System.Drawing.Size(136, 23);
            this.btnChooseFileQuestions.TabIndex = 32;
            this.btnChooseFileQuestions.Text = "Browse";
            this.btnChooseFileQuestions.UseVisualStyleBackColor = true;
            this.btnChooseFileQuestions.Click += new System.EventHandler(this.btnChooseFileQuestions_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNLC);
            this.tabControl1.Controls.Add(this.tabPageRnR);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 211);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1529, 532);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPageNLC
            // 
            this.tabPageNLC.Controls.Add(this.btnListDialogs);
            this.tabPageNLC.Controls.Add(this.lvDialogs);
            this.tabPageNLC.Controls.Add(this.label15);
            this.tabPageNLC.Controls.Add(this.tbNLCQuestion);
            this.tabPageNLC.Controls.Add(this.btnNLCClassify);
            this.tabPageNLC.Controls.Add(this.btnNLCBrowseTrainingFile);
            this.tabPageNLC.Controls.Add(this.tbNLCFilePath);
            this.tabPageNLC.Controls.Add(this.label11);
            this.tabPageNLC.Controls.Add(this.label10);
            this.tabPageNLC.Controls.Add(this.cbNLCLanguage);
            this.tabPageNLC.Controls.Add(this.label9);
            this.tabPageNLC.Controls.Add(this.tbNLCClassifierName);
            this.tabPageNLC.Controls.Add(this.btnNLCDeleteClassifier);
            this.tabPageNLC.Controls.Add(this.btnNLCCreateClassifier);
            this.tabPageNLC.Controls.Add(this.lvClassifiers);
            this.tabPageNLC.Controls.Add(this.btnChooseFileQuestions);
            this.tabPageNLC.Controls.Add(this.btnGetLstClassifier);
            this.tabPageNLC.Controls.Add(this.tbTextClassify);
            this.tabPageNLC.Controls.Add(this.btnNLCTest);
            this.tabPageNLC.Location = new System.Drawing.Point(4, 22);
            this.tabPageNLC.Name = "tabPageNLC";
            this.tabPageNLC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNLC.Size = new System.Drawing.Size(1521, 506);
            this.tabPageNLC.TabIndex = 0;
            this.tabPageNLC.Text = "NLC / Dialog";
            this.tabPageNLC.UseVisualStyleBackColor = true;
            // 
            // btnListDialogs
            // 
            this.btnListDialogs.Location = new System.Drawing.Point(828, 66);
            this.btnListDialogs.Name = "btnListDialogs";
            this.btnListDialogs.Size = new System.Drawing.Size(142, 23);
            this.btnListDialogs.TabIndex = 46;
            this.btnListDialogs.Text = "Get List Dialogs";
            this.btnListDialogs.UseVisualStyleBackColor = true;
            this.btnListDialogs.Click += new System.EventHandler(this.btnListDialogs_Click);
            // 
            // lvDialogs
            // 
            this.lvDialogs.CheckBoxes = true;
            this.lvDialogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDialogId,
            this.chDialogName});
            this.lvDialogs.FullRowSelect = true;
            this.lvDialogs.GridLines = true;
            this.lvDialogs.Location = new System.Drawing.Point(828, 95);
            this.lvDialogs.MultiSelect = false;
            this.lvDialogs.Name = "lvDialogs";
            this.lvDialogs.Size = new System.Drawing.Size(567, 129);
            this.lvDialogs.TabIndex = 45;
            this.lvDialogs.UseCompatibleStateImageBehavior = false;
            this.lvDialogs.View = System.Windows.Forms.View.Details;
            // 
            // chDialogId
            // 
            this.chDialogId.Text = "Id";
            this.chDialogId.Width = 317;
            // 
            // chDialogName
            // 
            this.chDialogName.Text = "Name";
            this.chDialogName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDialogName.Width = 246;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(222, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Question :";
            // 
            // tbNLCQuestion
            // 
            this.tbNLCQuestion.Location = new System.Drawing.Point(283, 259);
            this.tbNLCQuestion.Name = "tbNLCQuestion";
            this.tbNLCQuestion.Size = new System.Drawing.Size(284, 20);
            this.tbNLCQuestion.TabIndex = 43;
            // 
            // btnNLCClassify
            // 
            this.btnNLCClassify.Location = new System.Drawing.Point(16, 256);
            this.btnNLCClassify.Name = "btnNLCClassify";
            this.btnNLCClassify.Size = new System.Drawing.Size(182, 23);
            this.btnNLCClassify.TabIndex = 42;
            this.btnNLCClassify.Text = "Classify";
            this.btnNLCClassify.UseVisualStyleBackColor = true;
            this.btnNLCClassify.Click += new System.EventHandler(this.btnNLCClassify_Click);
            // 
            // btnNLCBrowseTrainingFile
            // 
            this.btnNLCBrowseTrainingFile.Location = new System.Drawing.Point(465, 54);
            this.btnNLCBrowseTrainingFile.Name = "btnNLCBrowseTrainingFile";
            this.btnNLCBrowseTrainingFile.Size = new System.Drawing.Size(75, 23);
            this.btnNLCBrowseTrainingFile.TabIndex = 41;
            this.btnNLCBrowseTrainingFile.Text = "Browse";
            this.btnNLCBrowseTrainingFile.UseVisualStyleBackColor = true;
            this.btnNLCBrowseTrainingFile.Click += new System.EventHandler(this.btnNLCBrowseTrainingFile_Click);
            // 
            // tbNLCFilePath
            // 
            this.tbNLCFilePath.Location = new System.Drawing.Point(225, 54);
            this.tbNLCFilePath.Name = "tbNLCFilePath";
            this.tbNLCFilePath.Size = new System.Drawing.Size(214, 20);
            this.tbNLCFilePath.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "File :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(462, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Language : ";
            // 
            // cbNLCLanguage
            // 
            this.cbNLCLanguage.FormattingEnabled = true;
            this.cbNLCLanguage.Items.AddRange(new object[] {
            "fr",
            "en"});
            this.cbNLCLanguage.Location = new System.Drawing.Point(535, 20);
            this.cbNLCLanguage.Name = "cbNLCLanguage";
            this.cbNLCLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbNLCLanguage.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Name : ";
            // 
            // tbNLCClassifierName
            // 
            this.tbNLCClassifierName.Location = new System.Drawing.Point(225, 22);
            this.tbNLCClassifierName.Name = "tbNLCClassifierName";
            this.tbNLCClassifierName.Size = new System.Drawing.Size(214, 20);
            this.tbNLCClassifierName.TabIndex = 35;
            // 
            // btnNLCDeleteClassifier
            // 
            this.btnNLCDeleteClassifier.Location = new System.Drawing.Point(16, 133);
            this.btnNLCDeleteClassifier.Name = "btnNLCDeleteClassifier";
            this.btnNLCDeleteClassifier.Size = new System.Drawing.Size(142, 23);
            this.btnNLCDeleteClassifier.TabIndex = 34;
            this.btnNLCDeleteClassifier.Text = "Delete Classifier";
            this.btnNLCDeleteClassifier.UseVisualStyleBackColor = true;
            this.btnNLCDeleteClassifier.Click += new System.EventHandler(this.btnNLCDeleteClassifier_Click);
            // 
            // btnNLCCreateClassifier
            // 
            this.btnNLCCreateClassifier.Location = new System.Drawing.Point(16, 20);
            this.btnNLCCreateClassifier.Name = "btnNLCCreateClassifier";
            this.btnNLCCreateClassifier.Size = new System.Drawing.Size(142, 23);
            this.btnNLCCreateClassifier.TabIndex = 33;
            this.btnNLCCreateClassifier.Text = "Create Classifier";
            this.btnNLCCreateClassifier.UseVisualStyleBackColor = true;
            this.btnNLCCreateClassifier.Click += new System.EventHandler(this.btnNLCCreateClassifier_Click);
            // 
            // tabPageRnR
            // 
            this.tabPageRnR.Controls.Add(this.cbxRnRRanker);
            this.tabPageRnR.Controls.Add(this.btnRnRBrowseRankerFile);
            this.tabPageRnR.Controls.Add(this.tbRnRRankerFilePath);
            this.tabPageRnR.Controls.Add(this.label14);
            this.tabPageRnR.Controls.Add(this.btnRnRDeleteRanker);
            this.tabPageRnR.Controls.Add(this.tbRnRRankerName);
            this.tabPageRnR.Controls.Add(this.label13);
            this.tabPageRnR.Controls.Add(this.btnRnRCreateRanker);
            this.tabPageRnR.Controls.Add(this.lvRnRRankers);
            this.tabPageRnR.Controls.Add(this.btnRnRRankers);
            this.tabPageRnR.Controls.Add(this.btnRnRBrowseConfigFile);
            this.tabPageRnR.Controls.Add(this.tbRnRConfigFilePath);
            this.tabPageRnR.Controls.Add(this.label8);
            this.tabPageRnR.Controls.Add(this.label7);
            this.tabPageRnR.Controls.Add(this.tbRnRQuery);
            this.tabPageRnR.Controls.Add(this.btnRnRBrowseIndexFile);
            this.tabPageRnR.Controls.Add(this.tbRnRIndexFilePath);
            this.tabPageRnR.Controls.Add(this.btnRnRQuery);
            this.tabPageRnR.Controls.Add(this.btnRnRIndexing);
            this.tabPageRnR.Controls.Add(this.label5);
            this.tabPageRnR.Controls.Add(this.btnRnRDeleteCollection);
            this.tabPageRnR.Controls.Add(this.tbRnRCollectionName);
            this.tabPageRnR.Controls.Add(this.label6);
            this.tabPageRnR.Controls.Add(this.btnRnRCreateCollection);
            this.tabPageRnR.Controls.Add(this.btnRnRCollections);
            this.tabPageRnR.Controls.Add(this.cbRnRCollections);
            this.tabPageRnR.Controls.Add(this.label3);
            this.tabPageRnR.Controls.Add(this.btnRnRDeleteConfig);
            this.tabPageRnR.Controls.Add(this.tbRnRConfigName);
            this.tabPageRnR.Controls.Add(this.label4);
            this.tabPageRnR.Controls.Add(this.btnRnRCreateConfig);
            this.tabPageRnR.Controls.Add(this.BtnRnRConfigs);
            this.tabPageRnR.Controls.Add(this.cbRnRConfigs);
            this.tabPageRnR.Controls.Add(this.btnDeleteRnRCluster);
            this.tabPageRnR.Controls.Add(this.label2);
            this.tabPageRnR.Controls.Add(this.cbRnrClusterSize);
            this.tabPageRnR.Controls.Add(this.tbRnrClusterName);
            this.tabPageRnR.Controls.Add(this.label1);
            this.tabPageRnR.Controls.Add(this.btnCreateRnRCluster);
            this.tabPageRnR.Controls.Add(this.lvRnRClusters);
            this.tabPageRnR.Controls.Add(this.BtnRnRClusters);
            this.tabPageRnR.Location = new System.Drawing.Point(4, 22);
            this.tabPageRnR.Name = "tabPageRnR";
            this.tabPageRnR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRnR.Size = new System.Drawing.Size(1521, 506);
            this.tabPageRnR.TabIndex = 1;
            this.tabPageRnR.Text = "RnR";
            this.tabPageRnR.UseVisualStyleBackColor = true;
            // 
            // cbxRnRRanker
            // 
            this.cbxRnRRanker.AutoSize = true;
            this.cbxRnRRanker.Location = new System.Drawing.Point(896, 313);
            this.cbxRnRRanker.Name = "cbxRnRRanker";
            this.cbxRnRRanker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxRnRRanker.Size = new System.Drawing.Size(67, 17);
            this.cbxRnRRanker.TabIndex = 70;
            this.cbxRnRRanker.Text = ": Ranker";
            this.cbxRnRRanker.UseVisualStyleBackColor = true;
            // 
            // btnRnRBrowseRankerFile
            // 
            this.btnRnRBrowseRankerFile.Location = new System.Drawing.Point(1226, 44);
            this.btnRnRBrowseRankerFile.Name = "btnRnRBrowseRankerFile";
            this.btnRnRBrowseRankerFile.Size = new System.Drawing.Size(85, 23);
            this.btnRnRBrowseRankerFile.TabIndex = 69;
            this.btnRnRBrowseRankerFile.Text = "Browse";
            this.btnRnRBrowseRankerFile.UseVisualStyleBackColor = true;
            this.btnRnRBrowseRankerFile.Click += new System.EventHandler(this.btnRnRBrowseRankerFile_Click);
            // 
            // tbRnRRankerFilePath
            // 
            this.tbRnRRankerFilePath.Location = new System.Drawing.Point(1004, 45);
            this.tbRnRRankerFilePath.Name = "tbRnRRankerFilePath";
            this.tbRnRRankerFilePath.Size = new System.Drawing.Size(214, 20);
            this.tbRnRRankerFilePath.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(964, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "File : ";
            // 
            // btnRnRDeleteRanker
            // 
            this.btnRnRDeleteRanker.Location = new System.Drawing.Point(801, 78);
            this.btnRnRDeleteRanker.Name = "btnRnRDeleteRanker";
            this.btnRnRDeleteRanker.Size = new System.Drawing.Size(142, 23);
            this.btnRnRDeleteRanker.TabIndex = 66;
            this.btnRnRDeleteRanker.Text = "Delete Ranker";
            this.btnRnRDeleteRanker.UseVisualStyleBackColor = true;
            this.btnRnRDeleteRanker.Click += new System.EventHandler(this.btnRnRDeleteRanker_Click);
            // 
            // tbRnRRankerName
            // 
            this.tbRnRRankerName.Location = new System.Drawing.Point(1003, 12);
            this.tbRnRRankerName.Name = "tbRnRRankerName";
            this.tbRnRRankerName.Size = new System.Drawing.Size(215, 20);
            this.tbRnRRankerName.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(953, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Name : ";
            // 
            // btnRnRCreateRanker
            // 
            this.btnRnRCreateRanker.Location = new System.Drawing.Point(801, 9);
            this.btnRnRCreateRanker.Name = "btnRnRCreateRanker";
            this.btnRnRCreateRanker.Size = new System.Drawing.Size(142, 23);
            this.btnRnRCreateRanker.TabIndex = 63;
            this.btnRnRCreateRanker.Text = "Create Ranker";
            this.btnRnRCreateRanker.UseVisualStyleBackColor = true;
            this.btnRnRCreateRanker.Click += new System.EventHandler(this.btnRnRCreateRanker_Click);
            // 
            // lvRnRRankers
            // 
            this.lvRnRRankers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvRnRRankers.CheckBoxes = true;
            this.lvRnRRankers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRnRRnakerId,
            this.chRnRRankerName,
            this.chRnRRankerCreated});
            this.lvRnRRankers.FullRowSelect = true;
            this.lvRnRRankers.GridLines = true;
            this.lvRnRRankers.Location = new System.Drawing.Point(801, 112);
            this.lvRnRRankers.MultiSelect = false;
            this.lvRnRRankers.Name = "lvRnRRankers";
            this.lvRnRRankers.Size = new System.Drawing.Size(690, 90);
            this.lvRnRRankers.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvRnRRankers.TabIndex = 62;
            this.lvRnRRankers.UseCompatibleStateImageBehavior = false;
            this.lvRnRRankers.View = System.Windows.Forms.View.Details;
            // 
            // chRnRRnakerId
            // 
            this.chRnRRnakerId.Text = "Id";
            this.chRnRRnakerId.Width = 316;
            // 
            // chRnRRankerName
            // 
            this.chRnRRankerName.Text = "Name";
            this.chRnRRankerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRnRRankerName.Width = 213;
            // 
            // chRnRRankerCreated
            // 
            this.chRnRRankerCreated.Text = "Created";
            this.chRnRRankerCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRnRRankerCreated.Width = 157;
            // 
            // btnRnRRankers
            // 
            this.btnRnRRankers.Location = new System.Drawing.Point(801, 42);
            this.btnRnRRankers.Name = "btnRnRRankers";
            this.btnRnRRankers.Size = new System.Drawing.Size(142, 23);
            this.btnRnRRankers.TabIndex = 61;
            this.btnRnRRankers.Text = "Get List Rankers";
            this.btnRnRRankers.UseVisualStyleBackColor = true;
            this.btnRnRRankers.Click += new System.EventHandler(this.btnRnRRankers_Click);
            // 
            // btnRnRBrowseConfigFile
            // 
            this.btnRnRBrowseConfigFile.Location = new System.Drawing.Point(459, 307);
            this.btnRnRBrowseConfigFile.Name = "btnRnRBrowseConfigFile";
            this.btnRnRBrowseConfigFile.Size = new System.Drawing.Size(85, 23);
            this.btnRnRBrowseConfigFile.TabIndex = 60;
            this.btnRnRBrowseConfigFile.Text = "Browse";
            this.btnRnRBrowseConfigFile.UseVisualStyleBackColor = true;
            this.btnRnRBrowseConfigFile.Click += new System.EventHandler(this.btnRnRBrowseConfigFile_Click);
            // 
            // tbRnRConfigFilePath
            // 
            this.tbRnRConfigFilePath.Location = new System.Drawing.Point(237, 308);
            this.tbRnRConfigFilePath.Name = "tbRnRConfigFilePath";
            this.tbRnRConfigFilePath.Size = new System.Drawing.Size(214, 20);
            this.tbRnRConfigFilePath.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "File : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(893, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Query : ";
            // 
            // tbRnRQuery
            // 
            this.tbRnRQuery.Location = new System.Drawing.Point(944, 275);
            this.tbRnRQuery.Name = "tbRnRQuery";
            this.tbRnRQuery.Size = new System.Drawing.Size(451, 20);
            this.tbRnRQuery.TabIndex = 56;
            // 
            // btnRnRBrowseIndexFile
            // 
            this.btnRnRBrowseIndexFile.Location = new System.Drawing.Point(1223, 234);
            this.btnRnRBrowseIndexFile.Name = "btnRnRBrowseIndexFile";
            this.btnRnRBrowseIndexFile.Size = new System.Drawing.Size(85, 23);
            this.btnRnRBrowseIndexFile.TabIndex = 55;
            this.btnRnRBrowseIndexFile.Text = "Browse";
            this.btnRnRBrowseIndexFile.UseVisualStyleBackColor = true;
            this.btnRnRBrowseIndexFile.Click += new System.EventHandler(this.btnRnRBrowseIndexFile_Click);
            // 
            // tbRnRIndexFilePath
            // 
            this.tbRnRIndexFilePath.Location = new System.Drawing.Point(944, 234);
            this.tbRnRIndexFilePath.Name = "tbRnRIndexFilePath";
            this.tbRnRIndexFilePath.Size = new System.Drawing.Size(262, 20);
            this.tbRnRIndexFilePath.TabIndex = 54;
            // 
            // btnRnRQuery
            // 
            this.btnRnRQuery.Location = new System.Drawing.Point(801, 273);
            this.btnRnRQuery.Name = "btnRnRQuery";
            this.btnRnRQuery.Size = new System.Drawing.Size(83, 23);
            this.btnRnRQuery.TabIndex = 53;
            this.btnRnRQuery.Text = "Query";
            this.btnRnRQuery.UseVisualStyleBackColor = true;
            this.btnRnRQuery.Click += new System.EventHandler(this.btnRnRQuery_Click);
            // 
            // btnRnRIndexing
            // 
            this.btnRnRIndexing.Location = new System.Drawing.Point(801, 230);
            this.btnRnRIndexing.Name = "btnRnRIndexing";
            this.btnRnRIndexing.Size = new System.Drawing.Size(125, 23);
            this.btnRnRIndexing.TabIndex = 52;
            this.btnRnRIndexing.Text = "Indexing Documents";
            this.btnRnRIndexing.UseVisualStyleBackColor = true;
            this.btnRnRIndexing.Click += new System.EventHandler(this.btnRnRIndexing_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Collections : ";
            // 
            // btnRnRDeleteCollection
            // 
            this.btnRnRDeleteCollection.Location = new System.Drawing.Point(24, 442);
            this.btnRnRDeleteCollection.Name = "btnRnRDeleteCollection";
            this.btnRnRDeleteCollection.Size = new System.Drawing.Size(142, 23);
            this.btnRnRDeleteCollection.TabIndex = 50;
            this.btnRnRDeleteCollection.Text = "Delete Collection";
            this.btnRnRDeleteCollection.UseVisualStyleBackColor = true;
            this.btnRnRDeleteCollection.Click += new System.EventHandler(this.btnRnRDeleteCollection_Click);
            // 
            // tbRnRCollectionName
            // 
            this.tbRnRCollectionName.Location = new System.Drawing.Point(240, 406);
            this.tbRnRCollectionName.Name = "tbRnRCollectionName";
            this.tbRnRCollectionName.Size = new System.Drawing.Size(211, 20);
            this.tbRnRCollectionName.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Name : ";
            // 
            // btnRnRCreateCollection
            // 
            this.btnRnRCreateCollection.Location = new System.Drawing.Point(24, 403);
            this.btnRnRCreateCollection.Name = "btnRnRCreateCollection";
            this.btnRnRCreateCollection.Size = new System.Drawing.Size(142, 23);
            this.btnRnRCreateCollection.TabIndex = 47;
            this.btnRnRCreateCollection.Text = "Create Collection";
            this.btnRnRCreateCollection.UseVisualStyleBackColor = true;
            this.btnRnRCreateCollection.Click += new System.EventHandler(this.btnRnRCreateCollection_Click);
            // 
            // btnRnRCollections
            // 
            this.btnRnRCollections.Location = new System.Drawing.Point(24, 362);
            this.btnRnRCollections.Name = "btnRnRCollections";
            this.btnRnRCollections.Size = new System.Drawing.Size(142, 23);
            this.btnRnRCollections.TabIndex = 46;
            this.btnRnRCollections.Text = "Get List Collections";
            this.btnRnRCollections.UseVisualStyleBackColor = true;
            this.btnRnRCollections.Click += new System.EventHandler(this.btnRnRCollections_Click);
            // 
            // cbRnRCollections
            // 
            this.cbRnRCollections.FormattingEnabled = true;
            this.cbRnRCollections.Location = new System.Drawing.Point(240, 362);
            this.cbRnRCollections.Name = "cbRnRCollections";
            this.cbRnRCollections.Size = new System.Drawing.Size(211, 21);
            this.cbRnRCollections.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Configs : ";
            // 
            // btnRnRDeleteConfig
            // 
            this.btnRnRDeleteConfig.Location = new System.Drawing.Point(24, 308);
            this.btnRnRDeleteConfig.Name = "btnRnRDeleteConfig";
            this.btnRnRDeleteConfig.Size = new System.Drawing.Size(142, 23);
            this.btnRnRDeleteConfig.TabIndex = 43;
            this.btnRnRDeleteConfig.Text = "Delete Config";
            this.btnRnRDeleteConfig.UseVisualStyleBackColor = true;
            this.btnRnRDeleteConfig.Click += new System.EventHandler(this.btnRnRDeleteConfig_Click);
            // 
            // tbRnRConfigName
            // 
            this.tbRnRConfigName.Location = new System.Drawing.Point(237, 273);
            this.tbRnRConfigName.Name = "tbRnRConfigName";
            this.tbRnRConfigName.Size = new System.Drawing.Size(214, 20);
            this.tbRnRConfigName.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Name : ";
            // 
            // btnRnRCreateConfig
            // 
            this.btnRnRCreateConfig.Location = new System.Drawing.Point(24, 270);
            this.btnRnRCreateConfig.Name = "btnRnRCreateConfig";
            this.btnRnRCreateConfig.Size = new System.Drawing.Size(142, 23);
            this.btnRnRCreateConfig.TabIndex = 40;
            this.btnRnRCreateConfig.Text = "Create Config";
            this.btnRnRCreateConfig.UseVisualStyleBackColor = true;
            this.btnRnRCreateConfig.Click += new System.EventHandler(this.btnRnRCreateConfig_Click);
            // 
            // BtnRnRConfigs
            // 
            this.BtnRnRConfigs.Location = new System.Drawing.Point(24, 229);
            this.BtnRnRConfigs.Name = "BtnRnRConfigs";
            this.BtnRnRConfigs.Size = new System.Drawing.Size(142, 23);
            this.BtnRnRConfigs.TabIndex = 39;
            this.BtnRnRConfigs.Text = "Get List Configs";
            this.BtnRnRConfigs.UseVisualStyleBackColor = true;
            this.BtnRnRConfigs.Click += new System.EventHandler(this.BtnRnRConfigs_Click);
            // 
            // cbRnRConfigs
            // 
            this.cbRnRConfigs.FormattingEnabled = true;
            this.cbRnRConfigs.Location = new System.Drawing.Point(237, 229);
            this.cbRnRConfigs.Name = "cbRnRConfigs";
            this.cbRnRConfigs.Size = new System.Drawing.Size(214, 21);
            this.cbRnRConfigs.TabIndex = 38;
            // 
            // btnDeleteRnRCluster
            // 
            this.btnDeleteRnRCluster.Location = new System.Drawing.Point(24, 81);
            this.btnDeleteRnRCluster.Name = "btnDeleteRnRCluster";
            this.btnDeleteRnRCluster.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteRnRCluster.TabIndex = 37;
            this.btnDeleteRnRCluster.Text = "Delete Cluster";
            this.btnDeleteRnRCluster.UseVisualStyleBackColor = true;
            this.btnDeleteRnRCluster.Click += new System.EventHandler(this.btnDeleteRnRCluster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Size : ";
            // 
            // cbRnrClusterSize
            // 
            this.cbRnrClusterSize.FormattingEnabled = true;
            this.cbRnrClusterSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbRnrClusterSize.Location = new System.Drawing.Point(577, 10);
            this.cbRnrClusterSize.Name = "cbRnrClusterSize";
            this.cbRnrClusterSize.Size = new System.Drawing.Size(121, 21);
            this.cbRnrClusterSize.TabIndex = 35;
            // 
            // tbRnrClusterName
            // 
            this.tbRnrClusterName.Location = new System.Drawing.Point(226, 11);
            this.tbRnrClusterName.Name = "tbRnrClusterName";
            this.tbRnrClusterName.Size = new System.Drawing.Size(274, 20);
            this.tbRnrClusterName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name : ";
            // 
            // btnCreateRnRCluster
            // 
            this.btnCreateRnRCluster.Location = new System.Drawing.Point(24, 8);
            this.btnCreateRnRCluster.Name = "btnCreateRnRCluster";
            this.btnCreateRnRCluster.Size = new System.Drawing.Size(142, 23);
            this.btnCreateRnRCluster.TabIndex = 32;
            this.btnCreateRnRCluster.Text = "Create Cluster";
            this.btnCreateRnRCluster.UseVisualStyleBackColor = true;
            this.btnCreateRnRCluster.Click += new System.EventHandler(this.btnCreateRnRCluster_Click);
            // 
            // lvRnRClusters
            // 
            this.lvRnRClusters.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvRnRClusters.CheckBoxes = true;
            this.lvRnRClusters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRnRClusterId,
            this.chRnRClusterName,
            this.chRnRClusterSize,
            this.chRnRClusterStatus});
            this.lvRnRClusters.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvRnRClusters.FullRowSelect = true;
            this.lvRnRClusters.GridLines = true;
            this.lvRnRClusters.Location = new System.Drawing.Point(26, 112);
            this.lvRnRClusters.MultiSelect = false;
            this.lvRnRClusters.Name = "lvRnRClusters";
            this.lvRnRClusters.Size = new System.Drawing.Size(695, 90);
            this.lvRnRClusters.TabIndex = 31;
            this.lvRnRClusters.UseCompatibleStateImageBehavior = false;
            this.lvRnRClusters.View = System.Windows.Forms.View.Details;
            // 
            // chRnRClusterId
            // 
            this.chRnRClusterId.Text = "Id";
            this.chRnRClusterId.Width = 357;
            // 
            // chRnRClusterName
            // 
            this.chRnRClusterName.Text = "Name";
            this.chRnRClusterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRnRClusterName.Width = 114;
            // 
            // chRnRClusterSize
            // 
            this.chRnRClusterSize.Text = "Size";
            this.chRnRClusterSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRnRClusterSize.Width = 63;
            // 
            // chRnRClusterStatus
            // 
            this.chRnRClusterStatus.Text = "Status";
            this.chRnRClusterStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRnRClusterStatus.Width = 157;
            // 
            // BtnRnRClusters
            // 
            this.BtnRnRClusters.Location = new System.Drawing.Point(24, 43);
            this.BtnRnRClusters.Name = "BtnRnRClusters";
            this.BtnRnRClusters.Size = new System.Drawing.Size(142, 23);
            this.BtnRnRClusters.TabIndex = 30;
            this.BtnRnRClusters.Text = "Get List Clusters";
            this.BtnRnRClusters.UseVisualStyleBackColor = true;
            this.BtnRnRClusters.Click += new System.EventHandler(this.BtnRnRClusters_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.btnWCSWorkspaceBrowseFile);
            this.tabPage1.Controls.Add(this.tbWCSWorkspaceFilePath);
            this.tabPage1.Controls.Add(this.btnWCSDeleteWorkspace);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.cbWCSWorkspaceVersion);
            this.tabPage1.Controls.Add(this.tbWCSWorkspaceName);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.btnWCSWorkspaceCreate);
            this.tabPage1.Controls.Add(this.btnWCSListWorkspaces);
            this.tabPage1.Controls.Add(this.lvWCSWorkspaces);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1521, 506);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "WCS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(177, 57);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(51, 13);
            this.label36.TabIndex = 71;
            this.label36.Text = "Version : ";
            // 
            // btnWCSWorkspaceBrowseFile
            // 
            this.btnWCSWorkspaceBrowseFile.Location = new System.Drawing.Point(860, 17);
            this.btnWCSWorkspaceBrowseFile.Name = "btnWCSWorkspaceBrowseFile";
            this.btnWCSWorkspaceBrowseFile.Size = new System.Drawing.Size(85, 23);
            this.btnWCSWorkspaceBrowseFile.TabIndex = 70;
            this.btnWCSWorkspaceBrowseFile.Text = "Browse";
            this.btnWCSWorkspaceBrowseFile.UseVisualStyleBackColor = true;
            this.btnWCSWorkspaceBrowseFile.Click += new System.EventHandler(this.btnWCSWorkspaceBrowseFile_Click);
            // 
            // tbWCSWorkspaceFilePath
            // 
            this.tbWCSWorkspaceFilePath.Location = new System.Drawing.Point(564, 17);
            this.tbWCSWorkspaceFilePath.Name = "tbWCSWorkspaceFilePath";
            this.tbWCSWorkspaceFilePath.Size = new System.Drawing.Size(274, 20);
            this.tbWCSWorkspaceFilePath.TabIndex = 56;
            // 
            // btnWCSDeleteWorkspace
            // 
            this.btnWCSDeleteWorkspace.Location = new System.Drawing.Point(29, 88);
            this.btnWCSDeleteWorkspace.Name = "btnWCSDeleteWorkspace";
            this.btnWCSDeleteWorkspace.Size = new System.Drawing.Size(142, 23);
            this.btnWCSDeleteWorkspace.TabIndex = 55;
            this.btnWCSDeleteWorkspace.Text = "Delete Workspace";
            this.btnWCSDeleteWorkspace.UseVisualStyleBackColor = true;
            this.btnWCSDeleteWorkspace.Click += new System.EventHandler(this.btnWCSDeleteWorkspace_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(526, 20);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(32, 13);
            this.label34.TabIndex = 54;
            this.label34.Text = "File : ";
            // 
            // cbWCSWorkspaceVersion
            // 
            this.cbWCSWorkspaceVersion.FormattingEnabled = true;
            this.cbWCSWorkspaceVersion.Items.AddRange(new object[] {
            "2017-05-26"});
            this.cbWCSWorkspaceVersion.Location = new System.Drawing.Point(231, 52);
            this.cbWCSWorkspaceVersion.Name = "cbWCSWorkspaceVersion";
            this.cbWCSWorkspaceVersion.Size = new System.Drawing.Size(121, 21);
            this.cbWCSWorkspaceVersion.TabIndex = 53;
            // 
            // tbWCSWorkspaceName
            // 
            this.tbWCSWorkspaceName.Location = new System.Drawing.Point(231, 18);
            this.tbWCSWorkspaceName.Name = "tbWCSWorkspaceName";
            this.tbWCSWorkspaceName.Size = new System.Drawing.Size(274, 20);
            this.tbWCSWorkspaceName.TabIndex = 52;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(181, 20);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 13);
            this.label35.TabIndex = 51;
            this.label35.Text = "Name : ";
            // 
            // btnWCSWorkspaceCreate
            // 
            this.btnWCSWorkspaceCreate.Location = new System.Drawing.Point(29, 15);
            this.btnWCSWorkspaceCreate.Name = "btnWCSWorkspaceCreate";
            this.btnWCSWorkspaceCreate.Size = new System.Drawing.Size(142, 23);
            this.btnWCSWorkspaceCreate.TabIndex = 50;
            this.btnWCSWorkspaceCreate.Text = "Create Workspace";
            this.btnWCSWorkspaceCreate.UseVisualStyleBackColor = true;
            this.btnWCSWorkspaceCreate.Click += new System.EventHandler(this.btnWCSWorkspaceCreate_Click);
            // 
            // btnWCSListWorkspaces
            // 
            this.btnWCSListWorkspaces.Location = new System.Drawing.Point(29, 50);
            this.btnWCSListWorkspaces.Name = "btnWCSListWorkspaces";
            this.btnWCSListWorkspaces.Size = new System.Drawing.Size(142, 23);
            this.btnWCSListWorkspaces.TabIndex = 49;
            this.btnWCSListWorkspaces.Text = "Get List Workspaces";
            this.btnWCSListWorkspaces.UseVisualStyleBackColor = true;
            this.btnWCSListWorkspaces.Click += new System.EventHandler(this.btnWCSListWorkspaces_Click);
            // 
            // lvWCSWorkspaces
            // 
            this.lvWCSWorkspaces.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvWCSWorkspaces.CheckBoxes = true;
            this.lvWCSWorkspaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWCSId,
            this.chWCSName,
            this.chWCSLanguage,
            this.chWCSDescription,
            this.chWCSCreated});
            this.lvWCSWorkspaces.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvWCSWorkspaces.FullRowSelect = true;
            this.lvWCSWorkspaces.GridLines = true;
            this.lvWCSWorkspaces.Location = new System.Drawing.Point(29, 126);
            this.lvWCSWorkspaces.MultiSelect = false;
            this.lvWCSWorkspaces.Name = "lvWCSWorkspaces";
            this.lvWCSWorkspaces.Size = new System.Drawing.Size(986, 162);
            this.lvWCSWorkspaces.TabIndex = 48;
            this.lvWCSWorkspaces.UseCompatibleStateImageBehavior = false;
            this.lvWCSWorkspaces.View = System.Windows.Forms.View.Details;
            // 
            // chWCSId
            // 
            this.chWCSId.Text = "Id";
            this.chWCSId.Width = 274;
            // 
            // chWCSName
            // 
            this.chWCSName.Text = "Name";
            this.chWCSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWCSName.Width = 164;
            // 
            // chWCSLanguage
            // 
            this.chWCSLanguage.Text = "Language";
            this.chWCSLanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWCSLanguage.Width = 75;
            // 
            // chWCSDescription
            // 
            this.chWCSDescription.Text = "Description";
            this.chWCSDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWCSDescription.Width = 303;
            // 
            // chWCSCreated
            // 
            this.chWCSCreated.Text = "Created";
            this.chWCSCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWCSCreated.Width = 165;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.tbRecastConvId);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.tbRecastConvMessage);
            this.tabPage2.Controls.Add(this.btnRecastConversation);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.tbRecastAnalyzeText);
            this.tabPage2.Controls.Add(this.btnRecastAnalyzeText);
            this.tabPage2.Controls.Add(this.cbxRecastExpSelectAll);
            this.tabPage2.Controls.Add(this.btnRecastExpCreate);
            this.tabPage2.Controls.Add(this.btnRecastExpDelete);
            this.tabPage2.Controls.Add(this.btnRecastExpUpdate);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.tbRecastExpLanguage);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.tbRecastExpId);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.tbRecastExpSource);
            this.tabPage2.Controls.Add(this.btnRecastIntentCreate);
            this.tabPage2.Controls.Add(this.btnRecastIntentDelete);
            this.tabPage2.Controls.Add(this.btnRecastIntentUpdate);
            this.tabPage2.Controls.Add(this.btnRecastIntentGet);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.tbRecastIntentDesc);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.tbRecastIntentId);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.tbRecastIntentName);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.tbRecastIntentSlug);
            this.tabPage2.Controls.Add(this.btnRecastBrowseExpFile);
            this.tabPage2.Controls.Add(this.tbRecastLoadExpFilePath);
            this.tabPage2.Controls.Add(this.btnRecastLoadExpressions);
            this.tabPage2.Controls.Add(this.lvRecastIntents);
            this.tabPage2.Controls.Add(this.btnRecastBotUpdate);
            this.tabPage2.Controls.Add(this.cbxRecastBotPublic);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.tbRecastBotStrict);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.tbRecastBotLanguage);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.tbRecastBotDescription);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.tbRecastBotId);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.tbRecastRequestToken);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tbRecastBotDevToken);
            this.tabPage2.Controls.Add(this.lvRecastExpressions);
            this.tabPage2.Controls.Add(this.btnRecastExpressions);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbRecastUser);
            this.tabPage2.Controls.Add(this.lbBotSlug);
            this.tabPage2.Controls.Add(this.tbRecastBotSlug);
            this.tabPage2.Controls.Add(this.btnRecastBotGet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1521, 506);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Recast.AI";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(979, 446);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 13);
            this.label33.TabIndex = 82;
            this.label33.Text = "Id : ";
            // 
            // tbRecastConvId
            // 
            this.tbRecastConvId.Location = new System.Drawing.Point(1011, 439);
            this.tbRecastConvId.Name = "tbRecastConvId";
            this.tbRecastConvId.Size = new System.Drawing.Size(214, 20);
            this.tbRecastConvId.TabIndex = 81;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(951, 468);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 13);
            this.label32.TabIndex = 80;
            this.label32.Text = "Message :";
            // 
            // tbRecastConvMessage
            // 
            this.tbRecastConvMessage.Location = new System.Drawing.Point(1011, 465);
            this.tbRecastConvMessage.Name = "tbRecastConvMessage";
            this.tbRecastConvMessage.Size = new System.Drawing.Size(386, 20);
            this.tbRecastConvMessage.TabIndex = 79;
            // 
            // btnRecastConversation
            // 
            this.btnRecastConversation.Location = new System.Drawing.Point(799, 462);
            this.btnRecastConversation.Name = "btnRecastConversation";
            this.btnRecastConversation.Size = new System.Drawing.Size(134, 23);
            this.btnRecastConversation.TabIndex = 78;
            this.btnRecastConversation.Text = "Conversation";
            this.btnRecastConversation.UseVisualStyleBackColor = true;
            this.btnRecastConversation.Click += new System.EventHandler(this.btnRecastConversation_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(195, 472);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 13);
            this.label31.TabIndex = 77;
            this.label31.Text = "Text : ";
            // 
            // tbRecastAnalyzeText
            // 
            this.tbRecastAnalyzeText.Location = new System.Drawing.Point(239, 469);
            this.tbRecastAnalyzeText.Name = "tbRecastAnalyzeText";
            this.tbRecastAnalyzeText.Size = new System.Drawing.Size(386, 20);
            this.tbRecastAnalyzeText.TabIndex = 76;
            // 
            // btnRecastAnalyzeText
            // 
            this.btnRecastAnalyzeText.Location = new System.Drawing.Point(27, 466);
            this.btnRecastAnalyzeText.Name = "btnRecastAnalyzeText";
            this.btnRecastAnalyzeText.Size = new System.Drawing.Size(134, 23);
            this.btnRecastAnalyzeText.TabIndex = 75;
            this.btnRecastAnalyzeText.Text = "Analyze Text";
            this.btnRecastAnalyzeText.UseVisualStyleBackColor = true;
            this.btnRecastAnalyzeText.Click += new System.EventHandler(this.btnRecastAnalyzeText_Click);
            // 
            // cbxRecastExpSelectAll
            // 
            this.cbxRecastExpSelectAll.AutoSize = true;
            this.cbxRecastExpSelectAll.Location = new System.Drawing.Point(951, 118);
            this.cbxRecastExpSelectAll.Name = "cbxRecastExpSelectAll";
            this.cbxRecastExpSelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbxRecastExpSelectAll.TabIndex = 74;
            this.cbxRecastExpSelectAll.Text = "Select All";
            this.cbxRecastExpSelectAll.UseVisualStyleBackColor = true;
            this.cbxRecastExpSelectAll.CheckedChanged += new System.EventHandler(this.cbxRecastExpSelectAll_CheckedChanged);
            // 
            // btnRecastExpCreate
            // 
            this.btnRecastExpCreate.Location = new System.Drawing.Point(803, 327);
            this.btnRecastExpCreate.Name = "btnRecastExpCreate";
            this.btnRecastExpCreate.Size = new System.Drawing.Size(130, 23);
            this.btnRecastExpCreate.TabIndex = 73;
            this.btnRecastExpCreate.Text = "Create Expression";
            this.btnRecastExpCreate.UseVisualStyleBackColor = true;
            this.btnRecastExpCreate.Click += new System.EventHandler(this.btnRecastExpCreate_Click);
            // 
            // btnRecastExpDelete
            // 
            this.btnRecastExpDelete.Location = new System.Drawing.Point(803, 389);
            this.btnRecastExpDelete.Name = "btnRecastExpDelete";
            this.btnRecastExpDelete.Size = new System.Drawing.Size(130, 23);
            this.btnRecastExpDelete.TabIndex = 72;
            this.btnRecastExpDelete.Text = "Delete Expression";
            this.btnRecastExpDelete.UseVisualStyleBackColor = true;
            this.btnRecastExpDelete.Click += new System.EventHandler(this.btnRecastExpDelete_Click);
            // 
            // btnRecastExpUpdate
            // 
            this.btnRecastExpUpdate.Location = new System.Drawing.Point(803, 359);
            this.btnRecastExpUpdate.Name = "btnRecastExpUpdate";
            this.btnRecastExpUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnRecastExpUpdate.TabIndex = 71;
            this.btnRecastExpUpdate.Text = "Update Expression";
            this.btnRecastExpUpdate.UseVisualStyleBackColor = true;
            this.btnRecastExpUpdate.Click += new System.EventHandler(this.btnRecastExpUpdate_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1214, 366);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 13);
            this.label27.TabIndex = 70;
            this.label27.Text = "Language : ";
            // 
            // tbRecastExpLanguage
            // 
            this.tbRecastExpLanguage.Location = new System.Drawing.Point(1285, 365);
            this.tbRecastExpLanguage.Name = "tbRecastExpLanguage";
            this.tbRecastExpLanguage.Size = new System.Drawing.Size(214, 20);
            this.tbRecastExpLanguage.TabIndex = 69;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(979, 338);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 68;
            this.label23.Text = "Id : ";
            // 
            // tbRecastExpId
            // 
            this.tbRecastExpId.Location = new System.Drawing.Point(1011, 331);
            this.tbRecastExpId.Name = "tbRecastExpId";
            this.tbRecastExpId.Size = new System.Drawing.Size(214, 20);
            this.tbRecastExpId.TabIndex = 67;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1231, 334);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 13);
            this.label24.TabIndex = 66;
            this.label24.Text = "Source : ";
            // 
            // tbRecastExpSource
            // 
            this.tbRecastExpSource.Location = new System.Drawing.Point(1285, 328);
            this.tbRecastExpSource.Name = "tbRecastExpSource";
            this.tbRecastExpSource.Size = new System.Drawing.Size(214, 20);
            this.tbRecastExpSource.TabIndex = 65;
            // 
            // btnRecastIntentCreate
            // 
            this.btnRecastIntentCreate.Location = new System.Drawing.Point(31, 351);
            this.btnRecastIntentCreate.Name = "btnRecastIntentCreate";
            this.btnRecastIntentCreate.Size = new System.Drawing.Size(130, 23);
            this.btnRecastIntentCreate.TabIndex = 64;
            this.btnRecastIntentCreate.Text = "Create Intent";
            this.btnRecastIntentCreate.UseVisualStyleBackColor = true;
            this.btnRecastIntentCreate.Click += new System.EventHandler(this.btnRecastIntentCreate_Click);
            // 
            // btnRecastIntentDelete
            // 
            this.btnRecastIntentDelete.Location = new System.Drawing.Point(31, 413);
            this.btnRecastIntentDelete.Name = "btnRecastIntentDelete";
            this.btnRecastIntentDelete.Size = new System.Drawing.Size(130, 23);
            this.btnRecastIntentDelete.TabIndex = 63;
            this.btnRecastIntentDelete.Text = "Delete Intent";
            this.btnRecastIntentDelete.UseVisualStyleBackColor = true;
            this.btnRecastIntentDelete.Click += new System.EventHandler(this.btnRecastIntentDelete_Click);
            // 
            // btnRecastIntentUpdate
            // 
            this.btnRecastIntentUpdate.Location = new System.Drawing.Point(31, 383);
            this.btnRecastIntentUpdate.Name = "btnRecastIntentUpdate";
            this.btnRecastIntentUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnRecastIntentUpdate.TabIndex = 62;
            this.btnRecastIntentUpdate.Text = "Update Intent";
            this.btnRecastIntentUpdate.UseVisualStyleBackColor = true;
            this.btnRecastIntentUpdate.Click += new System.EventHandler(this.btnRecastIntentUpdate_Click);
            // 
            // btnRecastIntentGet
            // 
            this.btnRecastIntentGet.Location = new System.Drawing.Point(31, 320);
            this.btnRecastIntentGet.Name = "btnRecastIntentGet";
            this.btnRecastIntentGet.Size = new System.Drawing.Size(130, 23);
            this.btnRecastIntentGet.TabIndex = 61;
            this.btnRecastIntentGet.Text = "Get Intent";
            this.btnRecastIntentGet.UseVisualStyleBackColor = true;
            this.btnRecastIntentGet.Click += new System.EventHandler(this.btnRecastIntentGet_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(164, 365);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 60;
            this.label25.Text = "Description : ";
            // 
            // tbRecastIntentDesc
            // 
            this.tbRecastIntentDesc.Location = new System.Drawing.Point(239, 362);
            this.tbRecastIntentDesc.Name = "tbRecastIntentDesc";
            this.tbRecastIntentDesc.Size = new System.Drawing.Size(214, 20);
            this.tbRecastIntentDesc.TabIndex = 59;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(207, 338);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 13);
            this.label26.TabIndex = 58;
            this.label26.Text = "Id : ";
            // 
            // tbRecastIntentId
            // 
            this.tbRecastIntentId.Location = new System.Drawing.Point(239, 331);
            this.tbRecastIntentId.Name = "tbRecastIntentId";
            this.tbRecastIntentId.Size = new System.Drawing.Size(214, 20);
            this.tbRecastIntentId.TabIndex = 57;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(459, 334);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 54;
            this.label28.Text = "Name : ";
            // 
            // tbRecastIntentName
            // 
            this.tbRecastIntentName.Location = new System.Drawing.Point(513, 328);
            this.tbRecastIntentName.Name = "tbRecastIntentName";
            this.tbRecastIntentName.Size = new System.Drawing.Size(214, 20);
            this.tbRecastIntentName.TabIndex = 53;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(459, 362);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 13);
            this.label29.TabIndex = 52;
            this.label29.Text = "Slug : ";
            // 
            // tbRecastIntentSlug
            // 
            this.tbRecastIntentSlug.Location = new System.Drawing.Point(512, 359);
            this.tbRecastIntentSlug.Name = "tbRecastIntentSlug";
            this.tbRecastIntentSlug.Size = new System.Drawing.Size(214, 20);
            this.tbRecastIntentSlug.TabIndex = 51;
            // 
            // btnRecastBrowseExpFile
            // 
            this.btnRecastBrowseExpFile.Location = new System.Drawing.Point(1336, 75);
            this.btnRecastBrowseExpFile.Name = "btnRecastBrowseExpFile";
            this.btnRecastBrowseExpFile.Size = new System.Drawing.Size(88, 23);
            this.btnRecastBrowseExpFile.TabIndex = 50;
            this.btnRecastBrowseExpFile.Text = "Browse";
            this.btnRecastBrowseExpFile.UseVisualStyleBackColor = true;
            this.btnRecastBrowseExpFile.Click += new System.EventHandler(this.btnRecastBrowseExpFile_Click);
            // 
            // tbRecastLoadExpFilePath
            // 
            this.tbRecastLoadExpFilePath.Location = new System.Drawing.Point(951, 75);
            this.tbRecastLoadExpFilePath.Name = "tbRecastLoadExpFilePath";
            this.tbRecastLoadExpFilePath.Size = new System.Drawing.Size(352, 20);
            this.tbRecastLoadExpFilePath.TabIndex = 49;
            // 
            // btnRecastLoadExpressions
            // 
            this.btnRecastLoadExpressions.Location = new System.Drawing.Point(803, 75);
            this.btnRecastLoadExpressions.Name = "btnRecastLoadExpressions";
            this.btnRecastLoadExpressions.Size = new System.Drawing.Size(130, 23);
            this.btnRecastLoadExpressions.TabIndex = 48;
            this.btnRecastLoadExpressions.Text = "Load Expressions";
            this.btnRecastLoadExpressions.UseVisualStyleBackColor = true;
            this.btnRecastLoadExpressions.Click += new System.EventHandler(this.btnRecastLoadExpressions_Click);
            // 
            // lvRecastIntents
            // 
            this.lvRecastIntents.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvRecastIntents.CheckBoxes = true;
            this.lvRecastIntents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRecastIntentId,
            this.chRecastIntentName,
            this.chRecastIntentSlug,
            this.chRecastIntentDesc});
            this.lvRecastIntents.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvRecastIntents.FullRowSelect = true;
            this.lvRecastIntents.GridLines = true;
            this.lvRecastIntents.Location = new System.Drawing.Point(31, 150);
            this.lvRecastIntents.MultiSelect = false;
            this.lvRecastIntents.Name = "lvRecastIntents";
            this.lvRecastIntents.Size = new System.Drawing.Size(695, 162);
            this.lvRecastIntents.TabIndex = 47;
            this.lvRecastIntents.UseCompatibleStateImageBehavior = false;
            this.lvRecastIntents.View = System.Windows.Forms.View.Details;
            // 
            // chRecastIntentId
            // 
            this.chRecastIntentId.Text = "Id";
            this.chRecastIntentId.Width = 216;
            // 
            // chRecastIntentName
            // 
            this.chRecastIntentName.Text = "Name";
            this.chRecastIntentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRecastIntentName.Width = 164;
            // 
            // chRecastIntentSlug
            // 
            this.chRecastIntentSlug.Text = "Slug";
            this.chRecastIntentSlug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRecastIntentSlug.Width = 75;
            // 
            // chRecastIntentDesc
            // 
            this.chRecastIntentDesc.Text = "Description";
            this.chRecastIntentDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRecastIntentDesc.Width = 235;
            // 
            // btnRecastBotUpdate
            // 
            this.btnRecastBotUpdate.Location = new System.Drawing.Point(27, 75);
            this.btnRecastBotUpdate.Name = "btnRecastBotUpdate";
            this.btnRecastBotUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnRecastBotUpdate.TabIndex = 46;
            this.btnRecastBotUpdate.Text = "Update Bot";
            this.btnRecastBotUpdate.UseVisualStyleBackColor = true;
            this.btnRecastBotUpdate.Click += new System.EventHandler(this.btnRecastBotUpdate_Click);
            // 
            // cbxRecastBotPublic
            // 
            this.cbxRecastBotPublic.AutoSize = true;
            this.cbxRecastBotPublic.Location = new System.Drawing.Point(525, 104);
            this.cbxRecastBotPublic.Name = "cbxRecastBotPublic";
            this.cbxRecastBotPublic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxRecastBotPublic.Size = new System.Drawing.Size(61, 17);
            this.cbxRecastBotPublic.TabIndex = 45;
            this.cbxRecastBotPublic.Text = ": Public";
            this.cbxRecastBotPublic.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(170, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "Strictness : ";
            // 
            // tbRecastBotStrict
            // 
            this.tbRecastBotStrict.Location = new System.Drawing.Point(241, 101);
            this.tbRecastBotStrict.Name = "tbRecastBotStrict";
            this.tbRecastBotStrict.Size = new System.Drawing.Size(214, 20);
            this.tbRecastBotStrict.TabIndex = 43;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(500, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Language : ";
            // 
            // tbRecastBotLanguage
            // 
            this.tbRecastBotLanguage.Location = new System.Drawing.Point(571, 77);
            this.tbRecastBotLanguage.Name = "tbRecastBotLanguage";
            this.tbRecastBotLanguage.Size = new System.Drawing.Size(214, 20);
            this.tbRecastBotLanguage.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(166, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Description : ";
            // 
            // tbRecastBotDescription
            // 
            this.tbRecastBotDescription.Location = new System.Drawing.Point(241, 75);
            this.tbRecastBotDescription.Name = "tbRecastBotDescription";
            this.tbRecastBotDescription.Size = new System.Drawing.Size(214, 20);
            this.tbRecastBotDescription.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(209, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Id : ";
            // 
            // tbRecastBotId
            // 
            this.tbRecastBotId.Location = new System.Drawing.Point(240, 45);
            this.tbRecastBotId.Name = "tbRecastBotId";
            this.tbRecastBotId.Size = new System.Drawing.Size(214, 20);
            this.tbRecastBotId.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(474, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Token Request : ";
            // 
            // tbRecastRequestToken
            // 
            this.tbRecastRequestToken.Location = new System.Drawing.Point(570, 48);
            this.tbRecastRequestToken.Name = "tbRecastRequestToken";
            this.tbRecastRequestToken.Size = new System.Drawing.Size(214, 20);
            this.tbRecastRequestToken.TabIndex = 35;
            this.tbRecastRequestToken.Text = "5fbe8ba474fcbc1f0c61d03da65ec274";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(494, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Token Dev : ";
            // 
            // tbRecastBotDevToken
            // 
            this.tbRecastBotDevToken.Location = new System.Drawing.Point(570, 14);
            this.tbRecastBotDevToken.Name = "tbRecastBotDevToken";
            this.tbRecastBotDevToken.Size = new System.Drawing.Size(214, 20);
            this.tbRecastBotDevToken.TabIndex = 33;
            this.tbRecastBotDevToken.Text = "af6a46adce8289f2fdd53aa861057c2c";
            // 
            // lvRecastExpressions
            // 
            this.lvRecastExpressions.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvRecastExpressions.CheckBoxes = true;
            this.lvRecastExpressions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRecastExpId,
            this.chRecastExpSource,
            this.chRecastExpLanguage});
            this.lvRecastExpressions.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvRecastExpressions.FullRowSelect = true;
            this.lvRecastExpressions.GridLines = true;
            this.lvRecastExpressions.Location = new System.Drawing.Point(803, 151);
            this.lvRecastExpressions.MultiSelect = false;
            this.lvRecastExpressions.Name = "lvRecastExpressions";
            this.lvRecastExpressions.Size = new System.Drawing.Size(695, 162);
            this.lvRecastExpressions.TabIndex = 32;
            this.lvRecastExpressions.UseCompatibleStateImageBehavior = false;
            this.lvRecastExpressions.View = System.Windows.Forms.View.Details;
            // 
            // chRecastExpId
            // 
            this.chRecastExpId.Text = "Id";
            this.chRecastExpId.Width = 216;
            // 
            // chRecastExpSource
            // 
            this.chRecastExpSource.Text = "Source";
            this.chRecastExpSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRecastExpSource.Width = 401;
            // 
            // chRecastExpLanguage
            // 
            this.chRecastExpLanguage.Text = "Language";
            this.chRecastExpLanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRecastExpLanguage.Width = 73;
            // 
            // btnRecastExpressions
            // 
            this.btnRecastExpressions.Location = new System.Drawing.Point(803, 113);
            this.btnRecastExpressions.Name = "btnRecastExpressions";
            this.btnRecastExpressions.Size = new System.Drawing.Size(130, 23);
            this.btnRecastExpressions.TabIndex = 27;
            this.btnRecastExpressions.Text = "Get List Expressions";
            this.btnRecastExpressions.UseVisualStyleBackColor = true;
            this.btnRecastExpressions.Click += new System.EventHandler(this.btnRecastExpressions_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "User : ";
            // 
            // tbRecastUser
            // 
            this.tbRecastUser.Location = new System.Drawing.Point(71, 18);
            this.tbRecastUser.Name = "tbRecastUser";
            this.tbRecastUser.Size = new System.Drawing.Size(86, 20);
            this.tbRecastUser.TabIndex = 25;
            this.tbRecastUser.Text = "hicks67";
            // 
            // lbBotSlug
            // 
            this.lbBotSlug.AutoSize = true;
            this.lbBotSlug.Location = new System.Drawing.Point(202, 19);
            this.lbBotSlug.Name = "lbBotSlug";
            this.lbBotSlug.Size = new System.Drawing.Size(37, 13);
            this.lbBotSlug.TabIndex = 24;
            this.lbBotSlug.Text = "Slug : ";
            // 
            // tbRecastBotSlug
            // 
            this.tbRecastBotSlug.Location = new System.Drawing.Point(241, 15);
            this.tbRecastBotSlug.Name = "tbRecastBotSlug";
            this.tbRecastBotSlug.Size = new System.Drawing.Size(214, 20);
            this.tbRecastBotSlug.TabIndex = 23;
            this.tbRecastBotSlug.Text = "food-bot";
            // 
            // btnRecastBotGet
            // 
            this.btnRecastBotGet.Location = new System.Drawing.Point(27, 45);
            this.btnRecastBotGet.Name = "btnRecastBotGet";
            this.btnRecastBotGet.Size = new System.Drawing.Size(130, 23);
            this.btnRecastBotGet.TabIndex = 0;
            this.btnRecastBotGet.Text = "Get Bot";
            this.btnRecastBotGet.UseVisualStyleBackColor = true;
            this.btnRecastBotGet.Click += new System.EventHandler(this.btnRecastAI_Click);
            // 
            // openFileDialogRnRConfigFile
            // 
            this.openFileDialogRnRConfigFile.Filter = "Zip files (*.zip)|*.zip";
            // 
            // openFileDialogRnRIndexFile
            // 
            this.openFileDialogRnRIndexFile.Filter = "Json files (*.json)|*.json";
            // 
            // openFileDialogNLCTrainingFile
            // 
            this.openFileDialogNLCTrainingFile.Filter = "CSV files (*.csv)|*.csv";
            // 
            // btnListServiceInstance
            // 
            this.btnListServiceInstance.Location = new System.Drawing.Point(11, 82);
            this.btnListServiceInstance.Name = "btnListServiceInstance";
            this.btnListServiceInstance.Size = new System.Drawing.Size(142, 23);
            this.btnListServiceInstance.TabIndex = 34;
            this.btnListServiceInstance.Text = "Get List Service Instance";
            this.btnListServiceInstance.UseVisualStyleBackColor = true;
            this.btnListServiceInstance.Click += new System.EventHandler(this.btnListServiceInstance_Click);
            // 
            // btnListApplications
            // 
            this.btnListApplications.Location = new System.Drawing.Point(1055, 87);
            this.btnListApplications.Name = "btnListApplications";
            this.btnListApplications.Size = new System.Drawing.Size(142, 23);
            this.btnListApplications.TabIndex = 35;
            this.btnListApplications.Text = "Get List Applications";
            this.btnListApplications.UseVisualStyleBackColor = true;
            this.btnListApplications.Click += new System.EventHandler(this.btnListApplications_Click);
            // 
            // btnDeleteApplication
            // 
            this.btnDeleteApplication.Location = new System.Drawing.Point(1054, 145);
            this.btnDeleteApplication.Name = "btnDeleteApplication";
            this.btnDeleteApplication.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteApplication.TabIndex = 36;
            this.btnDeleteApplication.Text = "Delete Application";
            this.btnDeleteApplication.UseVisualStyleBackColor = true;
            this.btnDeleteApplication.Click += new System.EventHandler(this.btnDeleteApplication_Click);
            // 
            // btnDeleteServiceInstance
            // 
            this.btnDeleteServiceInstance.Location = new System.Drawing.Point(12, 159);
            this.btnDeleteServiceInstance.Name = "btnDeleteServiceInstance";
            this.btnDeleteServiceInstance.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteServiceInstance.TabIndex = 37;
            this.btnDeleteServiceInstance.Text = "Delete Service Instance";
            this.btnDeleteServiceInstance.UseVisualStyleBackColor = true;
            this.btnDeleteServiceInstance.Click += new System.EventHandler(this.btnDeleteServiceInstance_Click);
            // 
            // btnListServiceKeys
            // 
            this.btnListServiceKeys.Location = new System.Drawing.Point(530, 84);
            this.btnListServiceKeys.Name = "btnListServiceKeys";
            this.btnListServiceKeys.Size = new System.Drawing.Size(142, 23);
            this.btnListServiceKeys.TabIndex = 38;
            this.btnListServiceKeys.Text = "Get List Service Keys";
            this.btnListServiceKeys.UseVisualStyleBackColor = true;
            this.btnListServiceKeys.Click += new System.EventHandler(this.btnListServiceKeys_Click);
            // 
            // btnDeleteServiceKeys
            // 
            this.btnDeleteServiceKeys.Location = new System.Drawing.Point(530, 159);
            this.btnDeleteServiceKeys.Name = "btnDeleteServiceKeys";
            this.btnDeleteServiceKeys.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteServiceKeys.TabIndex = 39;
            this.btnDeleteServiceKeys.Text = "Delete Service Keys";
            this.btnDeleteServiceKeys.UseVisualStyleBackColor = true;
            this.btnDeleteServiceKeys.Click += new System.EventHandler(this.btnDeleteServiceKeys_Click);
            // 
            // cbServiceKeys
            // 
            this.cbServiceKeys.FormattingEnabled = true;
            this.cbServiceKeys.Location = new System.Drawing.Point(793, 86);
            this.cbServiceKeys.Name = "cbServiceKeys";
            this.cbServiceKeys.Size = new System.Drawing.Size(214, 21);
            this.cbServiceKeys.TabIndex = 40;
            this.cbServiceKeys.SelectedIndexChanged += new System.EventHandler(this.cbServiceKeys_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(698, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Service Keys : ";
            // 
            // openFileDialogRnRRankerFile
            // 
            this.openFileDialogRnRRankerFile.Filter = "CSV files (*.csv)|*.csv";
            // 
            // openFileDialogRecastExpFile
            // 
            this.openFileDialogRecastExpFile.Filter = "all files (*.*)|*.*";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(23, 751);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 13);
            this.label30.TabIndex = 42;
            this.label30.Text = "Logs : ";
            // 
            // openFileDialogWCSFilePath
            // 
            this.openFileDialogWCSFilePath.Filter = "Json files (*.json)|*.json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 1045);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbServiceKeys);
            this.Controls.Add(this.btnDeleteServiceKeys);
            this.Controls.Add(this.btnListServiceKeys);
            this.Controls.Add(this.btnDeleteServiceInstance);
            this.Controls.Add(this.btnDeleteApplication);
            this.Controls.Add(this.btnListApplications);
            this.Controls.Add(this.btnListServiceInstance);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbNewSrvKeys);
            this.Controls.Add(this.tbSrvKeysName);
            this.Controls.Add(this.btnNewSrvKeys);
            this.Controls.Add(this.cbServicesPlans);
            this.Controls.Add(this.lbServicePlans);
            this.Controls.Add(this.lbNameSrvInst);
            this.Controls.Add(this.tbNewSrvInst);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnNewSrvInst);
            this.Controls.Add(this.lbServiceInstances);
            this.Controls.Add(this.cbServiceIntances);
            this.Controls.Add(this.lbServices);
            this.Controls.Add(this.cbServices);
            this.Controls.Add(this.lbBuildPack);
            this.Controls.Add(this.cbBuildPack);
            this.Controls.Add(this.lbAppName);
            this.Controls.Add(this.tbAppName);
            this.Controls.Add(this.BtnNewApp);
            this.Controls.Add(this.lbApps);
            this.Controls.Add(this.cbApps);
            this.Controls.Add(this.LbSpaces);
            this.Controls.Add(this.cbSpaces);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LbOrg);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageNLC.ResumeLayout(false);
            this.tabPageNLC.PerformLayout();
            this.tabPageRnR.ResumeLayout(false);
            this.tabPageRnR.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbOrg;
        private System.Windows.Forms.Label LbOrg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbSpaces;
        private System.Windows.Forms.Label LbSpaces;
        private System.Windows.Forms.ComboBox cbApps;
        private System.Windows.Forms.Label lbApps;
        private System.Windows.Forms.Button BtnNewApp;
        private System.Windows.Forms.TextBox tbAppName;
        private System.Windows.Forms.Label lbAppName;
        private System.Windows.Forms.ComboBox cbBuildPack;
        private System.Windows.Forms.Label lbBuildPack;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.Label lbServices;
        private System.Windows.Forms.ComboBox cbServiceIntances;
        private System.Windows.Forms.Label lbServiceInstances;
        private System.Windows.Forms.Button btnNewSrvInst;
        private System.Windows.Forms.Label lbNameSrvInst;
        private System.Windows.Forms.TextBox tbNewSrvInst;
        private System.Windows.Forms.Label lbServicePlans;
        private System.Windows.Forms.ComboBox cbServicesPlans;
        private System.Windows.Forms.Button btnNewSrvKeys;
        private System.Windows.Forms.Label lbNewSrvKeys;
        private System.Windows.Forms.TextBox tbSrvKeysName;
        private System.Windows.Forms.Button btnGetLstClassifier;
        private System.Windows.Forms.ListView lvClassifiers;
        private System.Windows.Forms.ColumnHeader Hid;
        private System.Windows.Forms.ColumnHeader Hname;
        private System.Windows.Forms.ColumnHeader Hcreated;
        private System.Windows.Forms.Button btnNLCTest;
        private System.Windows.Forms.ColumnHeader Hurl;
        private System.Windows.Forms.ColumnHeader Huser;
        private System.Windows.Forms.ColumnHeader Hpwd;
        private System.Windows.Forms.TextBox tbTextClassify;
        private System.Windows.Forms.Button btnChooseFileQuestions;
        private System.Windows.Forms.OpenFileDialog openFileDialogQuestion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNLC;
        private System.Windows.Forms.TabPage tabPageRnR;
        private System.Windows.Forms.ListView lvRnRClusters;
        private System.Windows.Forms.ColumnHeader chRnRClusterId;
        private System.Windows.Forms.ColumnHeader chRnRClusterName;
        private System.Windows.Forms.ColumnHeader chRnRClusterSize;
        private System.Windows.Forms.ColumnHeader chRnRClusterStatus;
        private System.Windows.Forms.Button BtnRnRClusters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRnrClusterSize;
        private System.Windows.Forms.TextBox tbRnrClusterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateRnRCluster;
        private System.Windows.Forms.Button btnDeleteRnRCluster;
        private System.Windows.Forms.Button BtnRnRConfigs;
        private System.Windows.Forms.ComboBox cbRnRConfigs;
        private System.Windows.Forms.Button btnRnRDeleteConfig;
        private System.Windows.Forms.TextBox tbRnRConfigName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRnRCreateConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRnRDeleteCollection;
        private System.Windows.Forms.TextBox tbRnRCollectionName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRnRCreateCollection;
        private System.Windows.Forms.Button btnRnRCollections;
        private System.Windows.Forms.ComboBox cbRnRCollections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRnRQuery;
        private System.Windows.Forms.Button btnRnRBrowseIndexFile;
        private System.Windows.Forms.TextBox tbRnRIndexFilePath;
        private System.Windows.Forms.Button btnRnRQuery;
        private System.Windows.Forms.Button btnRnRIndexing;
        private System.Windows.Forms.Button btnRnRBrowseConfigFile;
        private System.Windows.Forms.TextBox tbRnRConfigFilePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialogRnRConfigFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogRnRIndexFile;
        private System.Windows.Forms.ListView lvRnRRankers;
        private System.Windows.Forms.ColumnHeader chRnRRnakerId;
        private System.Windows.Forms.ColumnHeader chRnRRankerName;
        private System.Windows.Forms.ColumnHeader chRnRRankerCreated;
        private System.Windows.Forms.Button btnRnRRankers;
        private System.Windows.Forms.Button btnNLCDeleteClassifier;
        private System.Windows.Forms.Button btnNLCCreateClassifier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNLCClassifierName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNLCLanguage;
        private System.Windows.Forms.Button btnNLCBrowseTrainingFile;
        private System.Windows.Forms.TextBox tbNLCFilePath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialogNLCTrainingFile;
        private System.Windows.Forms.Button btnListServiceInstance;
        private System.Windows.Forms.Button btnListApplications;
        private System.Windows.Forms.Button btnDeleteApplication;
        private System.Windows.Forms.Button btnDeleteServiceInstance;
        private System.Windows.Forms.Button btnListServiceKeys;
        private System.Windows.Forms.Button btnDeleteServiceKeys;
        private System.Windows.Forms.ComboBox cbServiceKeys;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRnRDeleteRanker;
        private System.Windows.Forms.TextBox tbRnRRankerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRnRCreateRanker;
        private System.Windows.Forms.Button btnRnRBrowseRankerFile;
        private System.Windows.Forms.TextBox tbRnRRankerFilePath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialogRnRRankerFile;
        private System.Windows.Forms.CheckBox cbxRnRRanker;
        private System.Windows.Forms.TextBox tbNLCQuestion;
        private System.Windows.Forms.Button btnNLCClassify;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnListDialogs;
        private System.Windows.Forms.ListView lvDialogs;
        private System.Windows.Forms.ColumnHeader chDialogId;
        private System.Windows.Forms.ColumnHeader chDialogName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRecastBotGet;
        private System.Windows.Forms.ListView lvRecastExpressions;
        private System.Windows.Forms.ColumnHeader chRecastExpId;
        private System.Windows.Forms.ColumnHeader chRecastExpSource;
        private System.Windows.Forms.ColumnHeader chRecastExpLanguage;
        private System.Windows.Forms.Button btnRecastExpressions;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRecastUser;
        private System.Windows.Forms.Label lbBotSlug;
        private System.Windows.Forms.TextBox tbRecastBotSlug;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbRecastBotDevToken;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbRecastRequestToken;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbRecastBotId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbRecastBotDescription;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbRecastBotLanguage;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbRecastBotStrict;
        private System.Windows.Forms.CheckBox cbxRecastBotPublic;
        private System.Windows.Forms.Button btnRecastBotUpdate;
        private System.Windows.Forms.ListView lvRecastIntents;
        private System.Windows.Forms.ColumnHeader chRecastIntentId;
        private System.Windows.Forms.ColumnHeader chRecastIntentName;
        private System.Windows.Forms.ColumnHeader chRecastIntentSlug;
        private System.Windows.Forms.ColumnHeader chRecastIntentDesc;
        private System.Windows.Forms.Button btnRecastBrowseExpFile;
        private System.Windows.Forms.TextBox tbRecastLoadExpFilePath;
        private System.Windows.Forms.Button btnRecastLoadExpressions;
        private System.Windows.Forms.OpenFileDialog openFileDialogRecastExpFile;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbRecastIntentDesc;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbRecastIntentId;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbRecastIntentName;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbRecastIntentSlug;
        private System.Windows.Forms.Button btnRecastIntentCreate;
        private System.Windows.Forms.Button btnRecastIntentDelete;
        private System.Windows.Forms.Button btnRecastIntentUpdate;
        private System.Windows.Forms.Button btnRecastIntentGet;
        private System.Windows.Forms.Button btnRecastExpCreate;
        private System.Windows.Forms.Button btnRecastExpDelete;
        private System.Windows.Forms.Button btnRecastExpUpdate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbRecastExpLanguage;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbRecastExpId;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbRecastExpSource;
        private System.Windows.Forms.CheckBox cbxRecastExpSelectAll;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbRecastAnalyzeText;
        private System.Windows.Forms.Button btnRecastAnalyzeText;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbRecastConvId;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbRecastConvMessage;
        private System.Windows.Forms.Button btnRecastConversation;
        private System.Windows.Forms.Button btnWCSWorkspaceBrowseFile;
        private System.Windows.Forms.TextBox tbWCSWorkspaceFilePath;
        private System.Windows.Forms.Button btnWCSDeleteWorkspace;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cbWCSWorkspaceVersion;
        private System.Windows.Forms.TextBox tbWCSWorkspaceName;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnWCSWorkspaceCreate;
        private System.Windows.Forms.Button btnWCSListWorkspaces;
        private System.Windows.Forms.ListView lvWCSWorkspaces;
        private System.Windows.Forms.ColumnHeader chWCSId;
        private System.Windows.Forms.ColumnHeader chWCSName;
        private System.Windows.Forms.ColumnHeader chWCSLanguage;
        private System.Windows.Forms.ColumnHeader chWCSDescription;
        private System.Windows.Forms.ColumnHeader chWCSCreated;
        private System.Windows.Forms.OpenFileDialog openFileDialogWCSFilePath;
        private System.Windows.Forms.Label label36;
    }
}

