
namespace LEC_Main_Project
{
    partial class frmHome
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
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.groupBox_WeeklyJobs = new System.Windows.Forms.GroupBox();
            this.lblLeeCompletedJobs = new System.Windows.Forms.Label();
            this.lblTonyCompletedJobs = new System.Windows.Forms.Label();
            this.lblBenCompletedJobs = new System.Windows.Forms.Label();
            this.lblTotalJobs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.groupBox_WeeklyJobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.Image = global::LEC_Main_Project.Properties.Resources.Lees_Electrical_Logo_Blue_Small_removebg_preview__1_;
            this.picCompanyLogo.Location = new System.Drawing.Point(696, 390);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(64, 60);
            this.picCompanyLogo.TabIndex = 2;
            this.picCompanyLogo.TabStop = false;
            // 
            // groupBox_WeeklyJobs
            // 
            this.groupBox_WeeklyJobs.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_WeeklyJobs.Controls.Add(this.lblTotalJobs);
            this.groupBox_WeeklyJobs.Controls.Add(this.lblBenCompletedJobs);
            this.groupBox_WeeklyJobs.Controls.Add(this.lblTonyCompletedJobs);
            this.groupBox_WeeklyJobs.Controls.Add(this.lblLeeCompletedJobs);
            this.groupBox_WeeklyJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_WeeklyJobs.Location = new System.Drawing.Point(12, 12);
            this.groupBox_WeeklyJobs.Name = "groupBox_WeeklyJobs";
            this.groupBox_WeeklyJobs.Size = new System.Drawing.Size(233, 154);
            this.groupBox_WeeklyJobs.TabIndex = 3;
            this.groupBox_WeeklyJobs.TabStop = false;
            this.groupBox_WeeklyJobs.Text = "Jobs this week:";
            // 
            // lblLeeCompletedJobs
            // 
            this.lblLeeCompletedJobs.AutoSize = true;
            this.lblLeeCompletedJobs.Location = new System.Drawing.Point(4, 29);
            this.lblLeeCompletedJobs.Name = "lblLeeCompletedJobs";
            this.lblLeeCompletedJobs.Size = new System.Drawing.Size(47, 24);
            this.lblLeeCompletedJobs.TabIndex = 0;
            this.lblLeeCompletedJobs.Text = "Lee:";
            // 
            // lblTonyCompletedJobs
            // 
            this.lblTonyCompletedJobs.AutoSize = true;
            this.lblTonyCompletedJobs.Location = new System.Drawing.Point(4, 57);
            this.lblTonyCompletedJobs.Name = "lblTonyCompletedJobs";
            this.lblTonyCompletedJobs.Size = new System.Drawing.Size(63, 24);
            this.lblTonyCompletedJobs.TabIndex = 1;
            this.lblTonyCompletedJobs.Text = "Tony: ";
            // 
            // lblBenCompletedJobs
            // 
            this.lblBenCompletedJobs.AutoSize = true;
            this.lblBenCompletedJobs.Location = new System.Drawing.Point(4, 85);
            this.lblBenCompletedJobs.Name = "lblBenCompletedJobs";
            this.lblBenCompletedJobs.Size = new System.Drawing.Size(54, 24);
            this.lblBenCompletedJobs.TabIndex = 2;
            this.lblBenCompletedJobs.Text = "Ben: ";
            // 
            // lblTotalJobs
            // 
            this.lblTotalJobs.AutoSize = true;
            this.lblTotalJobs.Location = new System.Drawing.Point(3, 113);
            this.lblTotalJobs.Name = "lblTotalJobs";
            this.lblTotalJobs.Size = new System.Drawing.Size(101, 24);
            this.lblTotalJobs.TabIndex = 3;
            this.lblTotalJobs.Text = "Total Jobs:";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.groupBox_WeeklyJobs);
            this.Controls.Add(this.picCompanyLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.groupBox_WeeklyJobs.ResumeLayout(false);
            this.groupBox_WeeklyJobs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.GroupBox groupBox_WeeklyJobs;
        private System.Windows.Forms.Label lblTonyCompletedJobs;
        private System.Windows.Forms.Label lblLeeCompletedJobs;
        private System.Windows.Forms.Label lblBenCompletedJobs;
        private System.Windows.Forms.Label lblTotalJobs;
    }
}