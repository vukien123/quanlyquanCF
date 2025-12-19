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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qltk));
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridViewQLTK = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            txtid = new TextBox();
            butXOA = new Button();
            imageList1 = new ImageList(components);
            butSUA = new Button();
            butTHEM = new Button();
            comboROLE = new ComboBox();
            txtfullname = new TextBox();
            txtmk = new TextBox();
            txtdnhap = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQLTK).BeginInit();
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
            panel1.Size = new Size(621, 407);
            panel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewQLTK);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(621, 220);
            panel3.TabIndex = 33;
            // 
            // dataGridViewQLTK
            // 
            dataGridViewQLTK.BackgroundColor = Color.WhiteSmoke;
            dataGridViewQLTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQLTK.Dock = DockStyle.Fill;
            dataGridViewQLTK.GridColor = Color.LightGray;
            dataGridViewQLTK.Location = new Point(0, 0);
            dataGridViewQLTK.Name = "dataGridViewQLTK";
            dataGridViewQLTK.RowHeadersWidth = 51;
            dataGridViewQLTK.Size = new Size(621, 220);
            dataGridViewQLTK.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtid);
            panel2.Controls.Add(butXOA);
            panel2.Controls.Add(butSUA);
            panel2.Controls.Add(butTHEM);
            panel2.Controls.Add(comboROLE);
            panel2.Controls.Add(txtfullname);
            panel2.Controls.Add(txtmk);
            panel2.Controls.Add(txtdnhap);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 187);
            panel2.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 44;
            label1.Text = "Userid";
            // 
            // txtid
            // 
            txtid.Location = new Point(219, 11);
            txtid.Name = "txtid";
            txtid.Size = new Size(151, 27);
            txtid.TabIndex = 43;
            // 
            // butXOA
            // 
            butXOA.ImageAlign = ContentAlignment.MiddleLeft;
            butXOA.ImageIndex = 1;
            butXOA.ImageList = imageList1;
            butXOA.Location = new Point(449, 95);
            butXOA.Name = "butXOA";
            butXOA.Padding = new Padding(10, 0, 0, 0);
            butXOA.Size = new Size(113, 32);
            butXOA.TabIndex = 42;
            butXOA.Text = "XÓA";
            butXOA.UseVisualStyleBackColor = true;
            butXOA.Click += butXOA_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-pencil-32.png");
            imageList1.Images.SetKeyName(1, "icons8-close-32.png");
            imageList1.Images.SetKeyName(2, "icons8-add-32.png");
            // 
            // butSUA
            // 
            butSUA.ImageAlign = ContentAlignment.MiddleLeft;
            butSUA.ImageIndex = 0;
            butSUA.ImageList = imageList1;
            butSUA.Location = new Point(449, 54);
            butSUA.Name = "butSUA";
            butSUA.Padding = new Padding(10, 0, 0, 0);
            butSUA.Size = new Size(113, 35);
            butSUA.TabIndex = 41;
            butSUA.Text = "SỬA";
            butSUA.UseVisualStyleBackColor = true;
            butSUA.Click += butSUA_Click;
            // 
            // butTHEM
            // 
            butTHEM.ImageAlign = ContentAlignment.MiddleLeft;
            butTHEM.ImageIndex = 2;
            butTHEM.ImageList = imageList1;
            butTHEM.Location = new Point(449, 11);
            butTHEM.Name = "butTHEM";
            butTHEM.Padding = new Padding(10, 0, 0, 0);
            butTHEM.Size = new Size(113, 37);
            butTHEM.TabIndex = 40;
            butTHEM.Text = "THÊM\r\n";
            butTHEM.UseVisualStyleBackColor = true;
            butTHEM.Click += butTHEM_Click;
            // 
            // comboROLE
            // 
            comboROLE.FormattingEnabled = true;
            comboROLE.Location = new Point(219, 111);
            comboROLE.Name = "comboROLE";
            comboROLE.Size = new Size(151, 28);
            comboROLE.TabIndex = 39;
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(219, 145);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(151, 27);
            txtfullname.TabIndex = 38;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(219, 78);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(151, 27);
            txtmk.TabIndex = 37;
            // 
            // txtdnhap
            // 
            txtdnhap.Location = new Point(219, 45);
            txtdnhap.Name = "txtdnhap";
            txtdnhap.Size = new Size(151, 27);
            txtdnhap.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 152);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 35;
            label5.Text = "Fullname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 119);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 34;
            label4.Text = "Rolename";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 85);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 33;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 52);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 32;
            label2.Text = "Tên đăng nhập";
            // 
            // qltk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "qltk";
            Size = new Size(621, 407);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewQLTK).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridViewQLTK;
        private Panel panel2;
        private Label label1;
        private TextBox txtid;
        private Button butXOA;
        private Button butSUA;
        private Button butTHEM;
        private ComboBox comboROLE;
        private TextBox txtfullname;
        private TextBox txtmk;
        private TextBox txtdnhap;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ImageList imageList1;
    }
}
