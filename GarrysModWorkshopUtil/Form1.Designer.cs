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
            this.radPublishAddon = new System.Windows.Forms.RadioButton();
            this.radUpdateAddon = new System.Windows.Forms.RadioButton();
            this.radCreateGma = new System.Windows.Forms.RadioButton();
            this.radUpdateIcon = new System.Windows.Forms.RadioButton();
            this.lblUtilityOptions = new System.Windows.Forms.Label();
            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.txtAddonFolderLocation = new System.Windows.Forms.TextBox();
            this.txtIconFolderLocation = new System.Windows.Forms.TextBox();
            this.txtGMadFolderLocation = new System.Windows.Forms.TextBox();
            this.btnFolderLocation = new System.Windows.Forms.Button();
            this.btnIconFolder = new System.Windows.Forms.Button();
            this.btnGmadFolder = new System.Windows.Forms.Button();
            this.txtAddonIDNumber = new System.Windows.Forms.TextBox();
            this.btnAddonID = new System.Windows.Forms.Button();
            this.btnClearTextBoxes = new System.Windows.Forms.Button();
            this.btnHelpPage = new System.Windows.Forms.Button();
            this.btnDirectoryOfJSon = new System.Windows.Forms.Button();
            this.txtDirectoryOfJSon = new System.Windows.Forms.TextBox();
            this.radCreateJSon = new System.Windows.Forms.RadioButton();
            this.btnGMALocation = new System.Windows.Forms.Button();
            this.txtGMALocation = new System.Windows.Forms.TextBox();
            this.lblIconPreview = new System.Windows.Forms.Label();
            this.radExtractGMA = new System.Windows.Forms.RadioButton();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.btnRemoveFromQueue = new System.Windows.Forms.Button();
            this.btnRunTask = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.timeToStartTask = new System.Windows.Forms.Timer(this.components);
            this.chkAutoRun = new System.Windows.Forms.CheckBox();
            this.btnModifyTimer = new System.Windows.Forms.Button();
            this.chkIgnoreNotices = new System.Windows.Forms.CheckBox();
            this.pboxIconPreview = new System.Windows.Forms.PictureBox();
            this.chkToggleResizing = new System.Windows.Forms.CheckBox();
            this.btnResetResizePosition = new System.Windows.Forms.Button();
            this.btnGMAOutput = new System.Windows.Forms.Button();
            this.txtGMAOutput = new System.Windows.Forms.TextBox();
            this.chkEnableAutoDeleteJSON = new System.Windows.Forms.CheckBox();
            this.chkClearText = new System.Windows.Forms.CheckBox();
            this.lblRunTaskTime = new System.Windows.Forms.Label();
            this.btnModifyScriptTime = new System.Windows.Forms.Button();
            this.lblScriptDelete = new System.Windows.Forms.Label();
            this.lblConsoleText = new System.Windows.Forms.Label();
            this.conControl = new ConsoleControl.ConsoleControl();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.lblCommandPrompts = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pboxIconPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(109, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(267, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Program Parameters";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radPublishAddon
            // 
            this.radPublishAddon.AutoSize = true;
            this.radPublishAddon.Location = new System.Drawing.Point(165, 315);
            this.radPublishAddon.Name = "radPublishAddon";
            this.radPublishAddon.Size = new System.Drawing.Size(101, 17);
            this.radPublishAddon.TabIndex = 19;
            this.radPublishAddon.Text = "Publish Addon";
            this.radPublishAddon.UseVisualStyleBackColor = true;
            this.radPublishAddon.CheckedChanged += new System.EventHandler(this.radPublishAddon_CheckedChanged);
            // 
            // radUpdateAddon
            // 
            this.radUpdateAddon.AutoSize = true;
            this.radUpdateAddon.Location = new System.Drawing.Point(44, 338);
            this.radUpdateAddon.Name = "radUpdateAddon";
            this.radUpdateAddon.Size = new System.Drawing.Size(101, 17);
            this.radUpdateAddon.TabIndex = 20;
            this.radUpdateAddon.Text = "Update Addon";
            this.radUpdateAddon.UseVisualStyleBackColor = true;
            this.radUpdateAddon.CheckedChanged += new System.EventHandler(this.radUpdateAddon_CheckedChanged);
            // 
            // radCreateGma
            // 
            this.radCreateGma.AutoSize = true;
            this.radCreateGma.Checked = true;
            this.radCreateGma.Location = new System.Drawing.Point(44, 291);
            this.radCreateGma.Name = "radCreateGma";
            this.radCreateGma.Size = new System.Drawing.Size(89, 17);
            this.radCreateGma.TabIndex = 16;
            this.radCreateGma.TabStop = true;
            this.radCreateGma.Text = "Create .GMA";
            this.radCreateGma.UseVisualStyleBackColor = true;
            this.radCreateGma.CheckedChanged += new System.EventHandler(this.radCreateGma_CheckedChanged);
            // 
            // radUpdateIcon
            // 
            this.radUpdateIcon.AutoSize = true;
            this.radUpdateIcon.Location = new System.Drawing.Point(165, 338);
            this.radUpdateIcon.Name = "radUpdateIcon";
            this.radUpdateIcon.Size = new System.Drawing.Size(88, 17);
            this.radUpdateIcon.TabIndex = 21;
            this.radUpdateIcon.Text = "Update Icon";
            this.radUpdateIcon.UseVisualStyleBackColor = true;
            this.radUpdateIcon.CheckedChanged += new System.EventHandler(this.radUpdateIcon_CheckedChanged);
            // 
            // lblUtilityOptions
            // 
            this.lblUtilityOptions.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilityOptions.Location = new System.Drawing.Point(48, 246);
            this.lblUtilityOptions.Name = "lblUtilityOptions";
            this.lblUtilityOptions.Size = new System.Drawing.Size(209, 43);
            this.lblUtilityOptions.TabIndex = 15;
            this.lblUtilityOptions.Text = "Utility Options";
            this.lblUtilityOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToQueue.Location = new System.Drawing.Point(289, 294);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(149, 26);
            this.btnAddToQueue.TabIndex = 29;
            this.btnAddToQueue.Text = "Add To Queue";
            this.btnAddToQueue.UseVisualStyleBackColor = true;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);
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
            this.txtIconFolderLocation.Location = new System.Drawing.Point(190, 98);
            this.txtIconFolderLocation.Name = "txtIconFolderLocation";
            this.txtIconFolderLocation.Size = new System.Drawing.Size(254, 22);
            this.txtIconFolderLocation.TabIndex = 6;
            // 
            // txtGMadFolderLocation
            // 
            this.txtGMadFolderLocation.Location = new System.Drawing.Point(190, 124);
            this.txtGMadFolderLocation.Name = "txtGMadFolderLocation";
            this.txtGMadFolderLocation.Size = new System.Drawing.Size(254, 22);
            this.txtGMadFolderLocation.TabIndex = 8;
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
            this.btnIconFolder.Location = new System.Drawing.Point(22, 98);
            this.btnIconFolder.Name = "btnIconFolder";
            this.btnIconFolder.Size = new System.Drawing.Size(157, 22);
            this.btnIconFolder.TabIndex = 5;
            this.btnIconFolder.Text = "Icon Location";
            this.btnIconFolder.UseVisualStyleBackColor = true;
            this.btnIconFolder.Click += new System.EventHandler(this.btnIconFolder_Click);
            // 
            // btnGmadFolder
            // 
            this.btnGmadFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGmadFolder.Location = new System.Drawing.Point(22, 123);
            this.btnGmadFolder.Name = "btnGmadFolder";
            this.btnGmadFolder.Size = new System.Drawing.Size(157, 24);
            this.btnGmadFolder.TabIndex = 7;
            this.btnGmadFolder.Text = "GMad.EXE Location";
            this.btnGmadFolder.UseVisualStyleBackColor = true;
            this.btnGmadFolder.Click += new System.EventHandler(this.btnGmadFolder_Click);
            // 
            // txtAddonIDNumber
            // 
            this.txtAddonIDNumber.Location = new System.Drawing.Point(190, 202);
            this.txtAddonIDNumber.Name = "txtAddonIDNumber";
            this.txtAddonIDNumber.Size = new System.Drawing.Size(254, 22);
            this.txtAddonIDNumber.TabIndex = 14;
            // 
            // btnAddonID
            // 
            this.btnAddonID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddonID.Location = new System.Drawing.Point(22, 202);
            this.btnAddonID.Name = "btnAddonID";
            this.btnAddonID.Size = new System.Drawing.Size(157, 22);
            this.btnAddonID.TabIndex = 13;
            this.btnAddonID.Text = "Addon ID";
            this.btnAddonID.UseVisualStyleBackColor = true;
            this.btnAddonID.Click += new System.EventHandler(this.btnAddonID_Click);
            // 
            // btnClearTextBoxes
            // 
            this.btnClearTextBoxes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTextBoxes.Location = new System.Drawing.Point(289, 353);
            this.btnClearTextBoxes.Name = "btnClearTextBoxes";
            this.btnClearTextBoxes.Size = new System.Drawing.Size(149, 26);
            this.btnClearTextBoxes.TabIndex = 33;
            this.btnClearTextBoxes.Text = "Clear Input";
            this.btnClearTextBoxes.UseVisualStyleBackColor = true;
            this.btnClearTextBoxes.Click += new System.EventHandler(this.btnClearTextBoxes_Click);
            // 
            // btnHelpPage
            // 
            this.btnHelpPage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpPage.Location = new System.Drawing.Point(443, 415);
            this.btnHelpPage.Name = "btnHelpPage";
            this.btnHelpPage.Size = new System.Drawing.Size(148, 26);
            this.btnHelpPage.TabIndex = 38;
            this.btnHelpPage.Text = "Help";
            this.btnHelpPage.UseVisualStyleBackColor = true;
            this.btnHelpPage.Click += new System.EventHandler(this.btnHelpPage_Click);
            // 
            // btnDirectoryOfJSon
            // 
            this.btnDirectoryOfJSon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectoryOfJSon.Location = new System.Drawing.Point(22, 73);
            this.btnDirectoryOfJSon.Name = "btnDirectoryOfJSon";
            this.btnDirectoryOfJSon.Size = new System.Drawing.Size(157, 22);
            this.btnDirectoryOfJSon.TabIndex = 3;
            this.btnDirectoryOfJSon.Text = "JSON Output";
            this.btnDirectoryOfJSon.UseVisualStyleBackColor = true;
            this.btnDirectoryOfJSon.Click += new System.EventHandler(this.btnDirectoryOfJSon_Click);
            // 
            // txtDirectoryOfJSon
            // 
            this.txtDirectoryOfJSon.Location = new System.Drawing.Point(190, 73);
            this.txtDirectoryOfJSon.Name = "txtDirectoryOfJSon";
            this.txtDirectoryOfJSon.Size = new System.Drawing.Size(254, 22);
            this.txtDirectoryOfJSon.TabIndex = 4;
            // 
            // radCreateJSon
            // 
            this.radCreateJSon.AutoSize = true;
            this.radCreateJSon.Location = new System.Drawing.Point(165, 291);
            this.radCreateJSon.Name = "radCreateJSon";
            this.radCreateJSon.Size = new System.Drawing.Size(91, 17);
            this.radCreateJSon.TabIndex = 17;
            this.radCreateJSon.Text = "Create .JSON";
            this.radCreateJSon.UseVisualStyleBackColor = true;
            this.radCreateJSon.CheckedChanged += new System.EventHandler(this.radCreateJSon_CheckedChanged);
            // 
            // btnGMALocation
            // 
            this.btnGMALocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGMALocation.Location = new System.Drawing.Point(22, 150);
            this.btnGMALocation.Name = "btnGMALocation";
            this.btnGMALocation.Size = new System.Drawing.Size(157, 23);
            this.btnGMALocation.TabIndex = 9;
            this.btnGMALocation.Text = "GMA Location";
            this.btnGMALocation.UseVisualStyleBackColor = true;
            this.btnGMALocation.Click += new System.EventHandler(this.btnGMALocation_Click);
            // 
            // txtGMALocation
            // 
            this.txtGMALocation.Location = new System.Drawing.Point(190, 151);
            this.txtGMALocation.Name = "txtGMALocation";
            this.txtGMALocation.Size = new System.Drawing.Size(254, 22);
            this.txtGMALocation.TabIndex = 10;
            // 
            // lblIconPreview
            // 
            this.lblIconPreview.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconPreview.Location = new System.Drawing.Point(439, 2);
            this.lblIconPreview.Name = "lblIconPreview";
            this.lblIconPreview.Size = new System.Drawing.Size(209, 43);
            this.lblIconPreview.TabIndex = 25;
            this.lblIconPreview.Text = "Icon Preview";
            this.lblIconPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radExtractGMA
            // 
            this.radExtractGMA.AutoSize = true;
            this.radExtractGMA.Location = new System.Drawing.Point(44, 315);
            this.radExtractGMA.Name = "radExtractGMA";
            this.radExtractGMA.Size = new System.Drawing.Size(90, 17);
            this.radExtractGMA.TabIndex = 18;
            this.radExtractGMA.Text = "Extract .GMA";
            this.radExtractGMA.UseVisualStyleBackColor = true;
            this.radExtractGMA.CheckedChanged += new System.EventHandler(this.radExtractGMA_CheckedChanged);
            // 
            // lblQueue
            // 
            this.lblQueue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(833, 2);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(209, 43);
            this.lblQueue.TabIndex = 41;
            this.lblQueue.Text = "Queue";
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstQueue
            // 
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.HorizontalScrollbar = true;
            this.lstQueue.Location = new System.Drawing.Point(638, 48);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(612, 199);
            this.lstQueue.TabIndex = 42;
            // 
            // btnRemoveFromQueue
            // 
            this.btnRemoveFromQueue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromQueue.Location = new System.Drawing.Point(443, 294);
            this.btnRemoveFromQueue.Name = "btnRemoveFromQueue";
            this.btnRemoveFromQueue.Size = new System.Drawing.Size(148, 26);
            this.btnRemoveFromQueue.TabIndex = 30;
            this.btnRemoveFromQueue.Text = "Remove From Queue";
            this.btnRemoveFromQueue.UseVisualStyleBackColor = true;
            this.btnRemoveFromQueue.Click += new System.EventHandler(this.btnRemoveFromQueue_Click);
            // 
            // btnRunTask
            // 
            this.btnRunTask.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunTask.Location = new System.Drawing.Point(443, 384);
            this.btnRunTask.Name = "btnRunTask";
            this.btnRunTask.Size = new System.Drawing.Size(148, 26);
            this.btnRunTask.TabIndex = 36;
            this.btnRunTask.Text = "Run Task Manually";
            this.btnRunTask.UseVisualStyleBackColor = true;
            this.btnRunTask.Click += new System.EventHandler(this.btnRunTask_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(290, 415);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(148, 26);
            this.btnAbout.TabIndex = 37;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // timeToStartTask
            // 
            this.timeToStartTask.Interval = 60000;
            this.timeToStartTask.Tick += new System.EventHandler(this.timeToStartTask_Tick);
            // 
            // chkAutoRun
            // 
            this.chkAutoRun.AutoSize = true;
            this.chkAutoRun.Location = new System.Drawing.Point(76, 385);
            this.chkAutoRun.Name = "chkAutoRun";
            this.chkAutoRun.Size = new System.Drawing.Size(111, 17);
            this.chkAutoRun.TabIndex = 23;
            this.chkAutoRun.Text = "Auto-Run Tasks?";
            this.chkAutoRun.UseVisualStyleBackColor = true;
            this.chkAutoRun.CheckedChanged += new System.EventHandler(this.chkAutoRun_CheckedChanged);
            // 
            // btnModifyTimer
            // 
            this.btnModifyTimer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyTimer.Location = new System.Drawing.Point(442, 323);
            this.btnModifyTimer.Name = "btnModifyTimer";
            this.btnModifyTimer.Size = new System.Drawing.Size(149, 26);
            this.btnModifyTimer.TabIndex = 31;
            this.btnModifyTimer.Text = "Modify Auto-Run Time";
            this.btnModifyTimer.UseVisualStyleBackColor = true;
            this.btnModifyTimer.Click += new System.EventHandler(this.btnModifyTimer_Click);
            // 
            // chkIgnoreNotices
            // 
            this.chkIgnoreNotices.AutoSize = true;
            this.chkIgnoreNotices.Location = new System.Drawing.Point(76, 364);
            this.chkIgnoreNotices.Name = "chkIgnoreNotices";
            this.chkIgnoreNotices.Size = new System.Drawing.Size(152, 17);
            this.chkIgnoreNotices.TabIndex = 22;
            this.chkIgnoreNotices.Text = "Ignore Program Notices?";
            this.chkIgnoreNotices.UseVisualStyleBackColor = true;
            this.chkIgnoreNotices.CheckedChanged += new System.EventHandler(this.chkIgnoreNotices_CheckedChanged);
            // 
            // pboxIconPreview
            // 
            this.pboxIconPreview.Image = global::GarrysModWorkshopUtil.Properties.Resources.noimagefound;
            this.pboxIconPreview.Location = new System.Drawing.Point(468, 64);
            this.pboxIconPreview.Name = "pboxIconPreview";
            this.pboxIconPreview.Size = new System.Drawing.Size(147, 152);
            this.pboxIconPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxIconPreview.TabIndex = 26;
            this.pboxIconPreview.TabStop = false;
            // 
            // chkToggleResizing
            // 
            this.chkToggleResizing.AutoSize = true;
            this.chkToggleResizing.Location = new System.Drawing.Point(76, 470);
            this.chkToggleResizing.Name = "chkToggleResizing";
            this.chkToggleResizing.Size = new System.Drawing.Size(181, 17);
            this.chkToggleResizing.TabIndex = 27;
            this.chkToggleResizing.Text = "Enable Experimental Resizing?";
            this.chkToggleResizing.UseVisualStyleBackColor = true;
            this.chkToggleResizing.CheckedChanged += new System.EventHandler(this.chkToggleResizing_CheckedChanged);
            // 
            // btnResetResizePosition
            // 
            this.btnResetResizePosition.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetResizePosition.Location = new System.Drawing.Point(290, 384);
            this.btnResetResizePosition.Name = "btnResetResizePosition";
            this.btnResetResizePosition.Size = new System.Drawing.Size(148, 26);
            this.btnResetResizePosition.TabIndex = 35;
            this.btnResetResizePosition.Text = "Reset Resizing";
            this.btnResetResizePosition.UseVisualStyleBackColor = true;
            this.btnResetResizePosition.Click += new System.EventHandler(this.btnResetResizePosition_Click);
            // 
            // btnGMAOutput
            // 
            this.btnGMAOutput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGMAOutput.Location = new System.Drawing.Point(22, 176);
            this.btnGMAOutput.Name = "btnGMAOutput";
            this.btnGMAOutput.Size = new System.Drawing.Size(157, 22);
            this.btnGMAOutput.TabIndex = 11;
            this.btnGMAOutput.Text = "GMA Output";
            this.btnGMAOutput.UseVisualStyleBackColor = true;
            this.btnGMAOutput.Click += new System.EventHandler(this.btnGMAOutput_Click);
            // 
            // txtGMAOutput
            // 
            this.txtGMAOutput.Location = new System.Drawing.Point(190, 177);
            this.txtGMAOutput.Name = "txtGMAOutput";
            this.txtGMAOutput.Size = new System.Drawing.Size(254, 22);
            this.txtGMAOutput.TabIndex = 12;
            // 
            // chkEnableAutoDeleteJSON
            // 
            this.chkEnableAutoDeleteJSON.AutoSize = true;
            this.chkEnableAutoDeleteJSON.Location = new System.Drawing.Point(76, 427);
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
            this.chkClearText.Location = new System.Drawing.Point(76, 406);
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
            this.lblRunTaskTime.TabIndex = 39;
            this.lblRunTaskTime.Text = "Running Each Task: Manually";
            // 
            // btnModifyScriptTime
            // 
            this.btnModifyScriptTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyScriptTime.Location = new System.Drawing.Point(289, 323);
            this.btnModifyScriptTime.Name = "btnModifyScriptTime";
            this.btnModifyScriptTime.Size = new System.Drawing.Size(149, 26);
            this.btnModifyScriptTime.TabIndex = 32;
            this.btnModifyScriptTime.Text = "Modify Script Delete Time";
            this.btnModifyScriptTime.UseVisualStyleBackColor = true;
            this.btnModifyScriptTime.Click += new System.EventHandler(this.btnModifyScriptTime_Click);
            // 
            // lblScriptDelete
            // 
            this.lblScriptDelete.Location = new System.Drawing.Point(635, 29);
            this.lblScriptDelete.Name = "lblScriptDelete";
            this.lblScriptDelete.Size = new System.Drawing.Size(237, 16);
            this.lblScriptDelete.TabIndex = 40;
            this.lblScriptDelete.Text = "Tasks Delete: 0 Seconds Upon Run";
            // 
            // lblConsoleText
            // 
            this.lblConsoleText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsoleText.Location = new System.Drawing.Point(529, 477);
            this.lblConsoleText.Name = "lblConsoleText";
            this.lblConsoleText.Size = new System.Drawing.Size(209, 43);
            this.lblConsoleText.TabIndex = 43;
            this.lblConsoleText.Text = "Output";
            this.lblConsoleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conControl
            // 
            this.conControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.conControl.IsInputEnabled = true;
            this.conControl.Location = new System.Drawing.Point(12, 526);
            this.conControl.Name = "conControl";
            this.conControl.SendKeyboardCommandsToProcess = false;
            this.conControl.ShowDiagnostics = true;
            this.conControl.Size = new System.Drawing.Size(1246, 360);
            this.conControl.TabIndex = 44;
            this.conControl.TabStop = false;
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearConsole.Location = new System.Drawing.Point(443, 353);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(148, 26);
            this.btnClearConsole.TabIndex = 34;
            this.btnClearConsole.Text = "Clear Console";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Location = new System.Drawing.Point(76, 448);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(195, 17);
            this.chkDarkMode.TabIndex = 26;
            this.chkDarkMode.Text = "Enable Experimental Dark Mode?";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // lblCommandPrompts
            // 
            this.lblCommandPrompts.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommandPrompts.Location = new System.Drawing.Point(326, 246);
            this.lblCommandPrompts.Name = "lblCommandPrompts";
            this.lblCommandPrompts.Size = new System.Drawing.Size(232, 43);
            this.lblCommandPrompts.TabIndex = 28;
            this.lblCommandPrompts.Text = "Utility Commands";
            this.lblCommandPrompts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListOfAddons
            // 
            this.lblListOfAddons.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfAddons.Location = new System.Drawing.Point(746, 248);
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
            this.lstAddons.Location = new System.Drawing.Point(638, 295);
            this.lstAddons.Name = "lstAddons";
            this.lstAddons.Size = new System.Drawing.Size(432, 147);
            this.lstAddons.TabIndex = 46;
            // 
            // tmrFillAddons
            // 
            this.tmrFillAddons.Interval = 1;
            this.tmrFillAddons.Tick += new System.EventHandler(this.tmrFillAddons_Tick);
            // 
            // btnLoadAddonList
            // 
            this.btnLoadAddonList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAddonList.Location = new System.Drawing.Point(1094, 330);
            this.btnLoadAddonList.Name = "btnLoadAddonList";
            this.btnLoadAddonList.Size = new System.Drawing.Size(149, 26);
            this.btnLoadAddonList.TabIndex = 47;
            this.btnLoadAddonList.Text = "Load Addons";
            this.btnLoadAddonList.UseVisualStyleBackColor = true;
            this.btnLoadAddonList.Click += new System.EventHandler(this.btnLoadAddonList_Click);
            // 
            // btnClearAddons
            // 
            this.btnClearAddons.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAddons.Location = new System.Drawing.Point(1094, 442);
            this.btnClearAddons.Name = "btnClearAddons";
            this.btnClearAddons.Size = new System.Drawing.Size(149, 26);
            this.btnClearAddons.TabIndex = 48;
            this.btnClearAddons.Text = "Clear Addon List";
            this.btnClearAddons.UseVisualStyleBackColor = true;
            this.btnClearAddons.Click += new System.EventHandler(this.btnClearAddons_Click);
            // 
            // lblListCommands
            // 
            this.lblListCommands.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCommands.Location = new System.Drawing.Point(1087, 284);
            this.lblListCommands.Name = "lblListCommands";
            this.lblListCommands.Size = new System.Drawing.Size(166, 43);
            this.lblListCommands.TabIndex = 49;
            this.lblListCommands.Text = "Commands";
            this.lblListCommands.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListCommandTop
            // 
            this.lblListCommandTop.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCommandTop.Location = new System.Drawing.Point(1128, 254);
            this.lblListCommandTop.Name = "lblListCommandTop";
            this.lblListCommandTop.Size = new System.Drawing.Size(84, 43);
            this.lblListCommandTop.TabIndex = 50;
            this.lblListCommandTop.Text = "List";
            this.lblListCommandTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUseAddonID
            // 
            this.btnUseAddonID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseAddonID.Location = new System.Drawing.Point(1094, 386);
            this.btnUseAddonID.Name = "btnUseAddonID";
            this.btnUseAddonID.Size = new System.Drawing.Size(149, 26);
            this.btnUseAddonID.TabIndex = 51;
            this.btnUseAddonID.Text = "Use Addon ID";
            this.btnUseAddonID.UseVisualStyleBackColor = true;
            this.btnUseAddonID.Click += new System.EventHandler(this.btnUseAddonID_Click);
            // 
            // btnSearchAddon
            // 
            this.btnSearchAddon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAddon.Location = new System.Drawing.Point(1094, 358);
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
            this.lblSearchAddon.Location = new System.Drawing.Point(635, 448);
            this.lblSearchAddon.Name = "lblSearchAddon";
            this.lblSearchAddon.Size = new System.Drawing.Size(88, 16);
            this.lblSearchAddon.TabIndex = 53;
            this.lblSearchAddon.Text = "Search Addon:";
            // 
            // txtSearchAddon
            // 
            this.txtSearchAddon.Location = new System.Drawing.Point(720, 445);
            this.txtSearchAddon.Name = "txtSearchAddon";
            this.txtSearchAddon.Size = new System.Drawing.Size(350, 22);
            this.txtSearchAddon.TabIndex = 54;
            // 
            // lblLoadingProgress
            // 
            this.lblLoadingProgress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingProgress.Location = new System.Drawing.Point(636, 275);
            this.lblLoadingProgress.Name = "lblLoadingProgress";
            this.lblLoadingProgress.Size = new System.Drawing.Size(137, 16);
            this.lblLoadingProgress.TabIndex = 55;
            this.lblLoadingProgress.Text = "Addon List Not Loaded";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.Location = new System.Drawing.Point(1094, 414);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(149, 26);
            this.btnClearSearch.TabIndex = 56;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // frmGarrysModWorkshopUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1270, 898);
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
            this.Controls.Add(this.lblCommandPrompts);
            this.Controls.Add(this.chkDarkMode);
            this.Controls.Add(this.btnClearConsole);
            this.Controls.Add(this.conControl);
            this.Controls.Add(this.lblConsoleText);
            this.Controls.Add(this.lblScriptDelete);
            this.Controls.Add(this.btnModifyScriptTime);
            this.Controls.Add(this.lblRunTaskTime);
            this.Controls.Add(this.chkClearText);
            this.Controls.Add(this.chkEnableAutoDeleteJSON);
            this.Controls.Add(this.btnGMAOutput);
            this.Controls.Add(this.txtGMAOutput);
            this.Controls.Add(this.btnResetResizePosition);
            this.Controls.Add(this.chkToggleResizing);
            this.Controls.Add(this.chkIgnoreNotices);
            this.Controls.Add(this.btnModifyTimer);
            this.Controls.Add(this.chkAutoRun);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRunTask);
            this.Controls.Add(this.btnRemoveFromQueue);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.lstQueue);
            this.Controls.Add(this.radExtractGMA);
            this.Controls.Add(this.pboxIconPreview);
            this.Controls.Add(this.lblIconPreview);
            this.Controls.Add(this.btnGMALocation);
            this.Controls.Add(this.txtGMALocation);
            this.Controls.Add(this.radCreateJSon);
            this.Controls.Add(this.btnDirectoryOfJSon);
            this.Controls.Add(this.txtDirectoryOfJSon);
            this.Controls.Add(this.btnHelpPage);
            this.Controls.Add(this.btnClearTextBoxes);
            this.Controls.Add(this.btnAddonID);
            this.Controls.Add(this.txtAddonIDNumber);
            this.Controls.Add(this.btnGmadFolder);
            this.Controls.Add(this.btnIconFolder);
            this.Controls.Add(this.btnFolderLocation);
            this.Controls.Add(this.txtGMadFolderLocation);
            this.Controls.Add(this.txtIconFolderLocation);
            this.Controls.Add(this.txtAddonFolderLocation);
            this.Controls.Add(this.btnAddToQueue);
            this.Controls.Add(this.lblUtilityOptions);
            this.Controls.Add(this.radUpdateIcon);
            this.Controls.Add(this.radCreateGma);
            this.Controls.Add(this.radUpdateAddon);
            this.Controls.Add(this.radPublishAddon);
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
        private System.Windows.Forms.RadioButton radPublishAddon;
        private System.Windows.Forms.RadioButton radUpdateAddon;
        private System.Windows.Forms.RadioButton radCreateGma;
        private System.Windows.Forms.RadioButton radUpdateIcon;
        private System.Windows.Forms.Label lblUtilityOptions;
        private System.Windows.Forms.Button btnAddToQueue;
        private System.Windows.Forms.TextBox txtAddonFolderLocation;
        private System.Windows.Forms.TextBox txtIconFolderLocation;
        private System.Windows.Forms.TextBox txtGMadFolderLocation;
        private System.Windows.Forms.Button btnFolderLocation;
        private System.Windows.Forms.Button btnIconFolder;
        private System.Windows.Forms.Button btnGmadFolder;
        private System.Windows.Forms.TextBox txtAddonIDNumber;
        private System.Windows.Forms.Button btnAddonID;
        private System.Windows.Forms.Button btnClearTextBoxes;
        private System.Windows.Forms.Button btnHelpPage;
        private System.Windows.Forms.Button btnDirectoryOfJSon;
        private System.Windows.Forms.TextBox txtDirectoryOfJSon;
        private System.Windows.Forms.RadioButton radCreateJSon;
        private System.Windows.Forms.Button btnGMALocation;
        private System.Windows.Forms.TextBox txtGMALocation;
        private System.Windows.Forms.Label lblIconPreview;
        private System.Windows.Forms.PictureBox pboxIconPreview;
        private System.Windows.Forms.RadioButton radExtractGMA;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.Button btnRemoveFromQueue;
        private System.Windows.Forms.Button btnRunTask;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Timer timeToStartTask;
        private System.Windows.Forms.CheckBox chkAutoRun;
        private System.Windows.Forms.Button btnModifyTimer;
        private System.Windows.Forms.CheckBox chkIgnoreNotices;
        private System.Windows.Forms.CheckBox chkToggleResizing;
        private System.Windows.Forms.Button btnResetResizePosition;
        private System.Windows.Forms.Button btnGMAOutput;
        private System.Windows.Forms.TextBox txtGMAOutput;
        private System.Windows.Forms.CheckBox chkEnableAutoDeleteJSON;
        private System.Windows.Forms.CheckBox chkClearText;
        private System.Windows.Forms.Label lblRunTaskTime;
        private System.Windows.Forms.Button btnModifyScriptTime;
        private System.Windows.Forms.Label lblScriptDelete;
        private System.Windows.Forms.Label lblConsoleText;
        private ConsoleControl.ConsoleControl conControl;
        private System.Windows.Forms.Button btnClearConsole;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.Label lblCommandPrompts;
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
    }
}
