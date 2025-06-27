using System;
using System.Windows.Forms;
using DatabaseAccessController;
using Microsoft.Extensions.Configuration;
using System.Data; 
using MySql.Data.MySqlClient;

namespace _4915M
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUName.Text != "" && txtPsw.Text != "")
            {
                string connectionString = "your_connection_string_here";
                dboUserLoginVerification loginVerifier = new dboUserLoginVerification(connectionString);

                string username = txtUName.Text;
                string password = txtPsw.Text;
                bool isUser = IsUser();

                bool isAuthenticated = loginVerifier.VerifyUserLogin(username, password, isUser);

                if (isAuthenticated)
                {
                    MessageBox.Show("Login successful");
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect");
                }
            }
        }

        public bool IsUser()
        {
            return rbtUser.Checked;
        }
    }
}