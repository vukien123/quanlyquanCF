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
            DTtừngày = new DateTimePicker();
            DTđếnngày = new DateTimePicker();
            butLọctgian = new Button();
            dataGridViewHoadon = new DataGridView();
            txttongtien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoadon).BeginInit();
            SuspendLayout();
            // 
            // DTtừngày
            // 
            DTtừngày.Location = new Point(21, 3);
            DTtừngày.Name = "DTtừngày";
            DTtừngày.Size = new Size(211, 27);
            DTtừngày.TabIndex = 0;
            // 
            // DTđếnngày
            // 
            DTđếnngày.Location = new Point(322, 3);
            DTđếnngày.Name = "DTđếnngày";
            DTđếnngày.Size = new Size(211, 27);
            DTđếnngày.TabIndex = 1;
            // 
            // butLọctgian
            // 
            butLọctgian.Location = new Point(215, 36);
            butLọctgian.Name = "butLọctgian";
            butLọctgian.Size = new Size(116, 29);
            butLọctgian.TabIndex = 2;
            butLọctgian.Text = "Lọc thời gian";
            butLọctgian.UseVisualStyleBackColor = true;
            butLọctgian.Click += butLọctgian_Click;
            // 
            // dataGridViewHoadon
            // 
            dataGridViewHoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHoadon.Location = new Point(-3, 71);
            dataGridViewHoadon.Name = "dataGridViewHoadon";
            dataGridViewHoadon.RowHeadersWidth = 51;
            dataGridViewHoadon.Size = new Size(635, 246);
            dataGridViewHoadon.TabIndex = 3;
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(3, 334);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(125, 27);
            txttongtien.TabIndex = 4;
            // 
            // doanhthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txttongtien);
            Controls.Add(dataGridViewHoadon);
            Controls.Add(butLọctgian);
            Controls.Add(DTđếnngày);
            Controls.Add(DTtừngày);
            Name = "doanhthu";
            Size = new Size(632, 372);
            Load += doanhthu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoadon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DTtừngày;
        private DateTimePicker DTđếnngày;
        private Button butLọctgian;
        private DataGridView dataGridViewHoadon;
        private TextBox txttongtien;
    }
}
