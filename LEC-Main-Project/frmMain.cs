using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEC_Main_Project
{
    public partial class frmMain : Form
    {
        // Global variable
        // Needed as they are used during procedures
        bool sidebarExpand;
        bool calendarBarCollapsed = true;

        public string currentUser;

        // Used to initialise the frmMain window
        public frmMain(string username)
        {
            InitializeComponent();
            currentUser = username;
            btnViewCalendar.BackColor = Color.FromArgb(0, 116, 170);
            loadform(new frmHome());
        }

        // Embeds a form in the main form
        public void loadform(object Form)
        {
            if (this.pnlMain.Controls.Count > 0) this.pnlMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.Show();
            this.pnlMain.Controls.Add(f);
        }

        // Enter buttons below
        private void picMenu_Click(object sender, EventArgs e)
        {
            tmrSidebar.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(new frmHome());
        }

        // Starts the timer for the calendar drop down
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tmrCalendarBar.Start();
        }
        private void btnViewCalendar_Click(object sender, EventArgs e)
        {
            loadform(new frmViewCalendar());
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            loadform(new frmAddJob());
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            // Currently Not in program
            // Feature may be added in future
            //loadform(new frmEditJob());
        }

        private void btnRemoveJob_Click(object sender, EventArgs e)
        {
            // Currently Not in program
            // Feature may be added in future
            //loadform(new frmDeleteJob());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            loadform(new frmEmployee(currentUser));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            loadform(new frmSetting());
        }
        // Buttons end

        // Enter timers below
        // Runs the sidebar expand/collapse
        private void tmrSidebar_Tick(object sender, EventArgs e)
        {
            flwSidebarContainer.BringToFront();
            if (sidebarExpand)
            {
                // If sidebar is collapsed then expand
                flwSidebarContainer.Width += 10;
                if (flwSidebarContainer.Width == flwSidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    tmrSidebar.Stop();
                }
            }
            else // Else sidebar is expanded so collapse
            {
                flwSidebarContainer.Width -= 10;
                if (flwSidebarContainer.Width == flwSidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    tmrSidebar.Stop();
                }
            }
        }

        // Runs the calendar drop down buttons
        private void tmrCalendarBar_Tick(object sender, EventArgs e)
        {
            // If the calendar panel is collapsed then expand
            if (calendarBarCollapsed)
            {
                btnViewCalendar.BackColor = Color.FromArgb(0, 150, 219); // Set to light blue
                pnlCalendarDropItems.Height += 10;
                if (pnlCalendarDropItems.Height == pnlCalendarDropItems.MaximumSize.Height)
                {
                    calendarBarCollapsed = false;
                    tmrCalendarBar.Stop();
                }
            }
            else // If the calendar bar is expanded then collapse
            {
                pnlCalendarDropItems.Height -= 10;
                if (pnlCalendarDropItems.Height == pnlCalendarDropItems.MinimumSize.Height)
                {
                    calendarBarCollapsed = true;
                    tmrCalendarBar.Stop();
                    btnViewCalendar.BackColor = Color.FromArgb(0, 116, 170); // Set to dark blue
                }
            }
        }
        // Timer end
    }
}
