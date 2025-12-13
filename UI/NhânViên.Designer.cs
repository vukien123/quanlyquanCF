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
            panel1 = new Panel();
            label1 = new Label();
            panelBàn = new Panel();
            lblban = new Label();
            flowLayoutPanelBan = new FlowLayoutPanel();
            panelOrder = new Panel();
            txttendouong = new TextBox();
            txtdongia = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtsoluong = new TextBox();
            butthemmon = new Button();
            dataGridViewchitiethoadon = new DataGridView();
            butInhoadon = new Button();
            butthanhtoan = new Button();
            dataGridDoUong = new DataGridView();
            comboDM = new ComboBox();
            panel1.SuspendLayout();
            panelBàn.SuspendLayout();
            panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewchitiethoadon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDoUong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 53);
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
            panelBàn.Location = new Point(0, 51);
            panelBàn.Name = "panelBàn";
            panelBàn.Size = new Size(231, 542);
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
            panelOrder.Controls.Add(txttendouong);
            panelOrder.Controls.Add(txtdongia);
            panelOrder.Controls.Add(label4);
            panelOrder.Controls.Add(label3);
            panelOrder.Controls.Add(label2);
            panelOrder.Controls.Add(txtsoluong);
            panelOrder.Controls.Add(butthemmon);
            panelOrder.Controls.Add(dataGridViewchitiethoadon);
            panelOrder.Controls.Add(butInhoadon);
            panelOrder.Controls.Add(butthanhtoan);
            panelOrder.Controls.Add(dataGridDoUong);
            panelOrder.Controls.Add(comboDM);
            panelOrder.Location = new Point(229, 51);
            panelOrder.Name = "panelOrder";
            panelOrder.Size = new Size(570, 542);
            panelOrder.TabIndex = 2;
            // 
            // txttendouong
            // 
            txttendouong.Location = new Point(98, 187);
            txttendouong.Name = "txttendouong";
            txttendouong.Size = new Size(125, 27);
            txttendouong.TabIndex = 12;
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(98, 220);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(125, 27);
            txtdongia.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 194);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 10;
            label4.Text = "Đồ uống";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 227);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 255);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(98, 252);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(125, 27);
            txtsoluong.TabIndex = 7;
            // 
            // butthemmon
            // 
            butthemmon.Location = new Point(289, 208);
            butthemmon.Name = "butthemmon";
            butthemmon.Size = new Size(133, 51);
            butthemmon.TabIndex = 6;
            butthemmon.Text = "Thêm món";
            butthemmon.UseVisualStyleBackColor = true;
            butthemmon.Click += butthemmon_Click;
            // 
            // dataGridViewchitiethoadon
            // 
            dataGridViewchitiethoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewchitiethoadon.Location = new Point(7, 285);
            dataGridViewchitiethoadon.Name = "dataGridViewchitiethoadon";
            dataGridViewchitiethoadon.RowHeadersWidth = 51;
            dataGridViewchitiethoadon.Size = new Size(555, 212);
            dataGridViewchitiethoadon.TabIndex = 5;
            // 
            // butInhoadon
            // 
            butInhoadon.Location = new Point(117, 503);
            butInhoadon.Name = "butInhoadon";
            butInhoadon.Size = new Size(94, 38);
            butInhoadon.TabIndex = 4;
            butInhoadon.Text = "In hóa đơn";
            butInhoadon.UseVisualStyleBackColor = true;
            butInhoadon.Click += butInhoadon_Click;
            // 
            // butthanhtoan
            // 
            butthanhtoan.Location = new Point(7, 503);
            butthanhtoan.Name = "butthanhtoan";
            butthanhtoan.Size = new Size(94, 38);
            butthanhtoan.TabIndex = 3;
            butthanhtoan.Text = "Thanh toán";
            butthanhtoan.UseVisualStyleBackColor = true;
            butthanhtoan.Click += butthanhtoan_Click;
            // 
            // dataGridDoUong
            // 
            dataGridDoUong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDoUong.Location = new Point(3, 40);
            dataGridDoUong.Name = "dataGridDoUong";
            dataGridDoUong.RowHeadersWidth = 51;
            dataGridDoUong.Size = new Size(555, 141);
            dataGridDoUong.TabIndex = 2;
            // 
            // comboDM
            // 
            comboDM.FormattingEnabled = true;
            comboDM.Location = new Point(7, 6);
            comboDM.Name = "comboDM";
            comboDM.Size = new Size(151, 28);
            comboDM.TabIndex = 0;
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
            panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewchitiethoadon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDoUong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelBàn;
        private Panel panelOrder;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelBan;
        private ComboBox comboDM;
        private DataGridView dataGridDoUong;
        private DataGridView dataGridViewchitiethoadon;
        private Button butInhoadon;
        private Button butthanhtoan;
        private Label label2;
        private TextBox txtsoluong;
        private Button butthemmon;
        private TextBox txttendouong;
        private TextBox txtdongia;
        private Label label4;
        private Label label3;
        private Label lblban;
    }
}