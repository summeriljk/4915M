using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M
{
    public partial class ShippingForm : Form
    {
        private readonly HttpClient _httpClient;
        private List<Order> _pendingOrders = new List<Order>();

        public ShippingForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7147") 
            };
        }

        private async void ShippingForm_Load(object sender, EventArgs e)
        {
            await LoadPendingOrders();
        }

        private async Task LoadPendingOrders()
        {
            try
            {
                var response = await _httpClient.GetAsync("shipping/pending");
                if (response.IsSuccessStatusCode)
                {
                    _pendingOrders = await response.Content.ReadFromJsonAsync<List<Order>>();
                    dataGridViewOrders.DataSource = _pendingOrders;
                }
                else
                {
                    MessageBox.Show("Failed to load pending orders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnShip_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to ship.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTrackingNumber.Text))
            {
                MessageBox.Show("Please enter a tracking number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCourier.SelectedItem == null)
            {
                MessageBox.Show("Please select a courier.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedOrderId = (int)dataGridViewOrders.SelectedRows[0].Cells["Id"].Value;
            var request = new Shipping
            {
                TrackingNumber = txtTrackingNumber.Text,
                Courier = cmbCourier.SelectedItem.ToString()
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync($"shipping/{selectedOrderId}/ship", request);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Order shipped successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadPendingOrders(); 
                    txtTrackingNumber.Clear();
                    cmbCourier.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Failed to confirm shipping.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }

    public class Order
    {
        public int order_id { get; set; }
        public int customerID { get; set; }
        public int toy_id { get; set; }
        public int quantity { get; set; }
        public DateTime order_date { get; set; }
    }

    public class Shipping
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public string Courier { get; set; }
        public string Status { get; set; } // "pending", "shipped", "delivered", "failed"
        public DateTime CreatedAt { get; set; }
    }
}
