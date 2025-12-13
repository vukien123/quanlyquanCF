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
            panelphải = new Panel();
            panel2 = new Panel();
            butdangxuat = new Button();
            butqltk = new Button();
            butDoanhthu = new Button();
            butdouong = new Button();
            Danhmuc = new Button();
            panel3 = new Panel();
            label1 = new Label();
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
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
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
            butdangxuat.Location = new Point(-1, 190);
            butdangxuat.Name = "butdangxuat";
            butdangxuat.Size = new Size(162, 52);
            butdangxuat.TabIndex = 6;
            butdangxuat.Text = "Đăng xuất";
            butdangxuat.UseVisualStyleBackColor = true;
            butdangxuat.Click += butdangxuat_Click;
            // 
            // butqltk
            // 
            butqltk.Location = new Point(-1, 143);
            butqltk.Name = "butqltk";
            butqltk.Size = new Size(162, 52);
            butqltk.TabIndex = 5;
            butqltk.Text = "Quản Lý Tài Khoản";
            butqltk.UseVisualStyleBackColor = true;
            butqltk.Click += butqltk_Click;
            // 
            // butDoanhthu
            // 
            butDoanhthu.Location = new Point(-1, 95);
            butDoanhthu.Name = "butDoanhthu";
            butDoanhthu.Size = new Size(162, 52);
            butDoanhthu.TabIndex = 3;
            butDoanhthu.Text = "Doanh Thu";
            butDoanhthu.UseVisualStyleBackColor = true;
            butDoanhthu.Click += butDoanhthu_Click;
            // 
            // butdouong
            // 
            butdouong.Location = new Point(-1, 52);
            butdouong.Name = "butdouong";
            butdouong.Size = new Size(162, 47);
            butdouong.TabIndex = 2;
            butdouong.Text = "Đồ Uống";
            butdouong.UseVisualStyleBackColor = true;
            butdouong.Click += butdouong_Click;
            // 
            // Danhmuc
            // 
            Danhmuc.Location = new Point(-1, 3);
            Danhmuc.Name = "Danhmuc";
            Danhmuc.Size = new Size(162, 53);
            Danhmuc.TabIndex = 0;
            Danhmuc.Text = "Danh Mục";
            Danhmuc.UseVisualStyleBackColor = true;
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
    }
}