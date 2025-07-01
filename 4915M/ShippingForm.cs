using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DatabaseAccessController;

namespace _4915M
{
    public partial class ShippingForm : Form
    {
        private List<Order> _pendingOrders = new List<Order>();
        private dboShippingController _shippingController;

        public ShippingForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
            _shippingController = new dboShippingController(connectionString);
        }

        private void ShippingForm_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }

        private void LoadPendingOrders()
        {
            try
            {
                DataTable dt = _shippingController.GetPendingOrders();
                _pendingOrders = new List<Order>();

                foreach (DataRow row in dt.Rows)
                {
                    _pendingOrders.Add(new Order
                    {
                        order_id = Convert.ToInt32(row["order_id"]),
                        customerID = Convert.ToInt32(row["customerID"]),
                        toy_id = Convert.ToInt32(row["toy_id"]),
                        quantity = Convert.ToInt32(row["quantity"]),
                        order_date = Convert.ToDateTime(row["order_date"])
                    });
                }

                dataGridViewOrders.DataSource = _pendingOrders;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedOrderId = (int)dataGridViewOrders.SelectedRows[0].Cells["order_id"].Value;
            string trackingNumber = txtTrackingNumber.Text;
            string courier = cmbCourier.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(trackingNumber) || string.IsNullOrEmpty(courier))
            {
                MessageBox.Show("Please enter tracking number and courier", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int result = _shippingController.AddShippingInfo(selectedOrderId, trackingNumber, courier, "Shipped");
                if (result > 0)
                {
                    MessageBox.Show("Shipping confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPendingOrders(); 
                    txtTrackingNumber.Clear();
                    cmbCourier.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Shipping failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
}