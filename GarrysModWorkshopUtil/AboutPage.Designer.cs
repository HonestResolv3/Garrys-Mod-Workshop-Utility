namespace GarrysModWorkshopUtil
{
    partial class AboutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPage));
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.lstChangelog = new System.Windows.Forms.ListBox();
            this.btnCredits = new System.Windows.Forms.Button();
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            this.chkPreventImageSwitch = new System.Windows.Forms.CheckBox();
            this.btnResetImage = new System.Windows.Forms.Button();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnSteam = new System.Windows.Forms.Button();
            this.lblCreditsTitle = new System.Windows.Forms.Label();
            this.tmrRetractWindow = new System.Windows.Forms.Timer(this.components);
            this.tmrExpandWindow = new System.Windows.Forms.Timer(this.components);
            this.lblCreditsTitle2 = new System.Windows.Forms.Label();
            this.btnDescription = new System.Windows.Forms.Button();
            this.cboxChangelogs = new System.Windows.Forms.ComboBox();
            this.lblContributors = new System.Windows.Forms.Label();
            this.pboxHeliosAvatar = new System.Windows.Forms.PictureBox();
            this.pboxHiddenAvatar = new System.Windows.Forms.PictureBox();
            this.pboxAk47Avatar = new System.Windows.Forms.PictureBox();
            this.pboxDefyAvatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAk47tohSteam = new System.Windows.Forms.Button();
            this.btnHiddenSteam = new System.Windows.Forms.Button();
            this.btnHeliosSteam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHeliosAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHiddenAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAk47Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDefyAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProgramTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramTitle.Location = new System.Drawing.Point(74, -2);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProgramTitle.Size = new System.Drawing.Size(417, 43);
            this.lblProgramTitle.TabIndex = 1;
            this.lblProgramTitle.Text = "Garry\'s Mod Workshop Utility v5";
            this.lblProgramTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstChangelog
            // 
            this.lstChangelog.FormattingEnabled = true;
            this.lstChangelog.HorizontalScrollbar = true;
            this.lstChangelog.Location = new System.Drawing.Point(11, 84);
            this.lstChangelog.Name = "lstChangelog";
            this.lstChangelog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstChangelog.Size = new System.Drawing.Size(544, 238);
            this.lstChangelog.TabIndex = 5;
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(459, 44);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(96, 27);
            this.btnCredits.TabIndex = 4;
            this.btnCredits.Text = "Testers";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // tmrChangeImage
            // 
            this.tmrChangeImage.Interval = 7500;
            this.tmrChangeImage.Tick += new System.EventHandler(this.tmrChangeImage_Tick);
            // 
            // chkPreventImageSwitch
            // 
            this.chkPreventImageSwitch.AutoSize = true;
            this.chkPreventImageSwitch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreventImageSwitch.Location = new System.Drawing.Point(698, 295);
            this.chkPreventImageSwitch.Name = "chkPreventImageSwitch";
            this.chkPreventImageSwitch.Size = new System.Drawing.Size(117, 17);
            this.chkPreventImageSwitch.TabIndex = 11;
            this.chkPreventImageSwitch.Text = "No Image Switch?";
            this.chkPreventImageSwitch.UseVisualStyleBackColor = true;
            this.chkPreventImageSwitch.CheckedChanged += new System.EventHandler(this.chkPreventImageSwitch_CheckedChanged);
            // 
            // btnResetImage
            // 
            this.btnResetImage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetImage.Location = new System.Drawing.Point(581, 285);
            this.btnResetImage.Name = "btnResetImage";
            this.btnResetImage.Size = new System.Drawing.Size(108, 37);
            this.btnResetImage.TabIndex = 10;
            this.btnResetImage.Text = "Reset Image";
            this.btnResetImage.UseVisualStyleBackColor = true;
            this.btnResetImage.Click += new System.EventHandler(this.btnResetImage_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGithub.Location = new System.Drawing.Point(696, 242);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(108, 37);
            this.btnGithub.TabIndex = 9;
            this.btnGithub.Text = "GitHub Page";
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnSteam
            // 
            this.btnSteam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteam.Location = new System.Drawing.Point(581, 242);
            this.btnSteam.Name = "btnSteam";
            this.btnSteam.Size = new System.Drawing.Size(108, 37);
            this.btnSteam.TabIndex = 8;
            this.btnSteam.Text = "Steam Page";
            this.btnSteam.UseVisualStyleBackColor = true;
            this.btnSteam.Click += new System.EventHandler(this.btnSteam_Click);
            // 
            // lblCreditsTitle
            // 
            this.lblCreditsTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditsTitle.Location = new System.Drawing.Point(574, 5);
            this.lblCreditsTitle.Name = "lblCreditsTitle";
            this.lblCreditsTitle.Size = new System.Drawing.Size(250, 30);
            this.lblCreditsTitle.TabIndex = 6;
            this.lblCreditsTitle.Text = "Created by: DefyTheRush";
            this.lblCreditsTitle.Click += new System.EventHandler(this.lblCreditsTitle_Click);
            // 
            // tmrRetractWindow
            // 
            this.tmrRetractWindow.Interval = 10;
            this.tmrRetractWindow.Tick += new System.EventHandler(this.tmrRetractWindow_Tick);
            // 
            // tmrExpandWindow
            // 
            this.tmrExpandWindow.Interval = 10;
            this.tmrExpandWindow.Tick += new System.EventHandler(this.tmrExpandWindow_Tick);
            // 
            // lblCreditsTitle2
            // 
            this.lblCreditsTitle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditsTitle2.Location = new System.Drawing.Point(597, 32);
            this.lblCreditsTitle2.Name = "lblCreditsTitle2";
            this.lblCreditsTitle2.Size = new System.Drawing.Size(202, 30);
            this.lblCreditsTitle2.TabIndex = 7;
            this.lblCreditsTitle2.Text = "/ Kouko Matsumoto";
            this.lblCreditsTitle2.Click += new System.EventHandler(this.lblCreditsTitle2_Click);
            // 
            // btnDescription
            // 
            this.btnDescription.Location = new System.Drawing.Point(354, 44);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(96, 27);
            this.btnDescription.TabIndex = 3;
            this.btnDescription.Text = "Description";
            this.btnDescription.UseVisualStyleBackColor = true;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // cboxChangelogs
            // 
            this.cboxChangelogs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxChangelogs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxChangelogs.FormattingEnabled = true;
            this.cboxChangelogs.Items.AddRange(new object[] {
            "View changelogs by clicking here",
            "Load Version 1 Changelog",
            "Load Version 2 Changelog",
            "Load Version 3 Changelog",
            "Load Version 4 Changelog",
            "Load Version 5 Changelog"});
            this.cboxChangelogs.Location = new System.Drawing.Point(12, 45);
            this.cboxChangelogs.Name = "cboxChangelogs";
            this.cboxChangelogs.Size = new System.Drawing.Size(330, 25);
            this.cboxChangelogs.TabIndex = 2;
            this.cboxChangelogs.SelectedIndexChanged += new System.EventHandler(this.cboxChangelogs_SelectedIndexChanged);
            // 
            // lblContributors
            // 
            this.lblContributors.BackColor = System.Drawing.Color.Transparent;
            this.lblContributors.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContributors.Location = new System.Drawing.Point(342, 322);
            this.lblContributors.Name = "lblContributors";
            this.lblContributors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblContributors.Size = new System.Drawing.Size(133, 43);
            this.lblContributors.TabIndex = 12;
            this.lblContributors.Text = "Testers";
            this.lblContributors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxHeliosAvatar
            // 
            this.pboxHeliosAvatar.Image = global::GarrysModWorkshopUtil.Properties.Resources.helion_image;
            this.pboxHeliosAvatar.Location = new System.Drawing.Point(582, 392);
            this.pboxHeliosAvatar.Name = "pboxHeliosAvatar";
            this.pboxHeliosAvatar.Size = new System.Drawing.Size(162, 162);
            this.pboxHeliosAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHeliosAvatar.TabIndex = 18;
            this.pboxHeliosAvatar.TabStop = false;
            // 
            // pboxHiddenAvatar
            // 
            this.pboxHiddenAvatar.Image = global::GarrysModWorkshopUtil.Properties.Resources.hidden_image;
            this.pboxHiddenAvatar.Location = new System.Drawing.Point(330, 392);
            this.pboxHiddenAvatar.Name = "pboxHiddenAvatar";
            this.pboxHiddenAvatar.Size = new System.Drawing.Size(162, 162);
            this.pboxHiddenAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHiddenAvatar.TabIndex = 17;
            this.pboxHiddenAvatar.TabStop = false;
            // 
            // pboxAk47Avatar
            // 
            this.pboxAk47Avatar.Image = global::GarrysModWorkshopUtil.Properties.Resources.ak47toh_image;
            this.pboxAk47Avatar.Location = new System.Drawing.Point(82, 392);
            this.pboxAk47Avatar.Name = "pboxAk47Avatar";
            this.pboxAk47Avatar.Size = new System.Drawing.Size(162, 162);
            this.pboxAk47Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAk47Avatar.TabIndex = 15;
            this.pboxAk47Avatar.TabStop = false;
            // 
            // pboxDefyAvatar
            // 
            this.pboxDefyAvatar.Image = global::GarrysModWorkshopUtil.Properties.Resources.defypicture5;
            this.pboxDefyAvatar.Location = new System.Drawing.Point(614, 69);
            this.pboxDefyAvatar.Name = "pboxDefyAvatar";
            this.pboxDefyAvatar.Size = new System.Drawing.Size(162, 162);
            this.pboxDefyAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDefyAvatar.TabIndex = 8;
            this.pboxDefyAvatar.TabStop = false;
            this.pboxDefyAvatar.Click += new System.EventHandler(this.pboxDefyAvatar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ak47toh";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hidden";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Helios";
            // 
            // btnAk47tohSteam
            // 
            this.btnAk47tohSteam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAk47tohSteam.Location = new System.Drawing.Point(110, 560);
            this.btnAk47tohSteam.Name = "btnAk47tohSteam";
            this.btnAk47tohSteam.Size = new System.Drawing.Size(108, 37);
            this.btnAk47tohSteam.TabIndex = 14;
            this.btnAk47tohSteam.Text = "Steam Page";
            this.btnAk47tohSteam.UseVisualStyleBackColor = true;
            this.btnAk47tohSteam.Click += new System.EventHandler(this.btnAk47tohSteam_Click);
            // 
            // btnHiddenSteam
            // 
            this.btnHiddenSteam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHiddenSteam.Location = new System.Drawing.Point(356, 560);
            this.btnHiddenSteam.Name = "btnHiddenSteam";
            this.btnHiddenSteam.Size = new System.Drawing.Size(108, 37);
            this.btnHiddenSteam.TabIndex = 16;
            this.btnHiddenSteam.Text = "Steam Page";
            this.btnHiddenSteam.UseVisualStyleBackColor = true;
            this.btnHiddenSteam.Click += new System.EventHandler(this.btnHiddenSteam_Click);
            // 
            // btnHeliosSteam
            // 
            this.btnHeliosSteam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeliosSteam.Location = new System.Drawing.Point(611, 560);
            this.btnHeliosSteam.Name = "btnHeliosSteam";
            this.btnHeliosSteam.Size = new System.Drawing.Size(108, 37);
            this.btnHeliosSteam.TabIndex = 18;
            this.btnHeliosSteam.Text = "Steam Page";
            this.btnHeliosSteam.UseVisualStyleBackColor = true;
            this.btnHeliosSteam.Click += new System.EventHandler(this.btnHeliosSteam_Click);
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 333);
            this.Controls.Add(this.btnHeliosSteam);
            this.Controls.Add(this.btnHiddenSteam);
            this.Controls.Add(this.btnAk47tohSteam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxHeliosAvatar);
            this.Controls.Add(this.pboxHiddenAvatar);
            this.Controls.Add(this.lblContributors);
            this.Controls.Add(this.pboxAk47Avatar);
            this.Controls.Add(this.cboxChangelogs);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.lblCreditsTitle2);
            this.Controls.Add(this.chkPreventImageSwitch);
            this.Controls.Add(this.btnResetImage);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnSteam);
            this.Controls.Add(this.lblCreditsTitle);
            this.Controls.Add(this.pboxDefyAvatar);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.lstChangelog);
            this.Controls.Add(this.lblProgramTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutPage_FormClosed);
            this.Load += new System.EventHandler(this.AboutPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxHeliosAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHiddenAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAk47Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDefyAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.ListBox lstChangelog;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Timer tmrChangeImage;
        private System.Windows.Forms.CheckBox chkPreventImageSwitch;
        private System.Windows.Forms.Button btnResetImage;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnSteam;
        private System.Windows.Forms.Label lblCreditsTitle;
        private System.Windows.Forms.PictureBox pboxDefyAvatar;
        private System.Windows.Forms.Timer tmrRetractWindow;
        private System.Windows.Forms.Timer tmrExpandWindow;
        private System.Windows.Forms.Label lblCreditsTitle2;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.ComboBox cboxChangelogs;
        private System.Windows.Forms.PictureBox pboxAk47Avatar;
        private System.Windows.Forms.Label lblContributors;
        private System.Windows.Forms.PictureBox pboxHiddenAvatar;
        private System.Windows.Forms.PictureBox pboxHeliosAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAk47tohSteam;
        private System.Windows.Forms.Button btnHiddenSteam;
        private System.Windows.Forms.Button btnHeliosSteam;
    }
}
