using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace _4915M
{
    public partial class InventoryForm : Form
    {
        private readonly HttpClient _httpClient;
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

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7147") 
            };
        }

        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            await LoadInventoryData();
            dataGridView1.DataSource = _inventoryTable;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private async Task LoadInventoryData()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/Inventory/warning");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var products = JsonSerializer.Deserialize<Product[]>(content);

                _inventoryTable = new DataTable();
                _inventoryTable.Columns.Add("Product ID", typeof(int));
                _inventoryTable.Columns.Add("Product Name", typeof(string));
                _inventoryTable.Columns.Add("Current Stock", typeof(int));
                _inventoryTable.Columns.Add("Minimum Stock", typeof(int));
                _inventoryTable.Columns.Add("Status", typeof(string));

                foreach (var product in products)
                {
                    _inventoryTable.Rows.Add(
                        product.Id,
                        product.Name,
                        product.Stock,
                        product.MinimumStockLevel,
                        product.Stock < product.MinimumStockLevel ? "Low Stock" : "Normal"
                    );
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

        private async void btnSubmit_Click(object sender, EventArgs e)
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
            var productId = (int)selectedRow.Cells["Product ID"].Value;
            var adjustment = (int)numericUpDownAdjustment.Value;
            var reason = txtReason.Text;

            try
            {
                var request = new InventoryAdjustRequest
                {
                    ProductId = productId,
                    AdjustAmount = adjustment,
                    Reason = reason
                };

                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("api/Inventory/adjust", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Inventory adjustment successful",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadInventoryData();
                    dataGridView1.DataSource = _inventoryTable;
                    txtReason.Clear();
                    numericUpDownAdjustment.Value = 0;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Inventory adjustment failed: {response.ReasonPhrase}\n{errorContent}",
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

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int MinimumStockLevel { get; set; }
    }

    public class InventoryAdjustRequest
    {
        public int ProductId { get; set; }
        public int AdjustAmount { get; set; }
        public string Reason { get; set; }
    }
}
