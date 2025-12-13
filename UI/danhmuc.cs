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
    public partial class danhmuc : UserControl
    {
        public danhmuc()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick; // tự gắn sự kiện
        }
        // Load danh mục từ database
        private void LoadDanhmuc()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Danhmuc";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;  // đảm bảo bật
                dataGridView1.DataSource = dt;
            }
        }
        // Load dữ liệu khi mở form
        private void danhmuc_Load(object sender, EventArgs e)
        {
            LoadDanhmuc();
        }
        // Lấy dữ liệu lên textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Chỉ xử lý khi click vào dòng hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtmaDM.Text = row.Cells["MaDM"].Value.ToString();
                txttenDM.Text = row.Cells["TenDM"].Value.ToString();
            }
        }
        // Thêm danh mục
        private void butTHEM_Click(object sender, EventArgs e)
        {
            if (txttenDM.Text.Trim() == "")
            {
                MessageBox.Show("Tên danh mục không được để trống!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Danhmuc (TenDM) VALUES (@TenDM)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDM", txttenDM.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm danh mục thành công!");

                LoadDanhmuc();
                txtmaDM.Clear();
                txttenDM.Clear();
            }
        }
        // Sửa danh mục
        private void butSUA_Click(object sender, EventArgs e)
        {
            if (txtmaDM.Text == "")
            {
                MessageBox.Show("Hãy chọn danh mục cần sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "UPDATE Danhmuc SET TenDM = @TenDM WHERE MaDM = @MaDM";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaDM", txtmaDM.Text);
                cmd.Parameters.AddWithValue("@TenDM", txttenDM.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");

                LoadDanhmuc();
            }
        }
        // Xoá danh mục
        private void butXOA_Click(object sender, EventArgs e)
        {
            if (txtmaDM.Text == "")
            {
                MessageBox.Show("Hãy chọn danh mục cần xoá!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM DanhMuc WHERE MaDM = @MaDM";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaDM", txtmaDM.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công!");

                LoadDanhmuc();
                txtmaDM.Clear();
                txttenDM.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
