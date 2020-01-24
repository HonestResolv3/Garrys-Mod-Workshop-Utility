namespace GarrysModWorkshopUtil
{
    partial class PastTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastTasks));
            this.lblDeletedTasks = new System.Windows.Forms.Label();
            this.lstDeletedTasks = new System.Windows.Forms.ListBox();
            this.btnViewTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeletedTasks
            // 
            this.lblDeletedTasks.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletedTasks.Location = new System.Drawing.Point(171, 5);
            this.lblDeletedTasks.Name = "lblDeletedTasks";
            this.lblDeletedTasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeletedTasks.Size = new System.Drawing.Size(267, 43);
            this.lblDeletedTasks.TabIndex = 1;
            this.lblDeletedTasks.Text = "Task History";
            this.lblDeletedTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDeletedTasks
            // 
            this.lstDeletedTasks.FormattingEnabled = true;
            this.lstDeletedTasks.Location = new System.Drawing.Point(12, 53);
            this.lstDeletedTasks.Name = "lstDeletedTasks";
            this.lstDeletedTasks.Size = new System.Drawing.Size(600, 212);
            this.lstDeletedTasks.TabIndex = 2;
            // 
            // btnViewTask
            // 
            this.btnViewTask.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTask.Location = new System.Drawing.Point(240, 275);
            this.btnViewTask.Name = "btnViewTask";
            this.btnViewTask.Size = new System.Drawing.Size(149, 27);
            this.btnViewTask.TabIndex = 32;
            this.btnViewTask.Text = "View Task Information";
            this.btnViewTask.UseVisualStyleBackColor = true;
            this.btnViewTask.Click += new System.EventHandler(this.btnViewTask_Click);
            // 
            // PastTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 313);
            this.Controls.Add(this.btnViewTask);
            this.Controls.Add(this.lstDeletedTasks);
            this.Controls.Add(this.lblDeletedTasks);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PastTasks";
            this.Text = "Past Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PastTasks_FormClosing);
            this.Load += new System.EventHandler(this.frmPastTasks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeletedTasks;
        private System.Windows.Forms.ListBox lstDeletedTasks;
        private System.Windows.Forms.Button btnViewTask;
    }
}