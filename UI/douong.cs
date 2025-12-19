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
    public partial class douong : UserControl
    {
        public douong()
        {
            InitializeComponent();
            LoadDanhMucToCombo();
            LoadDoUong();
            dataGridViewdouong.CellClick += dataGridViewdouong_CellClick; // tự gắn sự kiện
        }
        // Load danh mục lên combobox
        void LoadDanhMucToCombo()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Danhmuc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxdanhmuc.DataSource = dt;
                comboBoxdanhmuc.DisplayMember = "TenDM";
                comboBoxdanhmuc.ValueMember = "MaDM";
            }
        }
        // Load dữ liệu đồ uống
        void LoadDoUong()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = @"SELECT DU.MaDoUong, DU.TenDoUong, DU.DonGia, DM.TenDM 
                       FROM DoUong DU
                       JOIN Danhmuc DM ON DU.MaDM = DM.MaDM";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewdouong.AutoGenerateColumns = true;  // đảm bảo bật
                dataGridViewdouong.DataSource = dt;
                dataGridViewdouong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewdouong.RowHeadersVisible = false;
                
            }
        }
        // Lấy dữ liệu lên textbox
        private void dataGridViewdouong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridViewdouong.Rows[e.RowIndex];

                txtmadouong.Text = r.Cells["MaDoUong"].Value.ToString();
                txttendouong.Text = r.Cells["TenDoUong"].Value.ToString();
                txtdongia.Text = r.Cells["DonGia"].Value.ToString();

                // combo danh mục
                comboBoxdanhmuc.Text = r.Cells["TenDM"].Value.ToString();
            }
        }
        private void comboBoxdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Thêm đồ uống
        private void butthem_Click(object sender, EventArgs e)
        {
            if (txttendouong.Text.Trim() == "")
            {
                MessageBox.Show("Tên đồ uống không được để trống!");
                return;
            }
            else if (txtdongia.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá không được để trống!");
                return;
            }
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO DoUong(TenDoUong, DonGia, MaDM) VALUES(@ten, @gia, @madm)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ten", txttendouong.Text);
                cmd.Parameters.AddWithValue("@gia", decimal.Parse(txtdongia.Text));
                cmd.Parameters.AddWithValue("@madm", comboBoxdanhmuc.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                LoadDoUong();
            }
        }
        // Sửa đồ uống
        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtmadouong.Text == "")
            {
                MessageBox.Show("Hãy chọn đồ uống cần sửa!");
                return;
            }
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = "UPDATE DoUong SET TenDoUong=@ten, DonGia=@gia, MaDM=@madm WHERE MaDoUong=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", txtmadouong.Text);
                cmd.Parameters.AddWithValue("@ten", txttendouong.Text);
                cmd.Parameters.AddWithValue("@gia", decimal.Parse(txtdongia.Text));
                cmd.Parameters.AddWithValue("@madm", comboBoxdanhmuc.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                LoadDoUong();
            }
        }
        // Xóa đồ uống
        private void butxoa_Click_1(object sender, EventArgs e)
        {
            if (txtmadouong.Text == "")
            {
                MessageBox.Show("Hãy chọn đồ uống cần xóa!");
                return;
            }
            if (MessageBox.Show("Bạn chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM DoUong WHERE MaDoUong=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", txtmadouong.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    LoadDoUong();
                }
            }
        }
        // Tìm kiếm đồ uống
        private void butTim_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                MessageBox.Show("Chưa nhập đồ uống cần tìm.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();

                string keyword = txttimkiem.Text.Trim();

                string sql = @"SELECT DU.MaDoUong, DU.TenDoUong, DU.DonGia, DM.TenDM
                               FROM DoUong DU
                               JOIN Danhmuc DM ON DU.MaDM = DM.MaDM
                               WHERE DU.TenDoUong LIKE '%' + @keyword + '%'";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@keyword", keyword);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewdouong.DataSource = dt;
            }
        }

    }
}
