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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(douong));
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridViewdouong = new DataGridView();
            panel2 = new Panel();
            txttimkiem = new TextBox();
            butTim = new Button();
            imageList1 = new ImageList(components);
            butxoa = new Button();
            butsua = new Button();
            butthem = new Button();
            comboBoxdanhmuc = new ComboBox();
            label4 = new Label();
            txtdongia = new TextBox();
            label3 = new Label();
            txttendouong = new TextBox();
            label2 = new Label();
            txtmadouong = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdouong).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 415);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewdouong);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(585, 236);
            panel3.TabIndex = 41;
            // 
            // dataGridViewdouong
            // 
            dataGridViewdouong.BackgroundColor = Color.WhiteSmoke;
            dataGridViewdouong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdouong.Dock = DockStyle.Fill;
            dataGridViewdouong.GridColor = Color.LightGray;
            dataGridViewdouong.Location = new Point(0, 0);
            dataGridViewdouong.Name = "dataGridViewdouong";
            dataGridViewdouong.RowHeadersWidth = 51;
            dataGridViewdouong.Size = new Size(585, 236);
            dataGridViewdouong.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(txttimkiem);
            panel2.Controls.Add(butTim);
            panel2.Controls.Add(butxoa);
            panel2.Controls.Add(butsua);
            panel2.Controls.Add(butthem);
            panel2.Controls.Add(comboBoxdanhmuc);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtdongia);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txttendouong);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtmadouong);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 179);
            panel2.TabIndex = 28;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(199, 146);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(179, 27);
            txttimkiem.TabIndex = 40;
            // 
            // butTim
            // 
            butTim.ImageAlign = ContentAlignment.MiddleLeft;
            butTim.ImageIndex = 3;
            butTim.ImageList = imageList1;
            butTim.Location = new Point(418, 144);
            butTim.Name = "butTim";
            butTim.Padding = new Padding(10, 0, 0, 0);
            butTim.Size = new Size(112, 29);
            butTim.TabIndex = 39;
            butTim.Text = "Tìm";
            butTim.UseVisualStyleBackColor = true;
            butTim.Click += butTim_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-pencil-32.png");
            imageList1.Images.SetKeyName(1, "icons8-close-32.png");
            imageList1.Images.SetKeyName(2, "icons8-add-32.png");
            imageList1.Images.SetKeyName(3, "icons8-find-32.png");
            // 
            // butxoa
            // 
            butxoa.ImageAlign = ContentAlignment.MiddleLeft;
            butxoa.ImageIndex = 1;
            butxoa.ImageList = imageList1;
            butxoa.Location = new Point(418, 90);
            butxoa.Name = "butxoa";
            butxoa.Padding = new Padding(10, 0, 0, 0);
            butxoa.Size = new Size(112, 29);
            butxoa.TabIndex = 38;
            butxoa.Text = "Xóa";
            butxoa.UseVisualStyleBackColor = true;
            butxoa.Click += butxoa_Click_1;
            // 
            // butsua
            // 
            butsua.ImageAlign = ContentAlignment.MiddleLeft;
            butsua.ImageIndex = 0;
            butsua.ImageList = imageList1;
            butsua.Location = new Point(418, 55);
            butsua.Name = "butsua";
            butsua.Padding = new Padding(10, 0, 0, 0);
            butsua.Size = new Size(112, 29);
            butsua.TabIndex = 37;
            butsua.Text = "Sửa";
            butsua.UseVisualStyleBackColor = true;
            butsua.Click += butsua_Click;
            // 
            // butthem
            // 
            butthem.ImageAlign = ContentAlignment.MiddleLeft;
            butthem.ImageIndex = 2;
            butthem.ImageList = imageList1;
            butthem.Location = new Point(418, 20);
            butthem.Name = "butthem";
            butthem.Padding = new Padding(10, 0, 0, 0);
            butthem.Size = new Size(112, 29);
            butthem.TabIndex = 36;
            butthem.Text = "Thêm";
            butthem.UseVisualStyleBackColor = true;
            butthem.Click += butthem_Click;
            // 
            // comboBoxdanhmuc
            // 
            comboBoxdanhmuc.FormattingEnabled = true;
            comboBoxdanhmuc.Location = new Point(199, 106);
            comboBoxdanhmuc.Name = "comboBoxdanhmuc";
            comboBoxdanhmuc.Size = new Size(179, 28);
            comboBoxdanhmuc.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 114);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 34;
            label4.Text = "Danh mục";
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(199, 73);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(179, 27);
            txtdongia.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 80);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 32;
            label3.Text = "Đơn giá";
            // 
            // txttendouong
            // 
            txttendouong.Location = new Point(199, 40);
            txttendouong.Name = "txttendouong";
            txttendouong.Size = new Size(179, 27);
            txttendouong.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 47);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 30;
            label2.Text = "Tên đồ uống";
            // 
            // txtmadouong
            // 
            txtmadouong.Location = new Point(199, 7);
            txtmadouong.Name = "txtmadouong";
            txtmadouong.Size = new Size(179, 27);
            txtmadouong.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 10);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 28;
            label1.Text = "Mã đồ uống";
            // 
            // douong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "douong";
            Size = new Size(585, 415);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewdouong).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridViewdouong;
        private Panel panel2;
        private TextBox txttimkiem;
        private Button butTim;
        private Button butxoa;
        private Button butsua;
        private Button butthem;
        private ComboBox comboBoxdanhmuc;
        private Label label4;
        private TextBox txtdongia;
        private Label label3;
        private TextBox txttendouong;
        private Label label2;
        private TextBox txtmadouong;
        private Label label1;
        private ImageList imageList1;
    }
}
