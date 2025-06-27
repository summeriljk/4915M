using System;
using System.Data;
using System.Windows.Forms;
using _4915M.Management;
using _4915M.新文件夹;
using DatabaseAccessController;

namespace _4915M
{
    public partial class pManagement : Form
    {
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        private dboToyOrderController toyOrderController;
        private int currentCustomerID = 1;

        public pManagement()
        {
            InitializeComponent();
            toyOrderController = new dboToyOrderController(connectionString);
            LoadToysForCustomer(currentCustomerID);
        }

        private void LoadToysForCustomer(int customerID)
        {
            try
            {
                DataTable toysData = toyOrderController.GetToysByCustomer(customerID);
                dataGridView1.DataSource = toysData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading toys: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadToysForCustomer(currentCustomerID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string toyName = txtToyID.Text;

            try
            {
                DataTable searchResult = toyOrderController.SearchOrders(currentCustomerID, toyName);
                dataGridView1.DataSource = searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching orders: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int toyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                try
                {
                    int rowsAffected = toyOrderController.DeleteOrder(currentCustomerID, toyID);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order deleted successfully");
                        LoadToysForCustomer(currentCustomerID);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete order");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting order: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrder addOrderForm = new AddOrder(this, currentCustomerID);
            addOrderForm.ShowDialog();
        }

        public void RefreshOrders()
        {
            LoadToysForCustomer(currentCustomerID);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int toyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ToyID"].Value);

                OrderModify modifyForm = new OrderModify(this);

                modifyForm.SetToyID(toyID);

                modifyForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}