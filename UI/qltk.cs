using Microsoft.Data.SqlClient;
using Quản_lý_Quán_Cafe.DAL;
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
    public partial class qltk : UserControl
    {
        public qltk()
        {
            InitializeComponent();
            LoadUsers();
            dataGridViewQLTK.CellClick += dataGridViewQLTK_CellClick;
            comboROLE.Items.Add("ADMIN");
            comboROLE.Items.Add("STAFF");
        }
        // Load dữ liệu khi mở form
        void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [User]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewQLTK.AutoGenerateColumns = true;  // đảm bảo bật
                dataGridViewQLTK.DataSource = dt;
                dataGridViewQLTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewQLTK.RowHeadersVisible = false;
                
            }
        }
        //Click vào dòng để hiện nội dung vào textbox
        private void dataGridViewQLTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridViewQLTK.Rows[e.RowIndex];

                txtid.Text = r.Cells["Userid"].Value.ToString();
                txtdnhap.Text = r.Cells["UserName"].Value.ToString();
                txtmk.Text = r.Cells["PassWordHash"].Value.ToString();
                txtfullname.Text = r.Cells["FullName"].Value.ToString();
                comboROLE.Text = r.Cells["RoleName"].Value.ToString();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Thêm tài khoản
        private void butTHEM_Click(object sender, EventArgs e)
        {
            if (txtdnhap.Text == "" || txtmk.Text == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được bỏ trống!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();

                string sql = @"INSERT INTO [User](UserName, PassWordHash, RoleName, FullName)
                       VALUES (@user, @pass, @role, @full)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtdnhap.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtmk.Text.Trim());
                cmd.Parameters.AddWithValue("@role", comboROLE.Text);
                cmd.Parameters.AddWithValue("@full", txtfullname.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm tài khoản thành công!");

                LoadUsers();
            }
        }
        // Sửa tài khoản
        private void butSUA_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản cần sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();

                string sql = @"UPDATE [User]
                       SET UserName=@user,
                           PassWordHash=@pass,
                           RoleName=@role,
                           FullName=@full
                       WHERE UserId=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", txtid.Text.Trim());
                cmd.Parameters.AddWithValue("@user", txtdnhap.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtmk.Text.Trim());
                cmd.Parameters.AddWithValue("@role", comboROLE.Text);
                cmd.Parameters.AddWithValue("@full", txtfullname.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");

                LoadUsers();
            }
        }
        // Xóa tài khoản
        private void butXOA_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này?",
                                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM [User] WHERE UserId=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", txtid.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");

                    LoadUsers();
                }
            }
        }

    }
}
