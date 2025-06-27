using System;
using System.Windows.Forms;
using DatabaseAccessController;
using MySql.Data.MySqlClient;
using SDP_EntityModels;

namespace _4915M.新文件夹
{
    public partial class AddOrder : Form
    {
        private dboToyOrderController orderController;
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";

        public AddOrder()
        {
            InitializeComponent();
            orderController = new dboToyOrderController(connectionString);
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}