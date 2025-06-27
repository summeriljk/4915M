using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccessController;

namespace _4915M
{
    public partial class pManagement : Form
    {
        private dboDatabaseController dbController;
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        public pManagement()
        {
            InitializeComponent();
            dbController = new dboDatabaseController(connectionString);
        }

        private void pManagement_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlCmd = "SELECT * FROM toydatabase";
                DataTable toyDataTable = dbController.GetData(sqlCmd);
                dataGridView1.DataSource = toyDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
