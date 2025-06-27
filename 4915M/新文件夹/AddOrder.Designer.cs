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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox1.Location = new Point(193, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 38);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox2.Location = new Point(193, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 38);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox3.Location = new Point(193, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 38);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox4.Location = new Point(193, 242);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(269, 125);
            textBox4.TabIndex = 8;
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
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 480);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblDescription);
            Controls.Add(lblBrand);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Name = "AddOrder";
            Text = "AddOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCategory;
        private Label lblBrand;
        private Label lblDescription;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnAdd;
        private Button btnCancel;
    }
}