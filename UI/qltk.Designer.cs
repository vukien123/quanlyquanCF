namespace Quản_lý_Quán_Cafe.UI
{
    partial class qltk
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtdnhap = new TextBox();
            txtmk = new TextBox();
            txtfullname = new TextBox();
            comboROLE = new ComboBox();
            butTHEM = new Button();
            butSUA = new Button();
            butXOA = new Button();
            dataGridViewQLTK = new DataGridView();
            txtid = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQLTK).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 85);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 119);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Rolename";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 152);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Fullname";
            // 
            // txtdnhap
            // 
            txtdnhap.Location = new Point(166, 45);
            txtdnhap.Name = "txtdnhap";
            txtdnhap.Size = new Size(151, 27);
            txtdnhap.TabIndex = 6;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(166, 78);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(151, 27);
            txtmk.TabIndex = 7;
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(166, 145);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(151, 27);
            txtfullname.TabIndex = 9;
            // 
            // comboROLE
            // 
            comboROLE.FormattingEnabled = true;
            comboROLE.Location = new Point(166, 111);
            comboROLE.Name = "comboROLE";
            comboROLE.Size = new Size(151, 28);
            comboROLE.TabIndex = 10;
            // 
            // butTHEM
            // 
            butTHEM.Location = new Point(396, 11);
            butTHEM.Name = "butTHEM";
            butTHEM.Size = new Size(94, 29);
            butTHEM.TabIndex = 12;
            butTHEM.Text = "THÊM\r\n";
            butTHEM.UseVisualStyleBackColor = true;
            butTHEM.Click += butTHEM_Click;
            // 
            // butSUA
            // 
            butSUA.Location = new Point(396, 46);
            butSUA.Name = "butSUA";
            butSUA.Size = new Size(94, 29);
            butSUA.TabIndex = 13;
            butSUA.Text = "SỬA";
            butSUA.UseVisualStyleBackColor = true;
            butSUA.Click += butSUA_Click;
            // 
            // butXOA
            // 
            butXOA.Location = new Point(396, 81);
            butXOA.Name = "butXOA";
            butXOA.Size = new Size(94, 29);
            butXOA.TabIndex = 14;
            butXOA.Text = "XÓA";
            butXOA.UseVisualStyleBackColor = true;
            butXOA.Click += butXOA_Click;
            // 
            // dataGridViewQLTK
            // 
            dataGridViewQLTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQLTK.Location = new Point(0, 178);
            dataGridViewQLTK.Name = "dataGridViewQLTK";
            dataGridViewQLTK.RowHeadersWidth = 51;
            dataGridViewQLTK.Size = new Size(621, 229);
            dataGridViewQLTK.TabIndex = 15;
            dataGridViewQLTK.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtid
            // 
            txtid.Location = new Point(166, 11);
            txtid.Name = "txtid";
            txtid.Size = new Size(151, 27);
            txtid.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 17;
            label1.Text = "Userid";
            // 
            // qltk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(txtid);
            Controls.Add(dataGridViewQLTK);
            Controls.Add(butXOA);
            Controls.Add(butSUA);
            Controls.Add(butTHEM);
            Controls.Add(comboROLE);
            Controls.Add(txtfullname);
            Controls.Add(txtmk);
            Controls.Add(txtdnhap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "qltk";
            Size = new Size(621, 407);
            ((System.ComponentModel.ISupportInitialize)dataGridViewQLTK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtdnhap;
        private TextBox txtmk;
        private TextBox txtfullname;
        private ComboBox comboROLE;
        private Button butTHEM;
        private Button butSUA;
        private Button butXOA;
        private DataGridView dataGridViewQLTK;
        private TextBox txtid;
        private Label label1;
    }
}
