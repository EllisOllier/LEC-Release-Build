using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LEC_Main_Project
{
    public partial class frmHome : Form
    {
        // Variable declarations
        // Database variables
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9LNCSO;Initial Catalog=LEC-Database;Integrated Security=True");
        // Job related variables
        int LeeJobs;
        int TonyJobs;
        int BenJobs;
        int TotalCompleted;
        public frmHome()
        {
            InitializeComponent();
            // For loop to cycle through the 3 IDs
            for (int i = 2; i <= 4; i++)
            {
                // Connects to database and gets the jobs completed for the ID (i)
                // The jobs completed is then set on a label to be viewed
                conn.Open();
                String query = "SELECT JobsCompleted FROM Employees where ID=" + i + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                TotalCompleted += (int)cmd.ExecuteScalar();
                int CurrentCompleted = (int)cmd.ExecuteScalar();
                conn.Close();
                // If statements to check if the ID 
                if (i == 2)
                {
                    LeeJobs = CurrentCompleted;
                    lblLeeCompletedJobs.Text = "Lee: " + LeeJobs.ToString();
                }
                else if (i == 3)
                {
                    TonyJobs = CurrentCompleted;
                    lblTonyCompletedJobs.Text = "Tony: " + TonyJobs.ToString();
                }
                else if (i == 4)
                {
                    BenJobs = CurrentCompleted;
                    lblBenCompletedJobs.Text = "Ben: " + BenJobs.ToString();
                }
                lblTotalJobs.Text = "Total Jobs: " + TotalCompleted.ToString();

            }

        }

    }
}
