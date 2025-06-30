namespace _4915M
{
    partial class AddProcurementOrder
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
            txtMaterialName = new TextBox();
            lblMaterialName = new Label();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();

            txtMaterialName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtMaterialName.Location = new Point(246, 57);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(276, 38);
            txtMaterialName.TabIndex = 0;

            lblMaterialName.AutoSize = true;
            lblMaterialName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblMaterialName.Location = new Point(76, 57);
            lblMaterialName.Name = "lblMaterialName";
            lblMaterialName.Size = new Size(159, 31);
            lblMaterialName.TabIndex = 1;
            lblMaterialName.Text = "Material Name";

            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblQuantity.Location = new Point(76, 124);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(121, 31);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";

            txtQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtQuantity.Location = new Point(246, 124);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(276, 38);
            txtQuantity.TabIndex = 3;

            btnAdd.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(132, 444);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 75);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Confirm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            btnCancel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(356, 444);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 75);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 575);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(lblMaterialName);
            Controls.Add(txtMaterialName);
            Name = "AddProcurementOrder";
            Text = "Add Procurement Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaterialName;
        private Label lblMaterialName;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnCancel;
    }
}