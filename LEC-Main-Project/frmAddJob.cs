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
    public partial class frmAddJob : Form
    {
        // Database connection string
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T9LNCSO;Initial Catalog=LEC-Database;Integrated Security=True");
        public frmAddJob()
        {
            InitializeComponent();
        }

        private void btnGetSelectedDate_Click(object sender, EventArgs e)
        {
            // Assigns the start and end dates with the date format dd-MM-yyyy
            txtStartDate.Text = monthCalendar1.SelectionRange.Start.Date.ToString("dd-MM-yyyy");
            txtEndDate.Text = monthCalendar1.SelectionRange.End.Date.ToString("dd-MM-yyyy");
        }

        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            // Checks if the text boxes are null or empty
            if(string.IsNullOrEmpty(txtStartDate.Text) || string.IsNullOrEmpty(txtEndDate.Text) || string.IsNullOrEmpty(txtEmployeeOnJob.Text) || string.IsNullOrEmpty(txtLocation.Text)) 
            {
                // Alerts the user that one or more textboxes are empty
                MessageBox.Show("One or more textboxes are empty!");
            }
            else
            {
                // Inserts the jobs from the text boxes into the database
                String AddJobQuery = "INSERT INTO dbo.CurrentJobs (StartDate, EndDate, EmployeeOnJob, Location) VALUES (@StartDate, @EndDate, @EmployeeOnJob, @Location)";
                SqlCommand AddJobCmd = new SqlCommand(AddJobQuery, conn);

                // Adds each variable into parameter list
                AddJobCmd.Parameters.AddWithValue("@StartDate", txtStartDate.Text);
                AddJobCmd.Parameters.AddWithValue("@EndDate", txtEndDate.Text);
                AddJobCmd.Parameters.AddWithValue("@EmployeeOnJob", txtEmployeeOnJob.Text);
                AddJobCmd.Parameters.AddWithValue("@Location", txtLocation.Text);

                conn.Open();
                // Executes all parameters and inserts them into the database
                AddJobCmd.ExecuteNonQuery();
                conn.Close();
                // Alerts the user to let them know the process worked
                MessageBox.Show("Job successfully added!");
            }
        }
    }
}
