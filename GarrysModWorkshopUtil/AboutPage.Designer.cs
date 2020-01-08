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
            this.btnVersion1Info = new System.Windows.Forms.Button();
            this.btnVersion2Info = new System.Windows.Forms.Button();
            this.btnVersion3Info = new System.Windows.Forms.Button();
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
            this.pboxDefyAvatar = new System.Windows.Forms.PictureBox();
            this.btnDescription = new System.Windows.Forms.Button();
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
            this.lblProgramTitle.Text = "Garry\'s Mod Workshop Utility v3";
            this.lblProgramTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVersion1Info
            // 
            this.btnVersion1Info.Location = new System.Drawing.Point(12, 44);
            this.btnVersion1Info.Name = "btnVersion1Info";
            this.btnVersion1Info.Size = new System.Drawing.Size(96, 27);
            this.btnVersion1Info.TabIndex = 2;
            this.btnVersion1Info.Text = "Version 1 Info";
            this.btnVersion1Info.UseVisualStyleBackColor = true;
            this.btnVersion1Info.Click += new System.EventHandler(this.btnVersion1Info_Click);
            // 
            // btnVersion2Info
            // 
            this.btnVersion2Info.Location = new System.Drawing.Point(123, 44);
            this.btnVersion2Info.Name = "btnVersion2Info";
            this.btnVersion2Info.Size = new System.Drawing.Size(96, 27);
            this.btnVersion2Info.TabIndex = 3;
            this.btnVersion2Info.Text = "Version 2 Info";
            this.btnVersion2Info.UseVisualStyleBackColor = true;
            this.btnVersion2Info.Click += new System.EventHandler(this.btnVersion2Info_Click);
            // 
            // btnVersion3Info
            // 
            this.btnVersion3Info.Location = new System.Drawing.Point(235, 44);
            this.btnVersion3Info.Name = "btnVersion3Info";
            this.btnVersion3Info.Size = new System.Drawing.Size(96, 27);
            this.btnVersion3Info.TabIndex = 4;
            this.btnVersion3Info.Text = "Version 3 Info";
            this.btnVersion3Info.UseVisualStyleBackColor = true;
            this.btnVersion3Info.Click += new System.EventHandler(this.btnVersion3Info_Click);
            // 
            // lstChangelog
            // 
            this.lstChangelog.FormattingEnabled = true;
            this.lstChangelog.Location = new System.Drawing.Point(11, 84);
            this.lstChangelog.Name = "lstChangelog";
            this.lstChangelog.Size = new System.Drawing.Size(544, 238);
            this.lstChangelog.TabIndex = 7;
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(460, 44);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(96, 27);
            this.btnCredits.TabIndex = 6;
            this.btnCredits.Text = "Credits";
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
            this.chkPreventImageSwitch.TabIndex = 13;
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
            this.btnResetImage.TabIndex = 12;
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
            this.btnGithub.TabIndex = 11;
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
            this.btnSteam.TabIndex = 10;
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
            this.lblCreditsTitle.TabIndex = 8;
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
            this.lblCreditsTitle2.TabIndex = 9;
            this.lblCreditsTitle2.Text = "/ Kouko Matsumoto";
            this.lblCreditsTitle2.Click += new System.EventHandler(this.lblCreditsTitle2_Click);
            // 
            // pboxDefyAvatar
            // 
            this.pboxDefyAvatar.Image = global::GarrysModWorkshopUtil.Properties.Resources.kouko;
            this.pboxDefyAvatar.Location = new System.Drawing.Point(614, 69);
            this.pboxDefyAvatar.Name = "pboxDefyAvatar";
            this.pboxDefyAvatar.Size = new System.Drawing.Size(162, 162);
            this.pboxDefyAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDefyAvatar.TabIndex = 8;
            this.pboxDefyAvatar.TabStop = false;
            this.pboxDefyAvatar.Click += new System.EventHandler(this.pboxDefyAvatar_Click);
            // 
            // btnDescription
            // 
            this.btnDescription.Location = new System.Drawing.Point(348, 44);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(96, 27);
            this.btnDescription.TabIndex = 5;
            this.btnDescription.Text = "Description";
            this.btnDescription.UseVisualStyleBackColor = true;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 333);
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
            this.Controls.Add(this.btnVersion3Info);
            this.Controls.Add(this.btnVersion2Info);
            this.Controls.Add(this.btnVersion1Info);
            this.Controls.Add(this.lblProgramTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutPage";
            this.Text = "About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutPage_FormClosed);
            this.Load += new System.EventHandler(this.AboutPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDefyAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.Button btnVersion1Info;
        private System.Windows.Forms.Button btnVersion2Info;
        private System.Windows.Forms.Button btnVersion3Info;
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
    }
}