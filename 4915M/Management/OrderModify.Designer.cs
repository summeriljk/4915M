namespace _4915M.新文件夹
{
    partial class OrderModify
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
            btnCancel = new Button();
            btnAdd = new Button();
            txtDescription = new TextBox();
            txtBrand = new TextBox();
            txtCategory = new TextBox();
            txtQuantity = new TextBox();
            txtTname = new TextBox();
            rbtDescription = new RadioButton();
            rbtQuantity = new RadioButton();
            rbtBrand = new RadioButton();
            rbtCategory = new RadioButton();
            lblTID = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(408, 419);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 75);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(184, 419);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 75);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Confirm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtDescription.Location = new Point(298, 287);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(276, 38);
            txtDescription.TabIndex = 21;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtBrand.Location = new Point(298, 169);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(276, 38);
            txtBrand.TabIndex = 20;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCategory.Location = new Point(298, 99);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(276, 38);
            txtCategory.TabIndex = 19;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtQuantity.Location = new Point(298, 228);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(276, 38);
            txtQuantity.TabIndex = 18;
            // 
            // txtTname
            // 
            txtTname.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtTname.Location = new Point(298, 32);
            txtTname.Name = "txtTname";
            txtTname.Size = new Size(276, 38);
            txtTname.TabIndex = 12;
            // 
            // rbtDescription
            // 
            rbtDescription.AutoSize = true;
            rbtDescription.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtDescription.Location = new Point(98, 287);
            rbtDescription.Name = "rbtDescription";
            rbtDescription.Size = new Size(171, 35);
            rbtDescription.TabIndex = 25;
            rbtDescription.TabStop = true;
            rbtDescription.Text = "Description";
            rbtDescription.UseVisualStyleBackColor = true;
            // 
            // rbtQuantity
            // 
            rbtQuantity.AutoSize = true;
            rbtQuantity.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtQuantity.Location = new Point(98, 228);
            rbtQuantity.Name = "rbtQuantity";
            rbtQuantity.Size = new Size(139, 35);
            rbtQuantity.TabIndex = 26;
            rbtQuantity.TabStop = true;
            rbtQuantity.Text = "Quantity";
            rbtQuantity.UseVisualStyleBackColor = true;
            // 
            // rbtBrand
            // 
            rbtBrand.AutoSize = true;
            rbtBrand.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtBrand.Location = new Point(98, 169);
            rbtBrand.Name = "rbtBrand";
            rbtBrand.Size = new Size(104, 35);
            rbtBrand.TabIndex = 27;
            rbtBrand.TabStop = true;
            rbtBrand.Text = "Brand";
            rbtBrand.UseVisualStyleBackColor = true;
            // 
            // rbtCategory
            // 
            rbtCategory.AutoSize = true;
            rbtCategory.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtCategory.Location = new Point(98, 100);
            rbtCategory.Name = "rbtCategory";
            rbtCategory.Size = new Size(142, 35);
            rbtCategory.TabIndex = 28;
            rbtCategory.TabStop = true;
            rbtCategory.Text = "Category";
            rbtCategory.UseVisualStyleBackColor = true;
            // 
            // lblTID
            // 
            lblTID.AutoSize = true;
            lblTID.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTID.Location = new Point(121, 32);
            lblTID.Name = "lblTID";
            lblTID.Size = new Size(93, 31);
            lblTID.TabIndex = 29;
            lblTID.Text = "Toy ID";
            // 
            // OrderModify
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(lblTID);
            Controls.Add(rbtCategory);
            Controls.Add(rbtBrand);
            Controls.Add(rbtQuantity);
            Controls.Add(rbtDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtBrand);
            Controls.Add(txtCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtTname);
            Name = "OrderModify";
            Text = "OrderModify";
            Load += OrderModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtDescription;
        private TextBox txtBrand;
        private TextBox txtCategory;
        private TextBox txtQuantity;
        private TextBox txtTname;
        private RadioButton rbtDescription;
        private RadioButton rbtQuantity;
        private RadioButton rbtBrand;
        private RadioButton rbtCategory;
        private Label lblTID;
    }
}