namespace Quản_lý_Quán_Cafe.UI
{
    partial class HệthốngADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HệthốngADMIN));
            panelphải = new Panel();
            panel2 = new Panel();
            butdangxuat = new Button();
            imageList1 = new ImageList(components);
            butqltk = new Button();
            butDoanhthu = new Button();
            butdouong = new Button();
            Danhmuc = new Button();
            panel3 = new Panel();
            label1 = new Label();
            butqlban = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelphải
            // 
            panelphải.BorderStyle = BorderStyle.FixedSingle;
            panelphải.Location = new Point(157, 52);
            panelphải.Name = "panelphải";
            panelphải.Size = new Size(647, 395);
            panelphải.TabIndex = 0;
            panelphải.Paint += panelphải_Paint;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(butqlban);
            panel2.Controls.Add(butdangxuat);
            panel2.Controls.Add(butqltk);
            panel2.Controls.Add(butDoanhthu);
            panel2.Controls.Add(butdouong);
            panel2.Controls.Add(Danhmuc);
            panel2.Location = new Point(1, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 399);
            panel2.TabIndex = 1;
            // 
            // butdangxuat
            // 
            butdangxuat.BackColor = Color.FromArgb(192, 64, 0);
            butdangxuat.ForeColor = Color.White;
            butdangxuat.ImageAlign = ContentAlignment.MiddleLeft;
            butdangxuat.ImageIndex = 4;
            butdangxuat.ImageList = imageList1;
            butdangxuat.Location = new Point(-1, 346);
            butdangxuat.Name = "butdangxuat";
            butdangxuat.Padding = new Padding(10, 0, 0, 0);
            butdangxuat.Size = new Size(162, 52);
            butdangxuat.TabIndex = 6;
            butdangxuat.Text = "Đăng xuất";
            butdangxuat.UseVisualStyleBackColor = false;
            butdangxuat.Click += butdangxuat_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Turquoise;
            imageList1.Images.SetKeyName(0, "icons8-category-50.png");
            imageList1.Images.SetKeyName(1, "icons8-coffee-50.png");
            imageList1.Images.SetKeyName(2, "icons8-user-50.png");
            imageList1.Images.SetKeyName(3, "icons8-total-sales-16.png");
            imageList1.Images.SetKeyName(4, "icons8-sign-out-50.png");
            imageList1.Images.SetKeyName(5, "icons8-table-32.png");
            // 
            // butqltk
            // 
            butqltk.BackColor = Color.White;
            butqltk.ImageAlign = ContentAlignment.MiddleLeft;
            butqltk.ImageIndex = 2;
            butqltk.ImageList = imageList1;
            butqltk.Location = new Point(-1, 190);
            butqltk.Name = "butqltk";
            butqltk.Padding = new Padding(10, 0, 0, 0);
            butqltk.Size = new Size(162, 52);
            butqltk.TabIndex = 5;
            butqltk.Text = "Quản lý User";
            butqltk.UseVisualStyleBackColor = false;
            butqltk.Click += butqltk_Click;
            // 
            // butDoanhthu
            // 
            butDoanhthu.BackColor = Color.White;
            butDoanhthu.ImageAlign = ContentAlignment.MiddleLeft;
            butDoanhthu.ImageIndex = 3;
            butDoanhthu.ImageList = imageList1;
            butDoanhthu.Location = new Point(-1, 95);
            butDoanhthu.Name = "butDoanhthu";
            butDoanhthu.Padding = new Padding(10, 0, 0, 0);
            butDoanhthu.Size = new Size(162, 52);
            butDoanhthu.TabIndex = 3;
            butDoanhthu.Text = "Doanh Thu";
            butDoanhthu.UseVisualStyleBackColor = false;
            butDoanhthu.Click += butDoanhthu_Click;
            // 
            // butdouong
            // 
            butdouong.BackColor = Color.White;
            butdouong.ImageAlign = ContentAlignment.MiddleLeft;
            butdouong.ImageIndex = 1;
            butdouong.ImageList = imageList1;
            butdouong.Location = new Point(-1, 52);
            butdouong.Name = "butdouong";
            butdouong.Padding = new Padding(10, 0, 0, 0);
            butdouong.Size = new Size(162, 47);
            butdouong.TabIndex = 2;
            butdouong.Text = "Đồ Uống";
            butdouong.UseVisualStyleBackColor = false;
            butdouong.Click += butdouong_Click;
            // 
            // Danhmuc
            // 
            Danhmuc.BackColor = Color.White;
            Danhmuc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Danhmuc.ImageAlign = ContentAlignment.MiddleLeft;
            Danhmuc.ImageIndex = 0;
            Danhmuc.ImageList = imageList1;
            Danhmuc.Location = new Point(-1, 3);
            Danhmuc.Name = "Danhmuc";
            Danhmuc.Padding = new Padding(10, 0, 0, 0);
            Danhmuc.Size = new Size(162, 53);
            Danhmuc.TabIndex = 0;
            Danhmuc.Text = "Danh Mục";
            Danhmuc.UseVisualStyleBackColor = false;
            Danhmuc.Click += Danhmuc_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 53);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "ADMIN CAFE";
            // 
            // butqlban
            // 
            butqlban.BackColor = Color.White;
            butqlban.ImageAlign = ContentAlignment.MiddleLeft;
            butqlban.ImageIndex = 5;
            butqlban.ImageList = imageList1;
            butqlban.Location = new Point(-1, 142);
            butqlban.Name = "butqlban";
            butqlban.Padding = new Padding(10, 0, 0, 0);
            butqlban.Size = new Size(162, 52);
            butqlban.TabIndex = 7;
            butqlban.Text = "Quản lý Bàn";
            butqlban.UseVisualStyleBackColor = false;
            butqlban.Click += butqlban_Click;
            // 
            // HệthốngADMIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelphải);
            Name = "HệthốngADMIN";
            Text = "Hệ Thống Quản Lý";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelphải;
        private Panel panel2;
        private Button butDoanhthu;
        private Button butdouong;
        private Button Danhmuc;
        private Panel panel3;
        private Label label1;
        private Button butqltk;
        private Button butdangxuat;
        private ImageList imageList1;
        private Button butqlban;
    }
}