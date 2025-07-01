using System;
using System.Windows.Forms;
using DatabaseAccessController;

namespace _4915M
{
    public partial class AfterSalesForm : Form
    {
        private string connectionString = "server=localhost;port=3306;user id=root;password=;database=company;charset=utf8;";
        private dboAfterSalesController afterSalesController;

        public AfterSalesForm()
        {
            InitializeComponent();
            afterSalesController = new dboAfterSalesController(connectionString);
        }

        private async void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text))
            {
                MessageBox.Show("Please enter a valid order number", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbIssueType.SelectedItem == null)
            {
                MessageBox.Show("Please select an issue type", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int orderId = int.Parse(txtOrderNumber.Text.Trim());
                string issueType = cmbIssueType.SelectedItem.ToString();
                string description = ""; 

                int rowsAffected = afterSalesController.CreateRequest(orderId, issueType, description);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Your after-sales request has been submitted successfully.\nOur team will contact you shortly.",
                        "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Unable to submit request.",
                        "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred:\n{ex.Message}",
                    "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtOrderNumber.Clear();
            cmbIssueType.SelectedIndex = -1;
            cmbResolutionStatus.SelectedIndex = 0;
            txtOrderNumber.Focus();
        }

        private void AfterSalesForm_Load(object sender, EventArgs e)
        {

        }
    }
}