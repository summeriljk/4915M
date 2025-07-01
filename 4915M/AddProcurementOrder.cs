using System;
using System.Windows.Forms;
using DatabaseAccessController;
using MySql.Data.MySqlClient;

namespace _4915M
{
    public partial class AddProcurementOrder : Form
    {
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        private dboMaterialProcurementController procurementController;
        private MaterialProcurementForm parentForm;

        public AddProcurementOrder(MaterialProcurementForm parent)
        {
            InitializeComponent();
            procurementController = new dboMaterialProcurementController(connectionString);
            parentForm = parent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string materialName = txtMaterialName.Text.Trim();
                string quantity = txtQuantity.Text.Trim();

                if (string.IsNullOrEmpty(materialName))
                {
                    MessageBox.Show("Material name is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(quantity, out int parsedQuantity) || parsedQuantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string insertSql = @"
                            INSERT INTO procurement_orders (material_name, quantity)
                            VALUES (@materialName, @quantity)";

                        using (MySqlCommand cmd = new MySqlCommand(insertSql, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@materialName", materialName);
                            cmd.Parameters.AddWithValue("@quantity", parsedQuantity);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Procurement order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                parentForm.RefreshProcurementOrders();
                                this.Close();
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Failed to add procurement order.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error occurred while adding procurement order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}