namespace _4915M
{
    partial class pManagement
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            btnrefresh = new Button();
            textBox1 = new TextBox();
            btnSearch = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(506, 476);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnAdd.Location = new Point(581, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 68);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add product order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += this.button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnDelete.Location = new Point(762, 48);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 68);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete product order";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnModify.Location = new Point(581, 185);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(149, 68);
            btnModify.TabIndex = 3;
            btnModify.Text = "Modify order information";
            btnModify.UseVisualStyleBackColor = true;
            // 
            // btnrefresh
            // 
            btnrefresh.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnrefresh.Location = new Point(762, 185);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(149, 68);
            btnrefresh.TabIndex = 4;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += this.button4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox1.Location = new Point(571, 311);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 38);
            textBox1.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSearch.Location = new Point(762, 299);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.Yes;
            btnSearch.Size = new Size(149, 68);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Order inquiry";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += this.button1_Click_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Toy ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Category";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "brand";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "inventory";
            Column5.Name = "Column5";
            // 
            // pManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 501);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(btnrefresh);
            Controls.Add(btnModify);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "pManagement";
            Text = "Product Management";
            Load += this.pManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnModify;
        private Button btnrefresh;
        private TextBox textBox1;
        private Button btnSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}