using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/// <summary>
/// Use month picker control to select months and query them into the database to see if there is a job for that date
/// </summary>

namespace LEC_Main_Project
{
    public partial class frmViewCalendar : Form
    {
        // Database connection string
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9LNCSO;Initial Catalog=LEC-Database;Integrated Security=True");
        public frmViewCalendar()
        {
            InitializeComponent();
        }

        private void frmViewCalendar_Load(object sender, EventArgs e)
        {
            // Loads all of the jobs from the CurrentJobs table
            String LoadJobsQuery = "SELECT * FROM dbo.CurrentJobs";
            SqlDataAdapter sda = new SqlDataAdapter(LoadJobsQuery, conn);

            using(SqlCommand cmd = new SqlCommand(LoadJobsQuery, conn))
            {
                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        // Formats the data from the database to be more readable
                        listBoxJobs.Items.Add(reader["StartDate"].ToString() + " | " + reader["EndDate"].ToString() + " | " + reader["EmployeeOnJob"].ToString() + " | " + reader["Location"].ToString());
                    }
                    reader.Close();
                }
                conn.Close();
            }
        }
    }
}
