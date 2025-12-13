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

        private void Danhmuc_Click(object sender, EventArgs e)
        {
            LoadControl(new danhmuc());
        }

        private void butdouong_Click(object sender, EventArgs e)
        {
            LoadControl(new douong());
        }

        private void butDoanhthu_Click(object sender, EventArgs e)
        {
            LoadControl(new doanhthu());
        }

        private void butdangxuat_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            loginForm.Show();

            this.Hide();
        }

        private void butqltk_Click(object sender, EventArgs e)
        {
            LoadControl(new qltk());
        }

    }
}
