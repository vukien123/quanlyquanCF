namespace Quản_lý_Quán_Cafe.UI
{
    partial class Login
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
            butdnhap = new Button();
            buthủy = new Button();
            txtdangnhap = new TextBox();
            txtmatkhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // butdnhap
            // 
            butdnhap.Location = new Point(122, 227);
            butdnhap.Name = "butdnhap";
            butdnhap.Size = new Size(94, 29);
            butdnhap.TabIndex = 0;
            butdnhap.Text = "Đăng nhập";
            butdnhap.UseVisualStyleBackColor = true;
            butdnhap.Click += butdnhap_Click;
            // 
            // buthủy
            // 
            buthủy.Location = new Point(304, 227);
            buthủy.Name = "buthủy";
            buthủy.Size = new Size(94, 29);
            buthủy.TabIndex = 1;
            buthủy.Text = "Hủy";
            buthủy.UseVisualStyleBackColor = true;
            buthủy.Click += buthủy_Click;
            // 
            // txtdangnhap
            // 
            txtdangnhap.Location = new Point(238, 101);
            txtdangnhap.Name = "txtdangnhap";
            txtdangnhap.Size = new Size(183, 27);
            txtdangnhap.TabIndex = 2;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(238, 157);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.Size = new Size(183, 27);
            txtmatkhau.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 104);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 160);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 24);
            label3.Name = "label3";
            label3.Size = new Size(200, 41);
            label3.TabIndex = 6;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 300);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtmatkhau);
            Controls.Add(txtdangnhap);
            Controls.Add(buthủy);
            Controls.Add(butdnhap);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butdnhap;
        private Button buthủy;
        private TextBox txtdangnhap;
        private TextBox txtmatkhau;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}