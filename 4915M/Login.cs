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
        private readonly IConfiguration _configuration;

        public Login()
        {
            InitializeComponent();
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUName.Text != "" && txtPsw.Text != "")
            {
                string connectionString = _configuration.GetConnectionString("DefaultConnection");
                dboUserLoginVerification loginVerifier = new dboUserLoginVerification(connectionString);

                string username = txtUName.Text;
                string password = txtPsw.Text;
                bool isUser = IsUser();

                bool isAuthenticated = loginVerifier.VerifyUserLogin(username, password, isUser);

                if (isAuthenticated)
                {
                    MessageBox.Show("Login successful");
                    this.Hide();
                    pManagement pManagement = new pManagement();
                    pManagement.Show();
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