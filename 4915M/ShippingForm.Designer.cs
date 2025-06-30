namespace _4915M
{
    partial class ShippingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewOrders = new DataGridView();
            groupBox1 = new GroupBox();
            btnShip = new Button();
            cmbCourier = new ComboBox();
            label2 = new Label();
            txtTrackingNumber = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(498, 26);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(557, 251);
            dataGridViewOrders.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnShip);
            groupBox1.Controls.Add(dataGridViewOrders);
            groupBox1.Controls.Add(cmbCourier);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTrackingNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1120, 367);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shipping information";
            // 
            // btnShip
            // 
            btnShip.Location = new Point(164, 304);
            btnShip.Name = "btnShip";
            btnShip.Size = new Size(196, 29);
            btnShip.TabIndex = 4;
            btnShip.Text = "Confirm the shipment";
            btnShip.UseVisualStyleBackColor = true;
            // 
            // cmbCourier
            // 
            cmbCourier.FormattingEnabled = true;
            cmbCourier.Items.AddRange(new object[] { "SF Express", "FedEx", "UPS" });
            cmbCourier.Location = new Point(245, 192);
            cmbCourier.Name = "cmbCourier";
            cmbCourier.Size = new Size(151, 28);
            cmbCourier.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 192);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 2;
            label2.Text = "Courier companies";
            // 
            // txtTrackingNumber
            // 
            txtTrackingNumber.Location = new Point(260, 105);
            txtTrackingNumber.Name = "txtTrackingNumber";
            txtTrackingNumber.Size = new Size(125, 27);
            txtTrackingNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 105);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "order number";
            label1.Click += label1_Click;
            // 
            // ShippingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 450);
            Controls.Add(groupBox1);
            Name = "ShippingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fulfillment management";
            Load += ShippingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOrders;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTrackingNumber;
        private ComboBox cmbCourier;
        private Label label2;
        private Button btnShip;
    }
}