namespace Quản_lý_Quán_Cafe.UI
{
    partial class douong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtmadouong = new TextBox();
            label2 = new Label();
            txttendouong = new TextBox();
            label3 = new Label();
            txtdongia = new TextBox();
            label4 = new Label();
            comboBoxdanhmuc = new ComboBox();
            dataGridViewdouong = new DataGridView();
            butthem = new Button();
            butsua = new Button();
            butxoa = new Button();
            butTim = new Button();
            txttimkiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdouong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 3);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã đồ uống";
            // 
            // txtmadouong
            // 
            txtmadouong.Location = new Point(161, 0);
            txtmadouong.Name = "txtmadouong";
            txtmadouong.Size = new Size(179, 27);
            txtmadouong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 40);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên đồ uống";
            // 
            // txttendouong
            // 
            txttendouong.Location = new Point(161, 33);
            txttendouong.Name = "txttendouong";
            txttendouong.Size = new Size(179, 27);
            txttendouong.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 73);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Đơn giá";
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(161, 66);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(179, 27);
            txtdongia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 107);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "Danh mục";
            // 
            // comboBoxdanhmuc
            // 
            comboBoxdanhmuc.FormattingEnabled = true;
            comboBoxdanhmuc.Location = new Point(161, 99);
            comboBoxdanhmuc.Name = "comboBoxdanhmuc";
            comboBoxdanhmuc.Size = new Size(179, 28);
            comboBoxdanhmuc.TabIndex = 7;
            comboBoxdanhmuc.SelectedIndexChanged += comboBoxdanhmuc_SelectedIndexChanged;
            // 
            // dataGridViewdouong
            // 
            dataGridViewdouong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdouong.Dock = DockStyle.Bottom;
            dataGridViewdouong.Location = new Point(0, 197);
            dataGridViewdouong.Name = "dataGridViewdouong";
            dataGridViewdouong.RowHeadersWidth = 51;
            dataGridViewdouong.Size = new Size(585, 218);
            dataGridViewdouong.TabIndex = 8;
            // 
            // butthem
            // 
            butthem.Location = new Point(380, 13);
            butthem.Name = "butthem";
            butthem.Size = new Size(94, 29);
            butthem.TabIndex = 9;
            butthem.Text = "Thêm";
            butthem.UseVisualStyleBackColor = true;
            butthem.Click += butthem_Click;
            // 
            // butsua
            // 
            butsua.Location = new Point(380, 48);
            butsua.Name = "butsua";
            butsua.Size = new Size(94, 29);
            butsua.TabIndex = 10;
            butsua.Text = "Sửa";
            butsua.UseVisualStyleBackColor = true;
            butsua.Click += butsua_Click;
            // 
            // butxoa
            // 
            butxoa.Location = new Point(380, 83);
            butxoa.Name = "butxoa";
            butxoa.Size = new Size(94, 29);
            butxoa.TabIndex = 11;
            butxoa.Text = "Xóa";
            butxoa.UseVisualStyleBackColor = true;
            butxoa.Click += butxoa_Click_1;
            // 
            // butTim
            // 
            butTim.Location = new Point(380, 137);
            butTim.Name = "butTim";
            butTim.Size = new Size(94, 29);
            butTim.TabIndex = 12;
            butTim.Text = "Tìm";
            butTim.UseVisualStyleBackColor = true;
            butTim.Click += butTim_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(161, 139);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(179, 27);
            txttimkiem.TabIndex = 13;
            // 
            // douong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txttimkiem);
            Controls.Add(butTim);
            Controls.Add(butxoa);
            Controls.Add(butsua);
            Controls.Add(butthem);
            Controls.Add(dataGridViewdouong);
            Controls.Add(comboBoxdanhmuc);
            Controls.Add(label4);
            Controls.Add(txtdongia);
            Controls.Add(label3);
            Controls.Add(txttendouong);
            Controls.Add(label2);
            Controls.Add(txtmadouong);
            Controls.Add(label1);
            Name = "douong";
            Size = new Size(585, 415);
            ((System.ComponentModel.ISupportInitialize)dataGridViewdouong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtmadouong;
        private Label label2;
        private TextBox txttendouong;
        private Label label3;
        private TextBox txtdongia;
        private Label label4;
        private ComboBox comboBoxdanhmuc;
        private DataGridView dataGridViewdouong;
        private Button butthem;
        private Button butsua;
        private Button butxoa;
        private Button butTim;
        private TextBox txttimkiem;
    }
}
