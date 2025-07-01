using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace _4915M
{
    public partial class AfterSalesForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string ApiUrl = "https://localhost:7174";

        public AfterSalesForm()
        {
            InitializeComponent();
            SetupHttpClient();
        }

        private void SetupHttpClient()
        {
            _httpClient.BaseAddress = new Uri(ApiUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
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
                var request = new
                {
                    OrderNumber = txtOrderNumber.Text.Trim(),
                    IssueType = cmbIssueType.SelectedItem.ToString(),
                    ResolutionStatus = cmbResolutionStatus.SelectedItem?.ToString(),
                    SubmissionDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("requests", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Your after-sales request has been submitted successfully.\nOur team will contact you shortly.",
                        "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Unable to submit request:\n{response.ReasonPhrase}\n{errorContent}",
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