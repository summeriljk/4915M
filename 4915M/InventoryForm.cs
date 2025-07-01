using System;
using System.Data;
using System.Windows.Forms;
using DatabaseAccessController;

namespace _4915M
{
    public partial class InventoryForm : Form
    {
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        private dboInventoryController inventoryController;
        private DataTable _inventoryTable;

        public InventoryForm()
        {
            InitializeComponent();
            // Set English text for form and controls
            this.Text = "Inventory Management";
            groupBox1.Text = "Inventory Operations";
            label1.Text = "Adjustment Quantity:";
            label2.Text = "Adjustment Reason:";
            btnSubmit.Text = "Submit Adjustment";

            inventoryController = new dboInventoryController(connectionString);
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
            dataGridView1.DataSource = _inventoryTable;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadInventoryData()
        {
            try
            {
                _inventoryTable = inventoryController.GetLowStockProducts();

                if (!_inventoryTable.Columns.Contains("Status"))
                {
                    _inventoryTable.Columns.Add("Status", typeof(string));
                }

                foreach (DataRow row in _inventoryTable.Rows)
                {
                    int stock = Convert.ToInt32(row["Stock"]);
                    int minimumStockLevel = Convert.ToInt32(row["MinimumStockLevel"]);
                    row["Status"] = stock < minimumStockLevel ? "Low Stock" : "Normal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load inventory data: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please enter adjustment reason",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            var productId = (int)selectedRow.Cells["Id"].Value;
            var adjustment = (int)numericUpDownAdjustment.Value;
            var reason = txtReason.Text;
            var adminId = 1; 

            try
            {
                int rowsAffected = inventoryController.AdjustInventory(productId, adjustment, reason, adminId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inventory adjustment successful",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventoryData();
                    dataGridView1.DataSource = _inventoryTable;
                    txtReason.Clear();
                    numericUpDownAdjustment.Value = 0;
                }
                else
                {
                    MessageBox.Show("Inventory adjustment failed",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
