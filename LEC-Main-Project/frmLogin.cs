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

    public partial class frmLogin : Form
    {
        // Database variables
        SqlConnection conn = new SqlConnection(@"");
        // Login related variables for global use
        static string username;
        static string password;

        public frmLogin()
        {
            InitializeComponent();
            // Sets max character length for username and password
            txtUsername.MaxLength = 12;
            txtPassword.MaxLength = 12;
        }

        // Failed login attempts stored globally as it will reset if in function.
        static int failedLoginAttempts = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Gets the user input and assigns to the variables
            password = txtPassword.Text;
            username = txtUsername.Text;

            // Database connection and selecting login credentials
            conn.Open();
            String query = "SELECT * FROM Login where CONVERT(VARCHAR, Username)='" + username + "' AND CONVERT(VARCHAR, Password)='" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            // Checks if user input matches login credentials
            if (dtable.Rows.Count > 0 && username == txtUsername.Text && password == txtPassword.Text)
            {
                // Opens the main form and hides the login form
                this.Hide();
                frmMain frmMain = new frmMain(username);
                // Assign currentUser to a variable
                frmMain.ShowDialog();
                
            }
            else
            {
                // Gives the user three attempts to login before shutting down
                MessageBox.Show("Invalid Login!");
                failedLoginAttempts += 1;
                if (failedLoginAttempts >= 3)
                {
                    this.Close();
                }
            }
            conn.Close();
        }
    }
}
