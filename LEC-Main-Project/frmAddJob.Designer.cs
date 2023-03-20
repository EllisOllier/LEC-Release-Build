
namespace LEC_Main_Project
{
    partial class frmAddJob
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
            this.btnGetSelectedDate = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblEmployeeOnJob = new System.Windows.Forms.Label();
            this.txtEmployeeOnJob = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnSaveJob = new System.Windows.Forms.Button();
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
            this.monthCalendar1.Location = new System.Drawing.Point(0, -6);
            this.monthCalendar1.MaxSelectionCount = 3;
            this.monthCalendar1.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // btnGetSelectedDate
            // 
            this.btnGetSelectedDate.Location = new System.Drawing.Point(239, 12);
            this.btnGetSelectedDate.Name = "btnGetSelectedDate";
            this.btnGetSelectedDate.Size = new System.Drawing.Size(75, 23);
            this.btnGetSelectedDate.TabIndex = 6;
            this.btnGetSelectedDate.Text = "Get Date";
            this.btnGetSelectedDate.UseVisualStyleBackColor = true;
            this.btnGetSelectedDate.Click += new System.EventHandler(this.btnGetSelectedDate_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(241, 49);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(241, 76);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(341, 45);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartDate.TabIndex = 9;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(341, 71);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndDate.TabIndex = 10;
            // 
            // lblEmployeeOnJob
            // 
            this.lblEmployeeOnJob.AutoSize = true;
            this.lblEmployeeOnJob.Location = new System.Drawing.Point(241, 102);
            this.lblEmployeeOnJob.Name = "lblEmployeeOnJob";
            this.lblEmployeeOnJob.Size = new System.Drawing.Size(91, 13);
            this.lblEmployeeOnJob.TabIndex = 11;
            this.lblEmployeeOnJob.Text = "Employee on Job:";
            // 
            // txtEmployeeOnJob
            // 
            this.txtEmployeeOnJob.Location = new System.Drawing.Point(341, 99);
            this.txtEmployeeOnJob.Name = "txtEmployeeOnJob";
            this.txtEmployeeOnJob.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeOnJob.TabIndex = 12;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(341, 125);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(142, 20);
            this.txtLocation.TabIndex = 13;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(242, 128);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 13);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location: ";
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.Location = new System.Drawing.Point(239, 158);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(75, 23);
            this.btnSaveJob.TabIndex = 15;
            this.btnSaveJob.Text = "Save Job";
            this.btnSaveJob.UseVisualStyleBackColor = true;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
            // 
            // frmAddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.btnSaveJob);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtEmployeeOnJob);
            this.Controls.Add(this.lblEmployeeOnJob);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnGetSelectedDate);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.picCompanyLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddJob";
            this.Text = "frmAddJob";
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnGetSelectedDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEmployeeOnJob;
        private System.Windows.Forms.TextBox txtEmployeeOnJob;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnSaveJob;
    }
}