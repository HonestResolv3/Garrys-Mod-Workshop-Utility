namespace GarrysModWorkshopUtility
{
    partial class frmGarrysModWorkshopUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGarrysModWorkshopUtility));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAddonFolderLocation = new System.Windows.Forms.TextBox();
            this.txtIconFolderLocation = new System.Windows.Forms.TextBox();
            this.txtGMadFolderLocation = new System.Windows.Forms.TextBox();
            this.btnFolderLocation = new System.Windows.Forms.Button();
            this.btnIconFolder = new System.Windows.Forms.Button();
            this.btnGmadFolder = new System.Windows.Forms.Button();
            this.txtAddonIDNumber = new System.Windows.Forms.TextBox();
            this.btnAddonID = new System.Windows.Forms.Button();
            this.btnGMALocation = new System.Windows.Forms.Button();
            this.txtGMALocation = new System.Windows.Forms.TextBox();
            this.lblIconPreview = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.timeToStartTask = new System.Windows.Forms.Timer(this.components);
            this.chkAutoRun = new System.Windows.Forms.CheckBox();
            this.chkIgnoreNotices = new System.Windows.Forms.CheckBox();
            this.chkToggleResizing = new System.Windows.Forms.CheckBox();
            this.btnGMAOutput = new System.Windows.Forms.Button();
            this.txtGMAOutput = new System.Windows.Forms.TextBox();
            this.chkEnableAutoDeleteJSON = new System.Windows.Forms.CheckBox();
            this.chkClearText = new System.Windows.Forms.CheckBox();
            this.lblRunTaskTime = new System.Windows.Forms.Label();
            this.lblScriptDelete = new System.Windows.Forms.Label();
            this.lblConsoleText = new System.Windows.Forms.Label();
            this.conControl = new ConsoleControl.ConsoleControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.lblQueueCommandPrompts = new System.Windows.Forms.Label();
            this.lblListOfAddons = new System.Windows.Forms.Label();
            this.lstAddons = new System.Windows.Forms.ListBox();
            this.tmrFillAddons = new System.Windows.Forms.Timer(this.components);
            this.btnLoadAddonList = new System.Windows.Forms.Button();
            this.btnClearAddons = new System.Windows.Forms.Button();
            this.lblListCommands = new System.Windows.Forms.Label();
            this.lblListCommandTop = new System.Windows.Forms.Label();
            this.btnUseAddonID = new System.Windows.Forms.Button();
            this.btnSearchAddon = new System.Windows.Forms.Button();
            this.lblSearchAddon = new System.Windows.Forms.Label();
            this.txtSearchAddon = new System.Windows.Forms.TextBox();
            this.lblLoadingProgress = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.chkUseDefLoc = new System.Windows.Forms.CheckBox();
            this.btnRunQueueCommand = new System.Windows.Forms.Button();
            this.cboxQueueModifyCommands = new System.Windows.Forms.ComboBox();
            this.cboxTimeModifyCommands = new System.Windows.Forms.ComboBox();
            this.btnRunTimeCommand = new System.Windows.Forms.Button();
            this.lblTimeModifyingPrompt = new System.Windows.Forms.Label();
            this.cboxClearCommander = new System.Windows.Forms.ComboBox();
            this.btnRunClearCommand = new System.Windows.Forms.Button();
            this.lblClearingCommandPrompt = new System.Windows.Forms.Label();
            this.cboxMainProgramCommands = new System.Windows.Forms.ComboBox();
            this.btnRunMainProgramCommand = new System.Windows.Forms.Button();
            this.lblMainProgramCommandPrompt = new System.Windows.Forms.Label();
            this.btnDirectoryOfJSon = new System.Windows.Forms.Button();
            this.btnPresetLoader = new System.Windows.Forms.Button();
            this.cboxTaskOptions = new System.Windows.Forms.ComboBox();
            this.lblTaskOptionPrompt = new System.Windows.Forms.Label();
            this.lblToggleSettings = new System.Windows.Forms.Label();
            this.tmrPreventRunningSpam = new System.Windows.Forms.Timer(this.components);
            this.pboxIconPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIconPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(109, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(267, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Program Parameters";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddonFolderLocation
            // 
            this.txtAddonFolderLocation.Location = new System.Drawing.Point(190, 49);
            this.txtAddonFolderLocation.Name = "txtAddonFolderLocation";
            this.txtAddonFolderLocation.Size = new System.Drawing.Size(254, 22);
            this.txtAddonFolderLocation.TabIndex = 2;
            // 
            // txtIconFolderLocation
            // 
            this.txtIconFolderLocation.Location = new System.Drawing.Point(190, 73);
            this.txtIconFolderLocation.Name = "txtIconFolderLocation";
            this.txtIconFolderLocation.Size = new System.Drawing.Size(254, 22);
            this.txtIconFolderLocation.TabIndex = 4;
            // 
            // txtGMadFolderLocation
            // 
            this.txtGMadFolderLocation.Location = new System.Drawing.Point(190, 99);
            this.txtGMadFolderLocation.Name = "txtGMadFolderLocation";
            this.txtGMadFolderLocation.Size = new System.Drawing.Size(254, 22);
            this.txtGMadFolderLocation.TabIndex = 6;
            // 
            // btnFolderLocation
            // 
            this.btnFolderLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFolderLocation.Location = new System.Drawing.Point(22, 48);
            this.btnFolderLocation.Name = "btnFolderLocation";
            this.btnFolderLocation.Size = new System.Drawing.Size(157, 23);
            this.btnFolderLocation.TabIndex = 1;
            this.btnFolderLocation.Text = "Addon Input";
            this.btnFolderLocation.UseVisualStyleBackColor = true;
            this.btnFolderLocation.Click += new System.EventHandler(this.btnFolderLocation_Click);
            // 
            // btnIconFolder
            // 
            this.btnIconFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconFolder.Location = new System.Drawing.Point(22, 73);
            this.btnIconFolder.Name = "btnIconFolder";
            this.btnIconFolder.Size = new System.Drawing.Size(157, 22);
            this.btnIconFolder.TabIndex = 3;
            this.btnIconFolder.Text = "Icon Location";
            this.btnIconFolder.UseVisualStyleBackColor = true;
            this.btnIconFolder.Click += new System.EventHandler(this.btnIconFolder_Click);
            // 
            // btnGmadFolder
            // 
            this.btnGmadFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGmadFolder.Location = new System.Drawing.Point(22, 98);
            this.btnGmadFolder.Name = "btnGmadFolder";
            this.btnGmadFolder.Size = new System.Drawing.Size(157, 24);
            this.btnGmadFolder.TabIndex = 5;
            this.btnGmadFolder.Text = "GMad.EXE Location";
            this.btnGmadFolder.UseVisualStyleBackColor = true;
            this.btnGmadFolder.Click += new System.EventHandler(this.btnGmadFolder_Click);
            // 
            // txtAddonIDNumber
            // 
            this.txtAddonIDNumber.Location = new System.Drawing.Point(190, 177);
            this.txtAddonIDNumber.Name = "txtAddonIDNumber";
            this.txtAddonIDNumber.Size = new System.Drawing.Size(254, 22);
            this.txtAddonIDNumber.TabIndex = 12;
            // 
            // btnAddonID
            // 
            this.btnAddonID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddonID.Location = new System.Drawing.Point(22, 177);
            this.btnAddonID.Name = "btnAddonID";
            this.btnAddonID.Size = new System.Drawing.Size(157, 22);
            this.btnAddonID.TabIndex = 11;
            this.btnAddonID.Text = "Addon ID";
            this.btnAddonID.UseVisualStyleBackColor = true;
            this.btnAddonID.Click += new System.EventHandler(this.btnAddonID_Click);
            // 
            // btnGMALocation
            // 
            this.btnGMALocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGMALocation.Location = new System.Drawing.Point(22, 125);
            this.btnGMALocation.Name = "btnGMALocation";
            this.btnGMALocation.Size = new System.Drawing.Size(157, 23);
            this.btnGMALocation.TabIndex = 7;
            this.btnGMALocation.Text = "GMA Location";
            this.btnGMALocation.UseVisualStyleBackColor = true;
            this.btnGMALocation.Click += new System.EventHandler(this.btnGMALocation_Click);
            // 
            // txtGMALocation
            // 
            this.txtGMALocation.Location = new System.Drawing.Point(190, 126);
            this.txtGMALocation.Name = "txtGMALocation";
            this.txtGMALocation.Size = new System.Drawing.Size(254, 22);
            this.txtGMALocation.TabIndex = 8;
            // 
            // lblIconPreview
            // 
            this.lblIconPreview.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconPreview.Location = new System.Drawing.Point(439, 5);
            this.lblIconPreview.Name = "lblIconPreview";
            this.lblIconPreview.Size = new System.Drawing.Size(209, 43);
            this.lblIconPreview.TabIndex = 40;
            this.lblIconPreview.Text = "Icon Preview";
            this.lblIconPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue
            // 
            this.lblQueue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(833, 2);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(209, 43);
            this.lblQueue.TabIndex = 43;
            this.lblQueue.Text = "Queue";
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstQueue
            // 
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.HorizontalScrollbar = true;
            this.lstQueue.Location = new System.Drawing.Point(638, 47);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(612, 225);
            this.lstQueue.TabIndex = 44;
            // 
            // timeToStartTask
            // 
            this.timeToStartTask.Interval = 60000;
            this.timeToStartTask.Tick += new System.EventHandler(this.timeToStartTask_Tick);
            // 
            // chkAutoRun
            // 
            this.chkAutoRun.AutoSize = true;
            this.chkAutoRun.Location = new System.Drawing.Point(64, 382);
            this.chkAutoRun.Name = "chkAutoRun";
            this.chkAutoRun.Size = new System.Drawing.Size(111, 17);
            this.chkAutoRun.TabIndex = 23;
            this.chkAutoRun.Text = "Auto-Run Tasks?";
            this.chkAutoRun.UseVisualStyleBackColor = true;
            this.chkAutoRun.CheckedChanged += new System.EventHandler(this.chkAutoRun_CheckedChanged);
            // 
            // chkIgnoreNotices
            // 
            this.chkIgnoreNotices.AutoSize = true;
            this.chkIgnoreNotices.Location = new System.Drawing.Point(64, 361);
            this.chkIgnoreNotices.Name = "chkIgnoreNotices";
            this.chkIgnoreNotices.Size = new System.Drawing.Size(152, 17);
            this.chkIgnoreNotices.TabIndex = 22;
            this.chkIgnoreNotices.Text = "Ignore Program Notices?";
            this.chkIgnoreNotices.UseVisualStyleBackColor = true;
            this.chkIgnoreNotices.CheckedChanged += new System.EventHandler(this.chkIgnoreNotices_CheckedChanged);
            // 
            // chkToggleResizing
            // 
            this.chkToggleResizing.AutoSize = true;
            this.chkToggleResizing.Location = new System.Drawing.Point(64, 445);
            this.chkToggleResizing.Name = "chkToggleResizing";
            this.chkToggleResizing.Size = new System.Drawing.Size(112, 17);
            this.chkToggleResizing.TabIndex = 26;
            this.chkToggleResizing.Text = "Enable Resizing?";
            this.chkToggleResizing.UseVisualStyleBackColor = true;
            this.chkToggleResizing.CheckedChanged += new System.EventHandler(this.chkToggleResizing_CheckedChanged);
            // 
            // btnGMAOutput
            // 
            this.btnGMAOutput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGMAOutput.Location = new System.Drawing.Point(22, 151);
            this.btnGMAOutput.Name = "btnGMAOutput";
            this.btnGMAOutput.Size = new System.Drawing.Size(157, 22);
            this.btnGMAOutput.TabIndex = 9;
            this.btnGMAOutput.Text = "GMA Output";
            this.btnGMAOutput.UseVisualStyleBackColor = true;
            this.btnGMAOutput.Click += new System.EventHandler(this.btnGMAOutput_Click);
            // 
            // txtGMAOutput
            // 
            this.txtGMAOutput.Location = new System.Drawing.Point(190, 152);
            this.txtGMAOutput.Name = "txtGMAOutput";
            this.txtGMAOutput.Size = new System.Drawing.Size(254, 22);
            this.txtGMAOutput.TabIndex = 10;
            // 
            // chkEnableAutoDeleteJSON
            // 
            this.chkEnableAutoDeleteJSON.AutoSize = true;
            this.chkEnableAutoDeleteJSON.Location = new System.Drawing.Point(64, 424);
            this.chkEnableAutoDeleteJSON.Name = "chkEnableAutoDeleteJSON";
            this.chkEnableAutoDeleteJSON.Size = new System.Drawing.Size(157, 17);
            this.chkEnableAutoDeleteJSON.TabIndex = 25;
            this.chkEnableAutoDeleteJSON.Text = "Auto-Delete Addon.Json?";
            this.chkEnableAutoDeleteJSON.UseVisualStyleBackColor = true;
            this.chkEnableAutoDeleteJSON.CheckedChanged += new System.EventHandler(this.chkEnableAutoDeleteJSON_CheckedChanged);
            // 
            // chkClearText
            // 
            this.chkClearText.AutoSize = true;
            this.chkClearText.BackColor = System.Drawing.Color.Transparent;
            this.chkClearText.Location = new System.Drawing.Point(64, 403);
            this.chkClearText.Name = "chkClearText";
            this.chkClearText.Size = new System.Drawing.Size(109, 17);
            this.chkClearText.TabIndex = 24;
            this.chkClearText.Text = "Auto-Clear Text?";
            this.chkClearText.UseVisualStyleBackColor = false;
            this.chkClearText.CheckedChanged += new System.EventHandler(this.chkClearText_CheckedChanged);
            // 
            // lblRunTaskTime
            // 
            this.lblRunTaskTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunTaskTime.Location = new System.Drawing.Point(635, 12);
            this.lblRunTaskTime.Name = "lblRunTaskTime";
            this.lblRunTaskTime.Size = new System.Drawing.Size(237, 16);
            this.lblRunTaskTime.TabIndex = 41;
            this.lblRunTaskTime.Text = "Running Each Task: Manually";
            // 
            // lblScriptDelete
            // 
            this.lblScriptDelete.Location = new System.Drawing.Point(635, 29);
            this.lblScriptDelete.Name = "lblScriptDelete";
            this.lblScriptDelete.Size = new System.Drawing.Size(237, 16);
            this.lblScriptDelete.TabIndex = 42;
            this.lblScriptDelete.Text = "Tasks Delete: 0 Seconds Upon Run";
            // 
            // lblConsoleText
            // 
            this.lblConsoleText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsoleText.Location = new System.Drawing.Point(529, 491);
            this.lblConsoleText.Name = "lblConsoleText";
            this.lblConsoleText.Size = new System.Drawing.Size(209, 43);
            this.lblConsoleText.TabIndex = 56;
            this.lblConsoleText.Text = "Output";
            this.lblConsoleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conControl
            // 
            this.conControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.conControl.IsInputEnabled = true;
            this.conControl.Location = new System.Drawing.Point(12, 540);
            this.conControl.Name = "conControl";
            this.conControl.SendKeyboardCommandsToProcess = false;
            this.conControl.ShowDiagnostics = true;
            this.conControl.Size = new System.Drawing.Size(1246, 360);
            this.conControl.TabIndex = 57;
            this.conControl.TabStop = false;
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Location = new System.Drawing.Point(64, 466);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(195, 17);
            this.chkDarkMode.TabIndex = 27;
            this.chkDarkMode.Text = "Enable Experimental Dark Mode?";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // lblQueueCommandPrompts
            // 
            this.lblQueueCommandPrompts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueCommandPrompts.Location = new System.Drawing.Point(316, 237);
            this.lblQueueCommandPrompts.Name = "lblQueueCommandPrompts";
            this.lblQueueCommandPrompts.Size = new System.Drawing.Size(265, 36);
            this.lblQueueCommandPrompts.TabIndex = 28;
            this.lblQueueCommandPrompts.Text = "Queue Commands";
            this.lblQueueCommandPrompts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListOfAddons
            // 
            this.lblListOfAddons.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfAddons.Location = new System.Drawing.Point(746, 273);
            this.lblListOfAddons.Name = "lblListOfAddons";
            this.lblListOfAddons.Size = new System.Drawing.Size(209, 43);
            this.lblListOfAddons.TabIndex = 45;
            this.lblListOfAddons.Text = "Addon List";
            this.lblListOfAddons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstAddons
            // 
            this.lstAddons.FormattingEnabled = true;
            this.lstAddons.HorizontalScrollbar = true;
            this.lstAddons.Location = new System.Drawing.Point(638, 317);
            this.lstAddons.Name = "lstAddons";
            this.lstAddons.Size = new System.Drawing.Size(432, 147);
            this.lstAddons.TabIndex = 47;
            // 
            // tmrFillAddons
            // 
            this.tmrFillAddons.Interval = 1;
            this.tmrFillAddons.Tick += new System.EventHandler(this.tmrFillAddons_Tick);
            // 
            // btnLoadAddonList
            // 
            this.btnLoadAddonList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAddonList.Location = new System.Drawing.Point(1094, 352);
            this.btnLoadAddonList.Name = "btnLoadAddonList";
            this.btnLoadAddonList.Size = new System.Drawing.Size(149, 26);
            this.btnLoadAddonList.TabIndex = 51;
            this.btnLoadAddonList.Text = "Load Addons";
            this.btnLoadAddonList.UseVisualStyleBackColor = true;
            this.btnLoadAddonList.Click += new System.EventHandler(this.btnLoadAddonList_Click);
            // 
            // btnClearAddons
            // 
            this.btnClearAddons.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAddons.Location = new System.Drawing.Point(1094, 464);
            this.btnClearAddons.Name = "btnClearAddons";
            this.btnClearAddons.Size = new System.Drawing.Size(149, 26);
            this.btnClearAddons.TabIndex = 55;
            this.btnClearAddons.Text = "Clear Addon List";
            this.btnClearAddons.UseVisualStyleBackColor = true;
            this.btnClearAddons.Click += new System.EventHandler(this.btnClearAddons_Click);
            // 
            // lblListCommands
            // 
            this.lblListCommands.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCommands.Location = new System.Drawing.Point(1087, 306);
            this.lblListCommands.Name = "lblListCommands";
            this.lblListCommands.Size = new System.Drawing.Size(166, 43);
            this.lblListCommands.TabIndex = 50;
            this.lblListCommands.Text = "Commands";
            this.lblListCommands.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListCommandTop
            // 
            this.lblListCommandTop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCommandTop.Location = new System.Drawing.Point(1128, 276);
            this.lblListCommandTop.Name = "lblListCommandTop";
            this.lblListCommandTop.Size = new System.Drawing.Size(84, 43);
            this.lblListCommandTop.TabIndex = 49;
            this.lblListCommandTop.Text = "List";
            this.lblListCommandTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUseAddonID
            // 
            this.btnUseAddonID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseAddonID.Location = new System.Drawing.Point(1094, 408);
            this.btnUseAddonID.Name = "btnUseAddonID";
            this.btnUseAddonID.Size = new System.Drawing.Size(149, 26);
            this.btnUseAddonID.TabIndex = 53;
            this.btnUseAddonID.Text = "Use Addon ID";
            this.btnUseAddonID.UseVisualStyleBackColor = true;
            this.btnUseAddonID.Click += new System.EventHandler(this.btnUseAddonID_Click);
            // 
            // btnSearchAddon
            // 
            this.btnSearchAddon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAddon.Location = new System.Drawing.Point(1094, 380);
            this.btnSearchAddon.Name = "btnSearchAddon";
            this.btnSearchAddon.Size = new System.Drawing.Size(149, 26);
            this.btnSearchAddon.TabIndex = 52;
            this.btnSearchAddon.Text = "Search Addon";
            this.btnSearchAddon.UseVisualStyleBackColor = true;
            this.btnSearchAddon.Click += new System.EventHandler(this.btnSearchAddon_Click);
            // 
            // lblSearchAddon
            // 
            this.lblSearchAddon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAddon.Location = new System.Drawing.Point(635, 470);
            this.lblSearchAddon.Name = "lblSearchAddon";
            this.lblSearchAddon.Size = new System.Drawing.Size(88, 16);
            this.lblSearchAddon.TabIndex = 50;
            this.lblSearchAddon.Text = "Search Addon:";
            // 
            // txtSearchAddon
            // 
            this.txtSearchAddon.Location = new System.Drawing.Point(720, 467);
            this.txtSearchAddon.Name = "txtSearchAddon";
            this.txtSearchAddon.Size = new System.Drawing.Size(350, 22);
            this.txtSearchAddon.TabIndex = 48;
            // 
            // lblLoadingProgress
            // 
            this.lblLoadingProgress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingProgress.Location = new System.Drawing.Point(636, 297);
            this.lblLoadingProgress.Name = "lblLoadingProgress";
            this.lblLoadingProgress.Size = new System.Drawing.Size(137, 16);
            this.lblLoadingProgress.TabIndex = 46;
            this.lblLoadingProgress.Text = "Addon List Not Loaded";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.Location = new System.Drawing.Point(1094, 436);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(149, 26);
            this.btnClearSearch.TabIndex = 54;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // chkUseDefLoc
            // 
            this.chkUseDefLoc.AutoSize = true;
            this.chkUseDefLoc.Location = new System.Drawing.Point(64, 340);
            this.chkUseDefLoc.Name = "chkUseDefLoc";
            this.chkUseDefLoc.Size = new System.Drawing.Size(178, 17);
            this.chkUseDefLoc.TabIndex = 21;
            this.chkUseDefLoc.Text = "Use Default Location For Exe?";
            this.chkUseDefLoc.UseVisualStyleBackColor = true;
            this.chkUseDefLoc.CheckedChanged += new System.EventHandler(this.chkUseDefLoc_CheckedChanged);
            // 
            // btnRunQueueCommand
            // 
            this.btnRunQueueCommand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQueueCommand.Location = new System.Drawing.Point(455, 273);
            this.btnRunQueueCommand.Name = "btnRunQueueCommand";
            this.btnRunQueueCommand.Size = new System.Drawing.Size(148, 26);
            this.btnRunQueueCommand.TabIndex = 30;
            this.btnRunQueueCommand.Text = "Run Command";
            this.btnRunQueueCommand.UseVisualStyleBackColor = true;
            this.btnRunQueueCommand.Click += new System.EventHandler(this.btnRunQueueCommand_Click);
            // 
            // cboxQueueModifyCommands
            // 
            this.cboxQueueModifyCommands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQueueModifyCommands.FormattingEnabled = true;
            this.cboxQueueModifyCommands.Items.AddRange(new object[] {
            "Add To Queue",
            "Remove From Queue",
            "Remove All From Queue"});
            this.cboxQueueModifyCommands.Location = new System.Drawing.Point(286, 275);
            this.cboxQueueModifyCommands.Name = "cboxQueueModifyCommands";
            this.cboxQueueModifyCommands.Size = new System.Drawing.Size(163, 21);
            this.cboxQueueModifyCommands.TabIndex = 29;
            // 
            // cboxTimeModifyCommands
            // 
            this.cboxTimeModifyCommands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTimeModifyCommands.FormattingEnabled = true;
            this.cboxTimeModifyCommands.Items.AddRange(new object[] {
            "Modify Script Delete Time",
            "Modify Auto-Run Time"});
            this.cboxTimeModifyCommands.Location = new System.Drawing.Point(286, 337);
            this.cboxTimeModifyCommands.Name = "cboxTimeModifyCommands";
            this.cboxTimeModifyCommands.Size = new System.Drawing.Size(163, 21);
            this.cboxTimeModifyCommands.TabIndex = 32;
            // 
            // btnRunTimeCommand
            // 
            this.btnRunTimeCommand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunTimeCommand.Location = new System.Drawing.Point(455, 335);
            this.btnRunTimeCommand.Name = "btnRunTimeCommand";
            this.btnRunTimeCommand.Size = new System.Drawing.Size(148, 26);
            this.btnRunTimeCommand.TabIndex = 33;
            this.btnRunTimeCommand.Text = "Run Command";
            this.btnRunTimeCommand.UseVisualStyleBackColor = true;
            this.btnRunTimeCommand.Click += new System.EventHandler(this.btnRunTimeCommand_Click);
            // 
            // lblTimeModifyingPrompt
            // 
            this.lblTimeModifyingPrompt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeModifyingPrompt.Location = new System.Drawing.Point(316, 299);
            this.lblTimeModifyingPrompt.Name = "lblTimeModifyingPrompt";
            this.lblTimeModifyingPrompt.Size = new System.Drawing.Size(265, 32);
            this.lblTimeModifyingPrompt.TabIndex = 31;
            this.lblTimeModifyingPrompt.Text = "Time Commands";
            this.lblTimeModifyingPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxClearCommander
            // 
            this.cboxClearCommander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClearCommander.FormattingEnabled = true;
            this.cboxClearCommander.Items.AddRange(new object[] {
            "Clear Input",
            "Clear Console"});
            this.cboxClearCommander.Location = new System.Drawing.Point(286, 402);
            this.cboxClearCommander.Name = "cboxClearCommander";
            this.cboxClearCommander.Size = new System.Drawing.Size(163, 21);
            this.cboxClearCommander.TabIndex = 35;
            // 
            // btnRunClearCommand
            // 
            this.btnRunClearCommand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunClearCommand.Location = new System.Drawing.Point(455, 399);
            this.btnRunClearCommand.Name = "btnRunClearCommand";
            this.btnRunClearCommand.Size = new System.Drawing.Size(148, 26);
            this.btnRunClearCommand.TabIndex = 36;
            this.btnRunClearCommand.Text = "Run Command";
            this.btnRunClearCommand.UseVisualStyleBackColor = true;
            this.btnRunClearCommand.Click += new System.EventHandler(this.btnRunClearCommand_Click);
            // 
            // lblClearingCommandPrompt
            // 
            this.lblClearingCommandPrompt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearingCommandPrompt.Location = new System.Drawing.Point(316, 362);
            this.lblClearingCommandPrompt.Name = "lblClearingCommandPrompt";
            this.lblClearingCommandPrompt.Size = new System.Drawing.Size(265, 34);
            this.lblClearingCommandPrompt.TabIndex = 34;
            this.lblClearingCommandPrompt.Text = "Clearing Commands";
            this.lblClearingCommandPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxMainProgramCommands
            // 
            this.cboxMainProgramCommands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMainProgramCommands.FormattingEnabled = true;
            this.cboxMainProgramCommands.Items.AddRange(new object[] {
            "Run Task Manually",
            "View Task History",
            "View Help Page",
            "View About Page",
            "Reset Resizing",
            "Reload Program"});
            this.cboxMainProgramCommands.Location = new System.Drawing.Point(286, 467);
            this.cboxMainProgramCommands.Name = "cboxMainProgramCommands";
            this.cboxMainProgramCommands.Size = new System.Drawing.Size(163, 21);
            this.cboxMainProgramCommands.TabIndex = 38;
            // 
            // btnRunMainProgramCommand
            // 
            this.btnRunMainProgramCommand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunMainProgramCommand.Location = new System.Drawing.Point(455, 465);
            this.btnRunMainProgramCommand.Name = "btnRunMainProgramCommand";
            this.btnRunMainProgramCommand.Size = new System.Drawing.Size(148, 26);
            this.btnRunMainProgramCommand.TabIndex = 39;
            this.btnRunMainProgramCommand.Text = "Run Command";
            this.btnRunMainProgramCommand.UseVisualStyleBackColor = true;
            this.btnRunMainProgramCommand.Click += new System.EventHandler(this.btnRunMainProgramCommand_Click);
            // 
            // lblMainProgramCommandPrompt
            // 
            this.lblMainProgramCommandPrompt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainProgramCommandPrompt.Location = new System.Drawing.Point(296, 427);
            this.lblMainProgramCommandPrompt.Name = "lblMainProgramCommandPrompt";
            this.lblMainProgramCommandPrompt.Size = new System.Drawing.Size(304, 34);
            this.lblMainProgramCommandPrompt.TabIndex = 37;
            this.lblMainProgramCommandPrompt.Text = "Main Program Commands";
            this.lblMainProgramCommandPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDirectoryOfJSon
            // 
            this.btnDirectoryOfJSon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectoryOfJSon.Location = new System.Drawing.Point(54, 205);
            this.btnDirectoryOfJSon.Name = "btnDirectoryOfJSon";
            this.btnDirectoryOfJSon.Size = new System.Drawing.Size(179, 22);
            this.btnDirectoryOfJSon.TabIndex = 13;
            this.btnDirectoryOfJSon.Text = "JSON Creation Loader";
            this.btnDirectoryOfJSon.UseVisualStyleBackColor = true;
            this.btnDirectoryOfJSon.Click += new System.EventHandler(this.btnDirectoryOfJSon_Click);
            // 
            // btnPresetLoader
            // 
            this.btnPresetLoader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresetLoader.Location = new System.Drawing.Point(238, 205);
            this.btnPresetLoader.Name = "btnPresetLoader";
            this.btnPresetLoader.Size = new System.Drawing.Size(179, 22);
            this.btnPresetLoader.TabIndex = 14;
            this.btnPresetLoader.Text = "Preset Creation Loader";
            this.btnPresetLoader.UseVisualStyleBackColor = true;
            this.btnPresetLoader.Click += new System.EventHandler(this.btnPresetLoader_Click);
            // 
            // cboxTaskOptions
            // 
            this.cboxTaskOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTaskOptions.DropDownWidth = 153;
            this.cboxTaskOptions.FormattingEnabled = true;
            this.cboxTaskOptions.Items.AddRange(new object[] {
            "Create .GMA",
            "Extract .GMA",
            "Publish Addon",
            "Update Addon",
            "Update Icon"});
            this.cboxTaskOptions.Location = new System.Drawing.Point(23, 275);
            this.cboxTaskOptions.Name = "cboxTaskOptions";
            this.cboxTaskOptions.Size = new System.Drawing.Size(253, 21);
            this.cboxTaskOptions.TabIndex = 59;
            this.cboxTaskOptions.SelectedIndexChanged += new System.EventHandler(this.cboxTaskOptions_SelectedIndexChanged);
            // 
            // lblTaskOptionPrompt
            // 
            this.lblTaskOptionPrompt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskOptionPrompt.Location = new System.Drawing.Point(69, 237);
            this.lblTaskOptionPrompt.Name = "lblTaskOptionPrompt";
            this.lblTaskOptionPrompt.Size = new System.Drawing.Size(169, 36);
            this.lblTaskOptionPrompt.TabIndex = 58;
            this.lblTaskOptionPrompt.Text = "Task Options";
            this.lblTaskOptionPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToggleSettings
            // 
            this.lblToggleSettings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleSettings.Location = new System.Drawing.Point(69, 299);
            this.lblToggleSettings.Name = "lblToggleSettings";
            this.lblToggleSettings.Size = new System.Drawing.Size(169, 36);
            this.lblToggleSettings.TabIndex = 60;
            this.lblToggleSettings.Text = "Settings";
            this.lblToggleSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrPreventRunningSpam
            // 
            this.tmrPreventRunningSpam.Interval = 3000;
            // 
            // pboxIconPreview
            // 
            this.pboxIconPreview.Image = global::GarrysModWorkshopUtil.Properties.Resources.noimagefound;
            this.pboxIconPreview.Location = new System.Drawing.Point(468, 48);
            this.pboxIconPreview.Name = "pboxIconPreview";
            this.pboxIconPreview.Size = new System.Drawing.Size(147, 152);
            this.pboxIconPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxIconPreview.TabIndex = 26;
            this.pboxIconPreview.TabStop = false;
            // 
            // frmGarrysModWorkshopUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1270, 909);
            this.Controls.Add(this.lblToggleSettings);
            this.Controls.Add(this.cboxTaskOptions);
            this.Controls.Add(this.lblTaskOptionPrompt);
            this.Controls.Add(this.btnPresetLoader);
            this.Controls.Add(this.cboxMainProgramCommands);
            this.Controls.Add(this.btnRunMainProgramCommand);
            this.Controls.Add(this.lblMainProgramCommandPrompt);
            this.Controls.Add(this.cboxClearCommander);
            this.Controls.Add(this.btnRunClearCommand);
            this.Controls.Add(this.lblClearingCommandPrompt);
            this.Controls.Add(this.cboxTimeModifyCommands);
            this.Controls.Add(this.btnRunTimeCommand);
            this.Controls.Add(this.lblTimeModifyingPrompt);
            this.Controls.Add(this.cboxQueueModifyCommands);
            this.Controls.Add(this.chkUseDefLoc);
            this.Controls.Add(this.btnRunQueueCommand);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.lblLoadingProgress);
            this.Controls.Add(this.txtSearchAddon);
            this.Controls.Add(this.lblSearchAddon);
            this.Controls.Add(this.btnSearchAddon);
            this.Controls.Add(this.btnUseAddonID);
            this.Controls.Add(this.lblListCommandTop);
            this.Controls.Add(this.lblListCommands);
            this.Controls.Add(this.btnClearAddons);
            this.Controls.Add(this.btnLoadAddonList);
            this.Controls.Add(this.lblListOfAddons);
            this.Controls.Add(this.lstAddons);
            this.Controls.Add(this.lblQueueCommandPrompts);
            this.Controls.Add(this.chkDarkMode);
            this.Controls.Add(this.conControl);
            this.Controls.Add(this.lblConsoleText);
            this.Controls.Add(this.lblScriptDelete);
            this.Controls.Add(this.lblRunTaskTime);
            this.Controls.Add(this.chkClearText);
            this.Controls.Add(this.chkEnableAutoDeleteJSON);
            this.Controls.Add(this.btnGMAOutput);
            this.Controls.Add(this.txtGMAOutput);
            this.Controls.Add(this.chkToggleResizing);
            this.Controls.Add(this.chkIgnoreNotices);
            this.Controls.Add(this.chkAutoRun);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.lstQueue);
            this.Controls.Add(this.pboxIconPreview);
            this.Controls.Add(this.lblIconPreview);
            this.Controls.Add(this.btnGMALocation);
            this.Controls.Add(this.txtGMALocation);
            this.Controls.Add(this.btnDirectoryOfJSon);
            this.Controls.Add(this.btnAddonID);
            this.Controls.Add(this.txtAddonIDNumber);
            this.Controls.Add(this.btnGmadFolder);
            this.Controls.Add(this.btnIconFolder);
            this.Controls.Add(this.btnFolderLocation);
            this.Controls.Add(this.txtGMadFolderLocation);
            this.Controls.Add(this.txtIconFolderLocation);
            this.Controls.Add(this.txtAddonFolderLocation);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGarrysModWorkshopUtility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garry\'s Mod Workshop Utility | By DefyTheRush";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGarrysModWorkshopUtility_FormClosing);
            this.Load += new System.EventHandler(this.frmGarrysModWorkshopUtility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxIconPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFolderLocation;
        private System.Windows.Forms.Button btnIconFolder;
        private System.Windows.Forms.Button btnGmadFolder;
        private System.Windows.Forms.Button btnAddonID;
        private System.Windows.Forms.Button btnGMALocation;
        private System.Windows.Forms.Label lblIconPreview;
        private System.Windows.Forms.PictureBox pboxIconPreview;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Timer timeToStartTask;
        private System.Windows.Forms.CheckBox chkAutoRun;
        private System.Windows.Forms.CheckBox chkIgnoreNotices;
        private System.Windows.Forms.CheckBox chkToggleResizing;
        private System.Windows.Forms.Button btnGMAOutput;
        private System.Windows.Forms.CheckBox chkEnableAutoDeleteJSON;
        private System.Windows.Forms.CheckBox chkClearText;
        private System.Windows.Forms.Label lblRunTaskTime;
        private System.Windows.Forms.Label lblScriptDelete;
        private System.Windows.Forms.Label lblConsoleText;
        private ConsoleControl.ConsoleControl conControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.Label lblQueueCommandPrompts;
        private System.Windows.Forms.Label lblListOfAddons;
        private System.Windows.Forms.ListBox lstAddons;
        private System.Windows.Forms.Timer tmrFillAddons;
        private System.Windows.Forms.Button btnLoadAddonList;
        private System.Windows.Forms.Button btnClearAddons;
        private System.Windows.Forms.Label lblListCommands;
        private System.Windows.Forms.Label lblListCommandTop;
        private System.Windows.Forms.Button btnUseAddonID;
        private System.Windows.Forms.Button btnSearchAddon;
        private System.Windows.Forms.Label lblSearchAddon;
        private System.Windows.Forms.TextBox txtSearchAddon;
        private System.Windows.Forms.Label lblLoadingProgress;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.CheckBox chkUseDefLoc;
        private System.Windows.Forms.Button btnRunQueueCommand;
        private System.Windows.Forms.ComboBox cboxQueueModifyCommands;
        private System.Windows.Forms.ComboBox cboxTimeModifyCommands;
        private System.Windows.Forms.Button btnRunTimeCommand;
        private System.Windows.Forms.Label lblTimeModifyingPrompt;
        private System.Windows.Forms.ComboBox cboxClearCommander;
        private System.Windows.Forms.Button btnRunClearCommand;
        private System.Windows.Forms.Label lblClearingCommandPrompt;
        private System.Windows.Forms.ComboBox cboxMainProgramCommands;
        private System.Windows.Forms.Button btnRunMainProgramCommand;
        private System.Windows.Forms.Label lblMainProgramCommandPrompt;
        private System.Windows.Forms.Button btnDirectoryOfJSon;
        public System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.Button btnPresetLoader;
        private System.Windows.Forms.TextBox txtAddonFolderLocation;
        private System.Windows.Forms.TextBox txtIconFolderLocation;
        private System.Windows.Forms.TextBox txtGMadFolderLocation;
        private System.Windows.Forms.TextBox txtAddonIDNumber;
        private System.Windows.Forms.TextBox txtGMALocation;
        private System.Windows.Forms.TextBox txtGMAOutput;
        private System.Windows.Forms.ComboBox cboxTaskOptions;
        private System.Windows.Forms.Label lblTaskOptionPrompt;
        private System.Windows.Forms.Label lblToggleSettings;
        private System.Windows.Forms.Timer tmrPreventRunningSpam;
    }
}
