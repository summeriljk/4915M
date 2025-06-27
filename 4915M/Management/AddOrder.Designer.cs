
namespace _4915M.新文件夹
{
    partial class AddOrder
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
            lblName = new Label();
            lblCategory = new Label();
            lblBrand = new Label();
            lblDescription = new Label();
            txtName = new TextBox();
            txtBrand = new TextBox();
            txtCategory = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblName.Location = new Point(72, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 39);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblCategory.Location = new Point(26, 106);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(150, 39);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblBrand.Location = new Point(72, 174);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(104, 39);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Brand";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblDescription.Location = new Point(2, 239);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(185, 39);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtName.Location = new Point(193, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 38);
            txtName.TabIndex = 5;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtBrand.Location = new Point(193, 177);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(269, 38);
            txtBrand.TabIndex = 6;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCategory.Location = new Point(193, 106);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(269, 38);
            txtCategory.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtDescription.Location = new Point(193, 242);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(269, 125);
            txtDescription.TabIndex = 8;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnAdd.Location = new Point(26, 397);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 57);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Confirm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCancel.Location = new Point(279, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 57);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 480);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtCategory);
            Controls.Add(txtBrand);
            Controls.Add(txtName);
            Controls.Add(lblDescription);
            Controls.Add(lblBrand);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Name = "AddOrder";
            Text = "AddOrder";
            Load += AddOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private Label lblName;
        private Label lblCategory;
        private Label lblBrand;
        private Label lblDescription;
        private TextBox txtName;
        private TextBox txtBrand;
        private TextBox txtCategory;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnCancel;
    }
}