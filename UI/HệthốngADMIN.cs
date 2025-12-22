using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_Quán_Cafe.UI
{
    public partial class HệthốngADMIN : Form
    {
        public HệthốngADMIN()
        {
            InitializeComponent();
        }
        // Hàm tải UserControl vào panelphải
        private void LoadControl(UserControl uc)
        {
            // Xóa control cũ (và dispose để giải phóng)
            foreach (Control c in panelphải.Controls)
            {
                c.Dispose();
            }
            panelphải.Controls.Clear();

            // Thêm control mới
            uc.Dock = DockStyle.Fill;
            panelphải.Controls.Add(uc);
        }
        // Sự kiện click nút danh mục
        private void Danhmuc_Click(object sender, EventArgs e)
        {
            LoadControl(new danhmuc());
        }
        //  Sự kiện click nút đồ uống
        private void butdouong_Click(object sender, EventArgs e)
        {
            LoadControl(new douong());
        }
        //  Sự kiện click nút doanh thu
        private void butDoanhthu_Click(object sender, EventArgs e)
        {
            LoadControl(new doanhthu());
        }
        // Sự kiện click nút đăng xuất
        private void butdangxuat_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            loginForm.Show();

            this.Hide();
        }
        // Sự kiện click nút quản lý tài khoản
        private void butqltk_Click(object sender, EventArgs e)
        {
            LoadControl(new qltk());
        }

        private void panelphải_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butqlban_Click(object sender, EventArgs e)
        {
            LoadControl(new qlban());
        }
    }
}
