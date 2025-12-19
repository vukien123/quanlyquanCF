namespace Quản_lý_Quán_Cafe.UI
{
    partial class doanhthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doanhthu));
            panel1 = new Panel();
            butLọctgian = new Button();
            imageList1 = new ImageList(components);
            DTđếnngày = new DateTimePicker();
            DTtừngày = new DateTimePicker();
            panel2 = new Panel();
            label1 = new Label();
            txttongtien = new TextBox();
            dataGridViewHoadon = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoadon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(butLọctgian);
            panel1.Controls.Add(DTđếnngày);
            panel1.Controls.Add(DTtừngày);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Desktop;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 119);
            panel1.TabIndex = 5;
            // 
            // butLọctgian
            // 
            butLọctgian.ImageAlign = ContentAlignment.MiddleLeft;
            butLọctgian.ImageIndex = 0;
            butLọctgian.ImageList = imageList1;
            butLọctgian.Location = new Point(237, 66);
            butLọctgian.Name = "butLọctgian";
            butLọctgian.Padding = new Padding(10, 0, 0, 0);
            butLọctgian.Size = new Size(151, 47);
            butLọctgian.TabIndex = 5;
            butLọctgian.Text = "Lọc thời gian";
            butLọctgian.UseVisualStyleBackColor = true;
            butLọctgian.Click += butLọctgian_Click_1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "107799.png");
            // 
            // DTđếnngày
            // 
            DTđếnngày.Location = new Point(361, 33);
            DTđếnngày.Name = "DTđếnngày";
            DTđếnngày.Size = new Size(211, 27);
            DTđếnngày.TabIndex = 4;
            // 
            // DTtừngày
            // 
            DTtừngày.Location = new Point(60, 33);
            DTtừngày.Name = "DTtừngày";
            DTtừngày.Size = new Size(211, 27);
            DTtừngày.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txttongtien);
            panel2.Controls.Add(dataGridViewHoadon);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 253);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 216);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 7;
            label1.Text = "Tổng tiền\r\n";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(102, 216);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(125, 27);
            txttongtien.TabIndex = 6;
            // 
            // dataGridViewHoadon
            // 
            dataGridViewHoadon.BackgroundColor = Color.WhiteSmoke;
            dataGridViewHoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHoadon.Dock = DockStyle.Top;
            dataGridViewHoadon.GridColor = Color.LightGray;
            dataGridViewHoadon.Location = new Point(0, 0);
            dataGridViewHoadon.Name = "dataGridViewHoadon";
            dataGridViewHoadon.RowHeadersWidth = 51;
            dataGridViewHoadon.Size = new Size(632, 202);
            dataGridViewHoadon.TabIndex = 5;
            // 
            // doanhthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "doanhthu";
            Size = new Size(632, 372);
            Load += doanhthu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button butLọctgian;
        private DateTimePicker DTđếnngày;
        private DateTimePicker DTtừngày;
        private Panel panel2;
        private Label label1;
        private TextBox txttongtien;
        private DataGridView dataGridViewHoadon;
        private ImageList imageList1;
    }
}
