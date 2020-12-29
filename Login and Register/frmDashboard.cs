using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Register
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void visitWeb_Click(object sender, EventArgs e)
        {
            bmBrowser.Navigate("https://bloggingmetrics.com/");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye Sayan");
            Application.Exit();
        }
    }
}
