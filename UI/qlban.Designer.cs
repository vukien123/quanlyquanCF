namespace Quản_lý_Quán_Cafe.UI
{
    partial class qlban
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
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridViewban = new DataGridView();
            panel2 = new Panel();
            butxoa = new Button();
            butsua = new Button();
            butthem = new Button();
            txttenban = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewban).BeginInit();
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
            panel1.Size = new Size(620, 500);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewban);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(620, 326);
            panel3.TabIndex = 2;
            // 
            // dataGridViewban
            // 
            dataGridViewban.BackgroundColor = Color.WhiteSmoke;
            dataGridViewban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewban.Dock = DockStyle.Fill;
            dataGridViewban.GridColor = Color.LightGray;
            dataGridViewban.Location = new Point(0, 0);
            dataGridViewban.Name = "dataGridViewban";
            dataGridViewban.RowHeadersWidth = 51;
            dataGridViewban.Size = new Size(620, 326);
            dataGridViewban.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(butxoa);
            panel2.Controls.Add(butsua);
            panel2.Controls.Add(butthem);
            panel2.Controls.Add(txttenban);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 174);
            panel2.TabIndex = 1;
            // 
            // butxoa
            // 
            butxoa.Location = new Point(396, 103);
            butxoa.Name = "butxoa";
            butxoa.Size = new Size(113, 29);
            butxoa.TabIndex = 4;
            butxoa.Text = "Xóa bàn";
            butxoa.UseVisualStyleBackColor = true;
            butxoa.Click += butxoa_Click;
            // 
            // butsua
            // 
            butsua.Location = new Point(258, 103);
            butsua.Name = "butsua";
            butsua.Size = new Size(108, 29);
            butsua.TabIndex = 3;
            butsua.Text = "Sửa bàn";
            butsua.UseVisualStyleBackColor = true;
            butsua.Click += butsua_Click;
            // 
            // butthem
            // 
            butthem.Location = new Point(115, 103);
            butthem.Name = "butthem";
            butthem.Size = new Size(115, 29);
            butthem.TabIndex = 2;
            butthem.Text = "Thêm bàn";
            butthem.UseVisualStyleBackColor = true;
            butthem.Click += butthem_Click;
            // 
            // txttenban
            // 
            txttenban.Location = new Point(178, 27);
            txttenban.Name = "txttenban";
            txttenban.Size = new Size(299, 27);
            txttenban.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 30);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Bàn\r\n";
            // 
            // qlban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "qlban";
            Size = new Size(620, 500);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewban).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridViewban;
        private Panel panel2;
        private TextBox txttenban;
        private Label label1;
        private Button butxoa;
        private Button butsua;
        private Button butthem;
    }
}
