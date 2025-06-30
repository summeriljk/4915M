namespace _4915M
{
    partial class AdminMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAfterSales;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnShipping;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAfterSales = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btnAfterSales.Location = new System.Drawing.Point(20, 20);
            this.btnAfterSales.Name = "btnAfterSales";
            this.btnAfterSales.Size = new System.Drawing.Size(500, 400);
            this.btnAfterSales.TabIndex = 0;
            this.btnAfterSales.Text = "After Sales Service";
            this.btnAfterSales.UseVisualStyleBackColor = true;
            this.btnAfterSales.Click += new System.EventHandler(this.btnAfterSales_Click);
 
            this.btnInventory.Location = new System.Drawing.Point(20, 80);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(500, 400);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory Management";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);

            this.btnShipping.Location = new System.Drawing.Point(20, 140);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(500, 400);
            this.btnShipping.TabIndex = 2;
            this.btnShipping.Text = "Shipping Management";
            this.btnShipping.UseVisualStyleBackColor = true;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);

            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnAfterSales);
            this.Name = "AdminMainForm";
            this.Text = "Admin Main Form";
            this.ResumeLayout(false);

        }
    }
}