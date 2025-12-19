namespace Quản_lý_Quán_Cafe.UI
{
    partial class NhânViên
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhânViên));
            panel1 = new Panel();
            label1 = new Label();
            panelBàn = new Panel();
            lblban = new Label();
            flowLayoutPanelBan = new FlowLayoutPanel();
            panelOrder = new Panel();
            panel4 = new Panel();
            dataGridViewchitiethoadon = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridDoUong = new DataGridView();
            txttendouong = new TextBox();
            txtdongia = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtsoluong = new TextBox();
            butthemmon = new Button();
            imageList1 = new ImageList(components);
            comboDM = new ComboBox();
            butInhoadon = new Button();
            butthanhtoan = new Button();
            panel1.SuspendLayout();
            panelBàn.SuspendLayout();
            panelOrder.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewchitiethoadon).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDoUong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 31);
            label1.TabIndex = 0;
            label1.Text = "Nhân Viên";
            // 
            // panelBàn
            // 
            panelBàn.BorderStyle = BorderStyle.FixedSingle;
            panelBàn.Controls.Add(lblban);
            panelBàn.Controls.Add(flowLayoutPanelBan);
            panelBàn.Dock = DockStyle.Left;
            panelBàn.Location = new Point(0, 53);
            panelBàn.Name = "panelBàn";
            panelBàn.Size = new Size(231, 543);
            panelBàn.TabIndex = 1;
            // 
            // lblban
            // 
            lblban.AutoSize = true;
            lblban.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblban.Location = new Point(11, 6);
            lblban.Name = "lblban";
            lblban.Size = new Size(48, 28);
            lblban.TabIndex = 1;
            lblban.Text = "Bàn";
            // 
            // flowLayoutPanelBan
            // 
            flowLayoutPanelBan.Location = new Point(3, 40);
            flowLayoutPanelBan.Name = "flowLayoutPanelBan";
            flowLayoutPanelBan.Size = new Size(227, 501);
            flowLayoutPanelBan.TabIndex = 0;
            // 
            // panelOrder
            // 
            panelOrder.BorderStyle = BorderStyle.FixedSingle;
            panelOrder.Controls.Add(panel4);
            panelOrder.Controls.Add(panel2);
            panelOrder.Controls.Add(butInhoadon);
            panelOrder.Controls.Add(butthanhtoan);
            panelOrder.Dock = DockStyle.Fill;
            panelOrder.Location = new Point(231, 53);
            panelOrder.Name = "panelOrder";
            panelOrder.Size = new Size(569, 543);
            panelOrder.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewchitiethoadon);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 288);
            panel4.Name = "panel4";
            panel4.Size = new Size(567, 209);
            panel4.TabIndex = 15;
            // 
            // dataGridViewchitiethoadon
            // 
            dataGridViewchitiethoadon.BackgroundColor = Color.WhiteSmoke;
            dataGridViewchitiethoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewchitiethoadon.Dock = DockStyle.Fill;
            dataGridViewchitiethoadon.GridColor = Color.LightGray;
            dataGridViewchitiethoadon.Location = new Point(0, 0);
            dataGridViewchitiethoadon.Name = "dataGridViewchitiethoadon";
            dataGridViewchitiethoadon.RowHeadersWidth = 51;
            dataGridViewchitiethoadon.Size = new Size(567, 209);
            dataGridViewchitiethoadon.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txttendouong);
            panel2.Controls.Add(txtdongia);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtsoluong);
            panel2.Controls.Add(butthemmon);
            panel2.Controls.Add(comboDM);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 288);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridDoUong);
            panel3.Location = new Point(-1, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(570, 141);
            panel3.TabIndex = 22;
            // 
            // dataGridDoUong
            // 
            dataGridDoUong.BackgroundColor = Color.WhiteSmoke;
            dataGridDoUong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDoUong.Dock = DockStyle.Fill;
            dataGridDoUong.GridColor = Color.LightGray;
            dataGridDoUong.Location = new Point(0, 0);
            dataGridDoUong.Name = "dataGridDoUong";
            dataGridDoUong.RowHeadersWidth = 51;
            dataGridDoUong.Size = new Size(570, 141);
            dataGridDoUong.TabIndex = 15;
            // 
            // txttendouong
            // 
            txttendouong.Location = new Point(102, 186);
            txttendouong.Name = "txttendouong";
            txttendouong.Size = new Size(125, 27);
            txttendouong.TabIndex = 21;
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(102, 219);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(125, 27);
            txtdongia.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 193);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 19;
            label4.Text = "Đồ uống";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 226);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 18;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 254);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 17;
            label2.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(102, 251);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(125, 27);
            txtsoluong.TabIndex = 16;
            // 
            // butthemmon
            // 
            butthemmon.ImageAlign = ContentAlignment.MiddleLeft;
            butthemmon.ImageIndex = 4;
            butthemmon.ImageList = imageList1;
            butthemmon.Location = new Point(286, 207);
            butthemmon.Name = "butthemmon";
            butthemmon.Padding = new Padding(10, 0, 0, 0);
            butthemmon.Size = new Size(137, 51);
            butthemmon.TabIndex = 15;
            butthemmon.Text = "Thêm món";
            butthemmon.UseVisualStyleBackColor = true;
            butthemmon.Click += butthemmon_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-add-32.png");
            imageList1.Images.SetKeyName(1, "icons8-pay-50.png");
            imageList1.Images.SetKeyName(2, "icons8-pay-50-2.png");
            imageList1.Images.SetKeyName(3, "icons8-print-32.png");
            imageList1.Images.SetKeyName(4, "icons8-add-64.png");
            // 
            // comboDM
            // 
            comboDM.FormattingEnabled = true;
            comboDM.Location = new Point(11, 5);
            comboDM.Name = "comboDM";
            comboDM.Size = new Size(151, 28);
            comboDM.TabIndex = 13;
            // 
            // butInhoadon
            // 
            butInhoadon.ImageAlign = ContentAlignment.MiddleLeft;
            butInhoadon.ImageIndex = 3;
            butInhoadon.ImageList = imageList1;
            butInhoadon.Location = new Point(163, 503);
            butInhoadon.Name = "butInhoadon";
            butInhoadon.Padding = new Padding(10, 0, 0, 0);
            butInhoadon.Size = new Size(144, 38);
            butInhoadon.TabIndex = 4;
            butInhoadon.Text = "In hóa đơn";
            butInhoadon.UseVisualStyleBackColor = true;
            butInhoadon.Click += butInhoadon_Click;
            // 
            // butthanhtoan
            // 
            butthanhtoan.ImageAlign = ContentAlignment.MiddleLeft;
            butthanhtoan.ImageIndex = 1;
            butthanhtoan.ImageList = imageList1;
            butthanhtoan.Location = new Point(7, 503);
            butthanhtoan.Name = "butthanhtoan";
            butthanhtoan.Padding = new Padding(10, 0, 0, 0);
            butthanhtoan.Size = new Size(150, 38);
            butthanhtoan.TabIndex = 3;
            butthanhtoan.Text = "Thanh toán";
            butthanhtoan.UseVisualStyleBackColor = true;
            butthanhtoan.Click += butthanhtoan_Click;
            // 
            // NhânViên
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(panelOrder);
            Controls.Add(panelBàn);
            Controls.Add(panel1);
            Name = "NhânViên";
            Text = "Hệ Thống Nhân Viên";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelBàn.ResumeLayout(false);
            panelBàn.PerformLayout();
            panelOrder.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewchitiethoadon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDoUong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelBàn;
        private Panel panelOrder;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelBan;
        private Button butInhoadon;
        private Button butthanhtoan;
        private Label lblban;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridViewchitiethoadon;
        private TextBox txttendouong;
        private TextBox txtdongia;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtsoluong;
        private Button butthemmon;
        private ComboBox comboDM;
        private Panel panel4;
        private DataGridView dataGridDoUong;
        private ImageList imageList1;
    }
}