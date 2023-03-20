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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Needs to securely close the forms down and log the user out
            Application.OpenForms["frmLogin"].Close();
            Application.OpenForms["frmMain"].Close();
        }
    }
}
