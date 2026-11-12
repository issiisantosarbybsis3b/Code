using System;
using System.Windows.Forms;

namespace LoginRegisterApp
{
    public partial class MainDashboard : Form
    {
        private string _fullName;

        public MainDashboard(string fullName)
        {
            InitializeComponent();
            _fullName = fullName;
            lblWelcomeUser.Text = "Welcome to your Dashboard, " + _fullName + "!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Set DialogResult to Restart or OK so Program.cs knows to loop back to login
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}