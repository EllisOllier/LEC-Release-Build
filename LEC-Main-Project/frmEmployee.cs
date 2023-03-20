using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LEC_Main_Project
{
    public partial class frmEmployee : Form
    {
        // Database variables
        public string CurrentUser;
        public int CompletedJobs;
        // Database connection string
        SqlConnection conn = new SqlConnection(@"");

        public frmEmployee(string username)
        {
            InitializeComponent();
            CurrentUser = username;
            lblCurrentUsername.Text = CurrentUser;

            // Retrieves the ID of the current user
            String IDQuery = "SELECT ID FROM Login where CONVERT(VARCHAR, Username)='" + CurrentUser + "'";
            conn.Open();
            SqlCommand cmdID = new SqlCommand();
            cmdID.Connection = conn;
            cmdID.CommandText = IDQuery;

            // Assigns the ID from the data to the UserID variable
            int UserID = (int)cmdID.ExecuteScalar();
            conn.Close();
            string UserIDString = UserID.ToString();
            conn.Close();

            // Retrieves the amount of jobs completed of the current ID
            conn.Open();
            String JobsCompletedQuery = "SELECT JobsCompleted FROM Employees where ID=" + UserIDString + "";
            SqlCommand cmdJobsCompleted = new SqlCommand();
            cmdJobsCompleted.Connection = conn;
            cmdJobsCompleted.CommandText = JobsCompletedQuery;

            CompletedJobs = (int)cmdJobsCompleted.ExecuteScalar();
            conn.Close();

            lblJobsCompletedNum.Text = CompletedJobs.ToString();
            lblIncomeNum.Text = "£" + (CompletedJobs * 82.5).ToString();
        }
    }
}
