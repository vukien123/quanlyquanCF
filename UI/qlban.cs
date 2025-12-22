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
    public partial class qlban : UserControl
    {
        public qlban()
        {
            InitializeComponent();
            LoadBan();
            dataGridViewban.CellClick += dataGridViewBan_CellClick;
        }
        // Load datagridview bàn khi UserControl được tải
        void LoadBan()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "SELECT MaBan, TenBan, TrangThai FROM Ban";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewban.AutoGenerateColumns = true;  // đảm bảo bật
                dataGridViewban.DataSource = dt;
                dataGridViewban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewban.RowHeadersVisible = false;

            }
        }
        int maBanDangChon = 0; // Biến lưu mã bàn đang chọn
        // chọn bàn hiển thị lên textbox
        private void dataGridViewBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewban.Rows[e.RowIndex];
                maBanDangChon = Convert.ToInt32(row.Cells["MaBan"].Value);
                txttenban.Text = row.Cells["TenBan"].Value.ToString();
            }
        }

        // Thêm bàn
        private void butthem_Click(object sender, EventArgs e)
        {
            if (txttenban.Text.Trim() == "")
            {
                MessageBox.Show("Tên bàn không được để trống!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Ban (TenBan, TrangThai) VALUES (@TenBan, N'Trống')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenBan", txttenban.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm bàn thành công!");
            txttenban.Clear();
            LoadBan();
        }
        // Sửa bàn
        private void butsua_Click(object sender, EventArgs e)
        {
            if (maBanDangChon == 0)
            {
                MessageBox.Show("Hãy chọn bàn cần sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "UPDATE Ban SET TenBan = @TenBan WHERE MaBan = @MaBan";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenBan", txttenban.Text.Trim());
                cmd.Parameters.AddWithValue("@MaBan", maBanDangChon);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Sửa bàn thành công!");
            txttenban.Clear();
            maBanDangChon = 0;
            LoadBan();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (maBanDangChon == 0)
            {
                MessageBox.Show("Hãy chọn bàn cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này?",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) // Nếu chọn No thì dừng việc xóa
                return;

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Ban WHERE MaBan = @MaBan";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaBan", maBanDangChon);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Xóa bàn thành công!");
            txttenban.Clear();
            maBanDangChon = 0;
            LoadBan();
        }
    }
}
