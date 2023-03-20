
namespace LEC_Main_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.flwSidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlCalendarDropItems = new System.Windows.Forms.Panel();
            this.pnlViewCalendar = new System.Windows.Forms.Panel();
            this.btnViewCalendar = new System.Windows.Forms.Button();
            this.pnlRemoveJob = new System.Windows.Forms.Panel();
            this.btnRemoveJob = new System.Windows.Forms.Button();
            this.pnlEditJob = new System.Windows.Forms.Panel();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.pnlAddJob = new System.Windows.Forms.Panel();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tmrSidebar = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.tmrCalendarBar = new System.Windows.Forms.Timer(this.components);
            this.flwSidebarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlCalendarDropItems.SuspendLayout();
            this.pnlViewCalendar.SuspendLayout();
            this.pnlRemoveJob.SuspendLayout();
            this.pnlEditJob.SuspendLayout();
            this.pnlAddJob.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // flwSidebarContainer
            // 
            this.flwSidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.flwSidebarContainer.Controls.Add(this.panel1);
            this.flwSidebarContainer.Controls.Add(this.panel2);
            this.flwSidebarContainer.Controls.Add(this.pnlCalendarDropItems);
            this.flwSidebarContainer.Controls.Add(this.pnlEmployee);
            this.flwSidebarContainer.Controls.Add(this.pnlSettings);
            this.flwSidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwSidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.flwSidebarContainer.MaximumSize = new System.Drawing.Size(183, 450);
            this.flwSidebarContainer.MinimumSize = new System.Drawing.Size(45, 450);
            this.flwSidebarContainer.Name = "flwSidebarContainer";
            this.flwSidebarContainer.Size = new System.Drawing.Size(45, 450);
            this.flwSidebarContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.picMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(86, 40);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(49, 20);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            // 
            // picMenu
            // 
            this.picMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMenu.Image = global::LEC_Main_Project.Properties.Resources.New_Project__6_;
            this.picMenu.Location = new System.Drawing.Point(5, 27);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(40, 35);
            this.picMenu.TabIndex = 1;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 53);
            this.panel2.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::LEC_Main_Project.Properties.Resources.New_Project__5_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-3, -11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(231, 78);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlCalendarDropItems
            // 
            this.pnlCalendarDropItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.pnlCalendarDropItems.Controls.Add(this.pnlViewCalendar);
            this.pnlCalendarDropItems.Controls.Add(this.pnlRemoveJob);
            this.pnlCalendarDropItems.Controls.Add(this.pnlEditJob);
            this.pnlCalendarDropItems.Controls.Add(this.pnlAddJob);
            this.pnlCalendarDropItems.Controls.Add(this.panel3);
            this.pnlCalendarDropItems.Location = new System.Drawing.Point(3, 168);
            this.pnlCalendarDropItems.MaximumSize = new System.Drawing.Size(180, 280);
            this.pnlCalendarDropItems.MinimumSize = new System.Drawing.Size(180, 67);
            this.pnlCalendarDropItems.Name = "pnlCalendarDropItems";
            this.pnlCalendarDropItems.Size = new System.Drawing.Size(180, 67);
            this.pnlCalendarDropItems.TabIndex = 3;
            // 
            // pnlViewCalendar
            // 
            this.pnlViewCalendar.Controls.Add(this.btnViewCalendar);
            this.pnlViewCalendar.Location = new System.Drawing.Point(3, 65);
            this.pnlViewCalendar.Name = "pnlViewCalendar";
            this.pnlViewCalendar.Size = new System.Drawing.Size(177, 53);
            this.pnlViewCalendar.TabIndex = 6;
            // 
            // btnViewCalendar
            // 
            this.btnViewCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.btnViewCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCalendar.ForeColor = System.Drawing.Color.White;
            this.btnViewCalendar.Image = global::LEC_Main_Project.Properties.Resources.ViewCalenderSmall_button;
            this.btnViewCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCalendar.Location = new System.Drawing.Point(-1, -11);
            this.btnViewCalendar.Name = "btnViewCalendar";
            this.btnViewCalendar.Size = new System.Drawing.Size(187, 75);
            this.btnViewCalendar.TabIndex = 1;
            this.btnViewCalendar.Text = "View calendar";
            this.btnViewCalendar.UseVisualStyleBackColor = false;
            this.btnViewCalendar.Click += new System.EventHandler(this.btnViewCalendar_Click);
            // 
            // pnlRemoveJob
            // 
            this.pnlRemoveJob.Controls.Add(this.btnRemoveJob);
            this.pnlRemoveJob.Location = new System.Drawing.Point(3, 227);
            this.pnlRemoveJob.Name = "pnlRemoveJob";
            this.pnlRemoveJob.Size = new System.Drawing.Size(177, 53);
            this.pnlRemoveJob.TabIndex = 7;
            // 
            // btnRemoveJob
            // 
            this.btnRemoveJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.btnRemoveJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveJob.ForeColor = System.Drawing.Color.White;
            this.btnRemoveJob.Image = global::LEC_Main_Project.Properties.Resources.RemoveJobSmall_button;
            this.btnRemoveJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveJob.Location = new System.Drawing.Point(-1, -11);
            this.btnRemoveJob.Name = "btnRemoveJob";
            this.btnRemoveJob.Size = new System.Drawing.Size(187, 75);
            this.btnRemoveJob.TabIndex = 1;
            this.btnRemoveJob.Text = "Remove job";
            this.btnRemoveJob.UseVisualStyleBackColor = false;
            this.btnRemoveJob.Click += new System.EventHandler(this.btnRemoveJob_Click);
            // 
            // pnlEditJob
            // 
            this.pnlEditJob.Controls.Add(this.btnEditJob);
            this.pnlEditJob.Location = new System.Drawing.Point(3, 173);
            this.pnlEditJob.Name = "pnlEditJob";
            this.pnlEditJob.Size = new System.Drawing.Size(177, 53);
            this.pnlEditJob.TabIndex = 6;
            // 
            // btnEditJob
            // 
            this.btnEditJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.btnEditJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditJob.ForeColor = System.Drawing.Color.White;
            this.btnEditJob.Image = global::LEC_Main_Project.Properties.Resources.EditJobSmall_button;
            this.btnEditJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditJob.Location = new System.Drawing.Point(-1, -11);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(187, 75);
            this.btnEditJob.TabIndex = 1;
            this.btnEditJob.Text = "Edit job";
            this.btnEditJob.UseVisualStyleBackColor = false;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // pnlAddJob
            // 
            this.pnlAddJob.Controls.Add(this.btnAddJob);
            this.pnlAddJob.Location = new System.Drawing.Point(3, 119);
            this.pnlAddJob.Name = "pnlAddJob";
            this.pnlAddJob.Size = new System.Drawing.Size(177, 53);
            this.pnlAddJob.TabIndex = 5;
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJob.ForeColor = System.Drawing.Color.White;
            this.btnAddJob.Image = global::LEC_Main_Project.Properties.Resources.AddjobSmall_button;
            this.btnAddJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddJob.Location = new System.Drawing.Point(-1, -11);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(187, 75);
            this.btnAddJob.TabIndex = 1;
            this.btnAddJob.Text = "Add job";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCalendar);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 55);
            this.panel3.TabIndex = 1;
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.Image = global::LEC_Main_Project.Properties.Resources.New_Project__3_;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(-6, -7);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(211, 74);
            this.btnCalendar.TabIndex = 2;
            this.btnCalendar.Text = "           Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.btnEmployee);
            this.pnlEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEmployee.ForeColor = System.Drawing.Color.White;
            this.pnlEmployee.Location = new System.Drawing.Point(3, 241);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(200, 58);
            this.pnlEmployee.TabIndex = 1;
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Image = global::LEC_Main_Project.Properties.Resources.New_Project__4_;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(-2, -17);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(223, 97);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "       Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnSettings);
            this.pnlSettings.Location = new System.Drawing.Point(3, 305);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(200, 55);
            this.pnlSettings.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::LEC_Main_Project.Properties.Resources.settings_25_32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(-4, -10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(217, 74);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "       Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tmrSidebar
            // 
            this.tmrSidebar.Interval = 10;
            this.tmrSidebar.Tick += new System.EventHandler(this.tmrSidebar_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.picCompanyLogo);
            this.pnlMain.Location = new System.Drawing.Point(45, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(760, 450);
            this.pnlMain.TabIndex = 1;
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.Image = global::LEC_Main_Project.Properties.Resources.Lees_Electrical_Logo_Blue_Small_removebg_preview__1_;
            this.picCompanyLogo.Location = new System.Drawing.Point(694, 391);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(64, 60);
            this.picCompanyLogo.TabIndex = 0;
            this.picCompanyLogo.TabStop = false;
            // 
            // tmrCalendarBar
            // 
            this.tmrCalendarBar.Interval = 5;
            this.tmrCalendarBar.Tick += new System.EventHandler(this.tmrCalendarBar_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flwSidebarContainer);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "LEC Calendar";
            this.flwSidebarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlCalendarDropItems.ResumeLayout(false);
            this.pnlViewCalendar.ResumeLayout(false);
            this.pnlRemoveJob.ResumeLayout(false);
            this.pnlEditJob.ResumeLayout(false);
            this.pnlAddJob.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwSidebarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Timer tmrSidebar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlAddJob;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Panel pnlCalendarDropItems;
        private System.Windows.Forms.Panel pnlViewCalendar;
        private System.Windows.Forms.Button btnViewCalendar;
        private System.Windows.Forms.Panel pnlRemoveJob;
        private System.Windows.Forms.Button btnRemoveJob;
        private System.Windows.Forms.Panel pnlEditJob;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Timer tmrCalendarBar;
        private System.Windows.Forms.PictureBox picCompanyLogo;
    }
}