namespace _4915M
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;

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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnSubmit = new Button();
            txtReason = new TextBox();
            label2 = new Label();
            numericUpDownAdjustment = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdjustment).BeginInit();
            SuspendLayout();

            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(446, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(529, 206);
            dataGridView1.TabIndex = 0;

            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtReason);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDownAdjustment);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(981, 358);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "inventory";

            btnSubmit.Location = new Point(167, 288);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(292, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "submit";
            btnSubmit.UseVisualStyleBackColor = true;

            txtReason.Location = new Point(259, 192);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(125, 27);
            txtReason.TabIndex = 3;

            label2.AutoSize = true;
            label2.Location = new Point(24, 195);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 2;
            label2.Text = "Reason for adjustment";

            numericUpDownAdjustment.Location = new Point(259, 114);
            numericUpDownAdjustment.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownAdjustment.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDownAdjustment.Name = "numericUpDownAdjustment";
            numericUpDownAdjustment.Size = new Size(150, 27);
            numericUpDownAdjustment.TabIndex = 1;

            label1.AutoSize = true;
            label1.Location = new Point(59, 121);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "quantity";

            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 450);
            Controls.Add(groupBox1);
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdjustment).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown numericUpDownAdjustment;
        private Label label1;
        private TextBox txtReason;
        private Button btnSubmit;
    }
}