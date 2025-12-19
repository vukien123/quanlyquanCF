namespace Quản_lý_Quán_Cafe.UI
{
    partial class formhoadon
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
            lbltieude = new Label();
            label1 = new Label();
            label2 = new Label();
            lblmahd = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridViewchitiethd = new DataGridView();
            label5 = new Label();
            txtmahd = new TextBox();
            txtngaylap = new TextBox();
            txtban = new TextBox();
            txttongtien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewchitiethd).BeginInit();
            SuspendLayout();
            // 
            // lbltieude
            // 
            lbltieude.AutoSize = true;
            lbltieude.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltieude.Location = new Point(215, 9);
            lbltieude.Name = "lbltieude";
            lbltieude.Size = new Size(109, 28);
            lbltieude.TabIndex = 0;
            lbltieude.Text = "HÓA ĐƠN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 67);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 103);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày lập";
            // 
            // lblmahd
            // 
            lblmahd.AutoSize = true;
            lblmahd.Location = new Point(196, 34);
            lblmahd.Name = "lblmahd";
            lblmahd.Size = new Size(0, 20);
            lblmahd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 67);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 141);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 5;
            label4.Text = "Bàn";
            // 
            // dataGridViewchitiethd
            // 
            dataGridViewchitiethd.BackgroundColor = Color.WhiteSmoke;
            dataGridViewchitiethd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewchitiethd.GridColor = Color.LightGray;
            dataGridViewchitiethd.Location = new Point(-2, 180);
            dataGridViewchitiethd.Name = "dataGridViewchitiethd";
            dataGridViewchitiethd.RowHeadersWidth = 51;
            dataGridViewchitiethd.Size = new Size(527, 231);
            dataGridViewchitiethd.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 437);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Tổng tiền";
            // 
            // txtmahd
            // 
            txtmahd.Location = new Point(180, 64);
            txtmahd.Name = "txtmahd";
            txtmahd.Size = new Size(144, 27);
            txtmahd.TabIndex = 8;
            // 
            // txtngaylap
            // 
            txtngaylap.Location = new Point(180, 100);
            txtngaylap.Name = "txtngaylap";
            txtngaylap.Size = new Size(144, 27);
            txtngaylap.TabIndex = 9;
            // 
            // txtban
            // 
            txtban.Location = new Point(180, 138);
            txtban.Name = "txtban";
            txtban.Size = new Size(144, 27);
            txtban.TabIndex = 10;
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(180, 434);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(144, 27);
            txttongtien.TabIndex = 11;
            // 
            // formhoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 482);
            Controls.Add(txttongtien);
            Controls.Add(txtban);
            Controls.Add(txtngaylap);
            Controls.Add(txtmahd);
            Controls.Add(label5);
            Controls.Add(dataGridViewchitiethd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblmahd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbltieude);
            Name = "formhoadon";
            Text = "In hóa đơn";
            Load += formhoadon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewchitiethd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltieude;
        private Label label1;
        private Label label2;
        private Label lblmahd;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewchitiethd;
        private Label label5;
        private TextBox txtmahd;
        private TextBox txtngaylap;
        private TextBox txtban;
        private TextBox txttongtien;
    }
}