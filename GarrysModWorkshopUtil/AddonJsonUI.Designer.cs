namespace GarrysModWorkshopUtil
{
    partial class AddonJsonUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddonJsonUI));
            this.lblUITitle = new System.Windows.Forms.Label();
            this.btnDirectoryOfJSon = new System.Windows.Forms.Button();
            this.txtDirectoryOfJSon = new System.Windows.Forms.TextBox();
            this.radServerContent = new System.Windows.Forms.RadioButton();
            this.radGamemode = new System.Windows.Forms.RadioButton();
            this.radMap = new System.Windows.Forms.RadioButton();
            this.radWeapon = new System.Windows.Forms.RadioButton();
            this.radEffects = new System.Windows.Forms.RadioButton();
            this.radTool = new System.Windows.Forms.RadioButton();
            this.radNpc = new System.Windows.Forms.RadioButton();
            this.radVehicle = new System.Windows.Forms.RadioButton();
            this.radModel = new System.Windows.Forms.RadioButton();
            this.lblAddonTypeTitle = new System.Windows.Forms.Label();
            this.txtWildcards = new System.Windows.Forms.TextBox();
            this.lblEnterWildcards = new System.Windows.Forms.Label();
            this.btnSendBackToMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddonTitle = new System.Windows.Forms.TextBox();
            this.lblChangeNotes = new System.Windows.Forms.Label();
            this.txtTaskNotes = new System.Windows.Forms.TextBox();
            this.lblAddonTags = new System.Windows.Forms.Label();
            this.txtAddonTags = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUITitle
            // 
            this.lblUITitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUITitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUITitle.Location = new System.Drawing.Point(254, -1);
            this.lblUITitle.Name = "lblUITitle";
            this.lblUITitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUITitle.Size = new System.Drawing.Size(296, 43);
            this.lblUITitle.TabIndex = 1;
            this.lblUITitle.Text = "Enter Output Location";
            this.lblUITitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDirectoryOfJSon
            // 
            this.btnDirectoryOfJSon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectoryOfJSon.Location = new System.Drawing.Point(38, 43);
            this.btnDirectoryOfJSon.Name = "btnDirectoryOfJSon";
            this.btnDirectoryOfJSon.Size = new System.Drawing.Size(159, 22);
            this.btnDirectoryOfJSon.TabIndex = 2;
            this.btnDirectoryOfJSon.Text = "JSON Output";
            this.btnDirectoryOfJSon.UseVisualStyleBackColor = true;
            this.btnDirectoryOfJSon.Click += new System.EventHandler(this.btnDirectoryOfJSon_Click);
            // 
            // txtDirectoryOfJSon
            // 
            this.txtDirectoryOfJSon.Enabled = false;
            this.txtDirectoryOfJSon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectoryOfJSon.Location = new System.Drawing.Point(208, 43);
            this.txtDirectoryOfJSon.Name = "txtDirectoryOfJSon";
            this.txtDirectoryOfJSon.Size = new System.Drawing.Size(547, 22);
            this.txtDirectoryOfJSon.TabIndex = 3;
            // 
            // radServerContent
            // 
            this.radServerContent.AutoSize = true;
            this.radServerContent.Location = new System.Drawing.Point(107, 379);
            this.radServerContent.Name = "radServerContent";
            this.radServerContent.Size = new System.Drawing.Size(93, 17);
            this.radServerContent.TabIndex = 13;
            this.radServerContent.TabStop = true;
            this.radServerContent.Text = "ServerContent";
            this.radServerContent.UseVisualStyleBackColor = true;
            // 
            // radGamemode
            // 
            this.radGamemode.AutoSize = true;
            this.radGamemode.Location = new System.Drawing.Point(203, 379);
            this.radGamemode.Name = "radGamemode";
            this.radGamemode.Size = new System.Drawing.Size(79, 17);
            this.radGamemode.TabIndex = 14;
            this.radGamemode.TabStop = true;
            this.radGamemode.Text = "Gamemode";
            this.radGamemode.UseVisualStyleBackColor = true;
            // 
            // radMap
            // 
            this.radMap.AutoSize = true;
            this.radMap.Location = new System.Drawing.Point(285, 379);
            this.radMap.Name = "radMap";
            this.radMap.Size = new System.Drawing.Size(46, 17);
            this.radMap.TabIndex = 15;
            this.radMap.TabStop = true;
            this.radMap.Text = "Map";
            this.radMap.UseVisualStyleBackColor = true;
            // 
            // radWeapon
            // 
            this.radWeapon.AutoSize = true;
            this.radWeapon.Location = new System.Drawing.Point(334, 379);
            this.radWeapon.Name = "radWeapon";
            this.radWeapon.Size = new System.Drawing.Size(66, 17);
            this.radWeapon.TabIndex = 16;
            this.radWeapon.TabStop = true;
            this.radWeapon.Text = "Weapon";
            this.radWeapon.UseVisualStyleBackColor = true;
            // 
            // radEffects
            // 
            this.radEffects.AutoSize = true;
            this.radEffects.Location = new System.Drawing.Point(562, 379);
            this.radEffects.Name = "radEffects";
            this.radEffects.Size = new System.Drawing.Size(58, 17);
            this.radEffects.TabIndex = 20;
            this.radEffects.TabStop = true;
            this.radEffects.Text = "Effects";
            this.radEffects.UseVisualStyleBackColor = true;
            // 
            // radTool
            // 
            this.radTool.AutoSize = true;
            this.radTool.Location = new System.Drawing.Point(512, 379);
            this.radTool.Name = "radTool";
            this.radTool.Size = new System.Drawing.Size(46, 17);
            this.radTool.TabIndex = 19;
            this.radTool.TabStop = true;
            this.radTool.Text = "Tool";
            this.radTool.UseVisualStyleBackColor = true;
            // 
            // radNpc
            // 
            this.radNpc.AutoSize = true;
            this.radNpc.Location = new System.Drawing.Point(465, 379);
            this.radNpc.Name = "radNpc";
            this.radNpc.Size = new System.Drawing.Size(45, 17);
            this.radNpc.TabIndex = 18;
            this.radNpc.TabStop = true;
            this.radNpc.Text = "Npc";
            this.radNpc.UseVisualStyleBackColor = true;
            // 
            // radVehicle
            // 
            this.radVehicle.AutoSize = true;
            this.radVehicle.Location = new System.Drawing.Point(403, 379);
            this.radVehicle.Name = "radVehicle";
            this.radVehicle.Size = new System.Drawing.Size(60, 17);
            this.radVehicle.TabIndex = 17;
            this.radVehicle.TabStop = true;
            this.radVehicle.Text = "Vehicle";
            this.radVehicle.UseVisualStyleBackColor = true;
            // 
            // radModel
            // 
            this.radModel.AutoSize = true;
            this.radModel.Location = new System.Drawing.Point(623, 379);
            this.radModel.Name = "radModel";
            this.radModel.Size = new System.Drawing.Size(54, 17);
            this.radModel.TabIndex = 21;
            this.radModel.TabStop = true;
            this.radModel.Text = "Model";
            this.radModel.UseVisualStyleBackColor = true;
            // 
            // lblAddonTypeTitle
            // 
            this.lblAddonTypeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddonTypeTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddonTypeTitle.Location = new System.Drawing.Point(253, 333);
            this.lblAddonTypeTitle.Name = "lblAddonTypeTitle";
            this.lblAddonTypeTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddonTypeTitle.Size = new System.Drawing.Size(306, 43);
            this.lblAddonTypeTitle.TabIndex = 12;
            this.lblAddonTypeTitle.Text = "Select Addon Type";
            this.lblAddonTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWildcards
            // 
            this.txtWildcards.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWildcards.Location = new System.Drawing.Point(38, 176);
            this.txtWildcards.Name = "txtWildcards";
            this.txtWildcards.Size = new System.Drawing.Size(717, 22);
            this.txtWildcards.TabIndex = 7;
            // 
            // lblEnterWildcards
            // 
            this.lblEnterWildcards.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterWildcards.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterWildcards.Location = new System.Drawing.Point(252, 130);
            this.lblEnterWildcards.Name = "lblEnterWildcards";
            this.lblEnterWildcards.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnterWildcards.Size = new System.Drawing.Size(306, 43);
            this.lblEnterWildcards.TabIndex = 6;
            this.lblEnterWildcards.Text = "Enter Wildcard(s)";
            this.lblEnterWildcards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendBackToMain
            // 
            this.btnSendBackToMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendBackToMain.Location = new System.Drawing.Point(49, 407);
            this.btnSendBackToMain.Name = "btnSendBackToMain";
            this.btnSendBackToMain.Size = new System.Drawing.Size(170, 31);
            this.btnSendBackToMain.TabIndex = 22;
            this.btnSendBackToMain.Text = "Send Back To Program";
            this.btnSendBackToMain.UseVisualStyleBackColor = true;
            this.btnSendBackToMain.Click += new System.EventHandler(this.btnSendBackToMain_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(243, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Addon Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddonTitle
            // 
            this.txtAddonTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddonTitle.Location = new System.Drawing.Point(38, 108);
            this.txtAddonTitle.Name = "txtAddonTitle";
            this.txtAddonTitle.Size = new System.Drawing.Size(717, 22);
            this.txtAddonTitle.TabIndex = 5;
            // 
            // lblChangeNotes
            // 
            this.lblChangeNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeNotes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeNotes.Location = new System.Drawing.Point(266, 198);
            this.lblChangeNotes.Name = "lblChangeNotes";
            this.lblChangeNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChangeNotes.Size = new System.Drawing.Size(281, 43);
            this.lblChangeNotes.TabIndex = 8;
            this.lblChangeNotes.Text = "Enter Task Note(s)";
            this.lblChangeNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaskNotes
            // 
            this.txtTaskNotes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskNotes.Location = new System.Drawing.Point(38, 244);
            this.txtTaskNotes.Name = "txtTaskNotes";
            this.txtTaskNotes.Size = new System.Drawing.Size(717, 22);
            this.txtTaskNotes.TabIndex = 9;
            // 
            // lblAddonTags
            // 
            this.lblAddonTags.BackColor = System.Drawing.Color.Transparent;
            this.lblAddonTags.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddonTags.Location = new System.Drawing.Point(252, 266);
            this.lblAddonTags.Name = "lblAddonTags";
            this.lblAddonTags.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddonTags.Size = new System.Drawing.Size(306, 43);
            this.lblAddonTags.TabIndex = 10;
            this.lblAddonTags.Text = "Enter Addon Tags";
            this.lblAddonTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddonTags
            // 
            this.txtAddonTags.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddonTags.Location = new System.Drawing.Point(38, 310);
            this.txtAddonTags.Name = "txtAddonTags";
            this.txtAddonTags.Size = new System.Drawing.Size(717, 22);
            this.txtAddonTags.TabIndex = 11;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(574, 407);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(170, 31);
            this.btnHelp.TabIndex = 24;
            this.btnHelp.Text = "Need Help?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateFile.Location = new System.Drawing.Point(224, 407);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(170, 31);
            this.btnGenerateFile.TabIndex = 23;
            this.btnGenerateFile.Text = "Create File";
            this.btnGenerateFile.UseVisualStyleBackColor = true;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInput.Location = new System.Drawing.Point(399, 407);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(170, 31);
            this.btnClearInput.TabIndex = 25;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // AddonJsonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.btnGenerateFile);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblAddonTags);
            this.Controls.Add(this.txtAddonTags);
            this.Controls.Add(this.lblChangeNotes);
            this.Controls.Add(this.txtTaskNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddonTitle);
            this.Controls.Add(this.btnSendBackToMain);
            this.Controls.Add(this.lblEnterWildcards);
            this.Controls.Add(this.txtWildcards);
            this.Controls.Add(this.lblAddonTypeTitle);
            this.Controls.Add(this.radModel);
            this.Controls.Add(this.radEffects);
            this.Controls.Add(this.radTool);
            this.Controls.Add(this.radNpc);
            this.Controls.Add(this.radVehicle);
            this.Controls.Add(this.radWeapon);
            this.Controls.Add(this.radMap);
            this.Controls.Add(this.radGamemode);
            this.Controls.Add(this.radServerContent);
            this.Controls.Add(this.btnDirectoryOfJSon);
            this.Controls.Add(this.txtDirectoryOfJSon);
            this.Controls.Add(this.lblUITitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddonJsonUI";
            this.Text = "Addon .JSON UI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddonJsonUI_FormClosing);
            this.Load += new System.EventHandler(this.AddonJsonUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUITitle;
        private System.Windows.Forms.Button btnDirectoryOfJSon;
        private System.Windows.Forms.TextBox txtDirectoryOfJSon;
        private System.Windows.Forms.RadioButton radServerContent;
        private System.Windows.Forms.RadioButton radGamemode;
        private System.Windows.Forms.RadioButton radMap;
        private System.Windows.Forms.RadioButton radWeapon;
        private System.Windows.Forms.RadioButton radEffects;
        private System.Windows.Forms.RadioButton radTool;
        private System.Windows.Forms.RadioButton radNpc;
        private System.Windows.Forms.RadioButton radVehicle;
        private System.Windows.Forms.RadioButton radModel;
        private System.Windows.Forms.Label lblAddonTypeTitle;
        private System.Windows.Forms.TextBox txtWildcards;
        private System.Windows.Forms.Label lblEnterWildcards;
        private System.Windows.Forms.Button btnSendBackToMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddonTitle;
        private System.Windows.Forms.Label lblChangeNotes;
        private System.Windows.Forms.TextBox txtTaskNotes;
        private System.Windows.Forms.Label lblAddonTags;
        private System.Windows.Forms.TextBox txtAddonTags;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.Button btnClearInput;
    }
}
