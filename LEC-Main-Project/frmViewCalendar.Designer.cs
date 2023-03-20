
namespace LEC_Main_Project
{
    partial class frmViewCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.Image = global::LEC_Main_Project.Properties.Resources.Lees_Electrical_Logo_Blue_Small_removebg_preview__1_;
            this.picCompanyLogo.Location = new System.Drawing.Point(696, 390);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(64, 60);
            this.picCompanyLogo.TabIndex = 1;
            this.picCompanyLogo.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(1, -5);
            this.monthCalendar1.MaxSelectionCount = 3;
            this.monthCalendar1.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.Location = new System.Drawing.Point(261, 17);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(416, 420);
            this.listBoxJobs.TabIndex = 6;
            // 
            // frmViewCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.listBoxJobs);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.picCompanyLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewCalendar";
            this.Text = "frmViewCalendar";
            this.Load += new System.EventHandler(this.frmViewCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBoxJobs;
    }
}