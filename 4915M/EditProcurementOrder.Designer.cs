namespace _4915M
{
    partial class EditProcurementOrder
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
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtMaterialName
            // 
            txtMaterialName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtMaterialName.Location = new Point(362, 67);
            txtMaterialName.Margin = new Padding(4);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(354, 46);
            txtMaterialName.TabIndex = 0;
            // 
            // lblMaterialName
            // 
            lblMaterialName.AutoSize = true;
            lblMaterialName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblMaterialName.Location = new Point(98, 67);
            lblMaterialName.Margin = new Padding(4, 0, 4, 0);
            lblMaterialName.Name = "lblMaterialName";
            lblMaterialName.Size = new Size(239, 40);
            lblMaterialName.TabIndex = 1;
            lblMaterialName.Text = "Material Name";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblQuantity.Location = new Point(98, 146);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(147, 40);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtQuantity.Location = new Point(362, 140);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(354, 46);
            txtQuantity.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(98, 396);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(213, 88);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(457, 396);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(213, 88);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditProcurementOrder
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 540);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(lblMaterialName);
            Controls.Add(txtMaterialName);
            Margin = new Padding(4);
            Name = "EditProcurementOrder";
            Text = "Edit Procurement Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaterialName;
        private Label lblMaterialName;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnCancel;
    }
}