using Quản_lý_Quán_Cafe.BLL;
using Quản_lý_Quán_Cafe.ObjectData;
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
    public partial class Login : Form
    {
        UserService _userService;
        public Login()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void buthủy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butdnhap_Click(object sender, EventArgs e)
        {
            string username = txtdangnhap.Text.Trim();
            string password = txtmatkhau.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Tên không được để trống");
                txtdangnhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống");
                txtmatkhau.Focus();
                return;
            }
            try
            {
                User authenticatedUser = _userService.AuthenticatedUser(username, password);
                if (authenticatedUser != null)
                {
                    MessageBox.Show("Chào mừng " + authenticatedUser.FullName + "! đăng nhập thành công");
                    this.Hide();

                    //  Mở form tương ứng

                    switch (authenticatedUser.RoleName)
                    {
                        case "ADMIN":
                            new HệthốngADMIN().Show();
                            break;
                        case "STAFF":
                            new NhânViên().Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    this.txtdangnhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");

            }
        }
    }
}
