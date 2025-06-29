namespace _4915M
{
    partial class InventoryForm
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
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(783, 395);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(txtReason);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDownAdjustment);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(699, 261);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "inventory";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(208, 197);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(149, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(247, 127);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(125, 27);
            txtReason.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 130);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 2;
            label2.Text = "Reason for adjustment";
            // 
            // numericUpDownAdjustment
            // 
            numericUpDownAdjustment.Location = new Point(247, 62);
            numericUpDownAdjustment.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownAdjustment.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDownAdjustment.Name = "numericUpDownAdjustment";
            numericUpDownAdjustment.Size = new Size(150, 27);
            numericUpDownAdjustment.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 69);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "quantity";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
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

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown numericUpDownAdjustment;
        private Label label1;
        private TextBox txtReason;
        private Button btnSubmit;
    }
}