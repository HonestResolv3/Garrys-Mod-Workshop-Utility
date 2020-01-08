namespace GarrysModWorkshopUtil
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.lblCreditsTitle = new System.Windows.Forms.Label();
            this.btnSteam = new System.Windows.Forms.Button();
            this.btnGithub = new System.Windows.Forms.Button();
            this.pboxDefyAvatar = new System.Windows.Forms.PictureBox();
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            this.btnResetImage = new System.Windows.Forms.Button();
            this.chkPreventImageSwitch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDefyAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreditsTitle
            // 
            this.lblCreditsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditsTitle.Location = new System.Drawing.Point(16, 13);
            this.lblCreditsTitle.Name = "lblCreditsTitle";
            this.lblCreditsTitle.Size = new System.Drawing.Size(260, 30);
            this.lblCreditsTitle.TabIndex = 1;
            this.lblCreditsTitle.Text = "Created by: DefyTheRush";
            this.lblCreditsTitle.Click += new System.EventHandler(this.lblCreditsTitle_Click);
            // 
            // btnSteam
            // 
            this.btnSteam.Location = new System.Drawing.Point(32, 223);
            this.btnSteam.Name = "btnSteam";
            this.btnSteam.Size = new System.Drawing.Size(108, 37);
            this.btnSteam.TabIndex = 2;
            this.btnSteam.Text = "Steam Page";
            this.btnSteam.UseVisualStyleBackColor = true;
            this.btnSteam.Click += new System.EventHandler(this.btnSteam_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.Location = new System.Drawing.Point(147, 223);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(108, 37);
            this.btnGithub.TabIndex = 3;
            this.btnGithub.Text = "GitHub Page";
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // pboxDefyAvatar
            // 
            this.pboxDefyAvatar.Image = global::GarrysModWorkshopUtil.Properties.Resources.defypicture_start;
            this.pboxDefyAvatar.Location = new System.Drawing.Point(65, 50);
            this.pboxDefyAvatar.Name = "pboxDefyAvatar";
            this.pboxDefyAvatar.Size = new System.Drawing.Size(162, 162);
            this.pboxDefyAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDefyAvatar.TabIndex = 0;
            this.pboxDefyAvatar.TabStop = false;
            this.pboxDefyAvatar.Click += new System.EventHandler(this.pboxDefyAvatar_Click);
            // 
            // tmrChangeImage
            // 
            this.tmrChangeImage.Interval = 7500;
            this.tmrChangeImage.Tick += new System.EventHandler(this.tmrChangeImage_Tick);
            // 
            // btnResetImage
            // 
            this.btnResetImage.Location = new System.Drawing.Point(32, 266);
            this.btnResetImage.Name = "btnResetImage";
            this.btnResetImage.Size = new System.Drawing.Size(108, 37);
            this.btnResetImage.TabIndex = 5;
            this.btnResetImage.Text = "Reset Image";
            this.btnResetImage.UseVisualStyleBackColor = true;
            this.btnResetImage.Click += new System.EventHandler(this.btnResetImage_Click);
            // 
            // chkPreventImageSwitch
            // 
            this.chkPreventImageSwitch.AutoSize = true;
            this.chkPreventImageSwitch.Location = new System.Drawing.Point(149, 276);
            this.chkPreventImageSwitch.Name = "chkPreventImageSwitch";
            this.chkPreventImageSwitch.Size = new System.Drawing.Size(113, 17);
            this.chkPreventImageSwitch.TabIndex = 6;
            this.chkPreventImageSwitch.Text = "No Image Switch?";
            this.chkPreventImageSwitch.UseVisualStyleBackColor = true;
            this.chkPreventImageSwitch.CheckedChanged += new System.EventHandler(this.chkPreventImageSwitch_CheckedChanged);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 318);
            this.Controls.Add(this.chkPreventImageSwitch);
            this.Controls.Add(this.btnResetImage);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnSteam);
            this.Controls.Add(this.lblCreditsTitle);
            this.Controls.Add(this.pboxDefyAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Credits";
            this.Text = "Credits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Credits_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Credits_FormClosed);
            this.Load += new System.EventHandler(this.Credits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDefyAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxDefyAvatar;
        private System.Windows.Forms.Label lblCreditsTitle;
        private System.Windows.Forms.Button btnSteam;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Timer tmrChangeImage;
        private System.Windows.Forms.Button btnResetImage;
        private System.Windows.Forms.CheckBox chkPreventImageSwitch;
    }
}