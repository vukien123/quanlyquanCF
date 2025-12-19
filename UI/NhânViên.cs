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
    public partial class NhânViên : Form
    {
        public NhânViên()
        {
            InitializeComponent();
            LoadBan();
            LoadDanhMuc();
            LoadDoUong();    
            comboDM.SelectedIndexChanged += DanhmucDouong;
            dataGridDoUong.CellClick += dataGridDoUong_CellClick;

        }
        string banDangChon = "";
        // Chọn bàn
        private void ChonBan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            banDangChon = btn.Tag.ToString();  // Lấy mã bàn từ Tag
            lblban.Text = "Bàn đang chọn: " + btn.Text;
            KiemTraHoacTaoHoaDon();
            LoadChiTietHoaDon();
        }

        // Load bàn từ database
        private void LoadBan()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ban", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                flowLayoutPanelBan.Controls.Clear();

                foreach (DataRow r in dt.Rows)
                {
                    Button btn = new Button();
                    btn.Width = 100;
                    btn.Height = 80;
                    btn.Text = r["TenBan"].ToString();

                    // Đổi màu theo trạng thái
                    string trangthai = r["TrangThai"].ToString();
                    btn.BackColor = (trangthai == "Trống") ? Color.LightGreen : Color.OrangeRed;

                    btn.Tag = r["MaBan"];

                    btn.Click += ChonBan_Click;

                    flowLayoutPanelBan.Controls.Add(btn);
                }
            }
        }
        // Mã hóa đơn hiện tại
        private int maHoaDonHienTai = 0;
        // Kiểm tra hoặc tạo hóa đơn cho bàn đang chọn
        private void KiemTraHoacTaoHoaDon()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();

                // 1. Kiểm tra xem bàn có hóa đơn CHƯA THANH TOÁN hay không
                string sql = @"SELECT MaHD 
                       FROM HoaDon 
                       WHERE MaBan = @MaBan AND TrangThaiPay = 0";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaBan", banDangChon);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // Đã có hóa đơn
                    maHoaDonHienTai = Convert.ToInt32(result);
                }
                else
                {
                    // Không có → tạo hóa đơn mới
                    string sqlInsert = @"INSERT INTO HoaDon(MaBan, NgayLap, TongTien, TrangThaiPay)
                                        VALUES (@MaBan, GETDATE(), 0, 0);
                                        SELECT SCOPE_IDENTITY();";  // Lấy ID vừa tạo

                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
                    cmdInsert.Parameters.AddWithValue("@MaBan", banDangChon);

                    maHoaDonHienTai = Convert.ToInt32(cmdInsert.ExecuteScalar());
                }
            }

            // Load chi tiết hóa đơn lên lưới
            LoadChiTietHoaDon();
        }

        // Load danh mục đồ uống
        void LoadDanhMuc()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Danhmuc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboDM.DataSource = dt;
                comboDM.DisplayMember = "TenDM";
                comboDM.ValueMember = "MaDM";
            }
        }
        // Load đồ uống ban đầu
        void LoadDoUong()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM DoUong WHERE MaDM = @dm", conn
                );
                da.SelectCommand.Parameters.AddWithValue("@dm", comboDM.SelectedValue);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridDoUong.AutoGenerateColumns = true;  // đảm bảo bật
                dataGridDoUong.DataSource = dt;
                dataGridDoUong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridDoUong.RowHeadersVisible = false;
                
            }
        }
        // Lọc đồ uống theo danh mục
        private void DanhmucDouong(object sender, EventArgs e)
        {
            if (comboDM.SelectedValue == null)
                return;

            int maDM = int.Parse(comboDM.SelectedValue.ToString());

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                string sql = @"SELECT DU.MaDoUong, DU.TenDoUong, DU.DonGia, DM.TenDM 
                               FROM DoUong DU
                               JOIN Danhmuc DM ON DU.MaDM = DM.MaDM
                               WHERE DU.MaDM = @MaDM";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaDM", maDM);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridDoUong.DataSource = dt;
            }
        }
        // Biến lưu mã đồ uống và đơn giá
        private string maDoUong;
        private int donGia;
        // Chọn đồ uống từ DataGridView
        private void dataGridDoUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridDoUong.Rows[e.RowIndex];

                maDoUong = row.Cells["MaDoUong"].Value.ToString();
                txttendouong.Text = row.Cells["TenDoUong"].Value.ToString();
                donGia = int.Parse(row.Cells["DonGia"].Value.ToString());
                txtdongia.Text = donGia.ToString();
            }
        }

        private void butthemmon_Click(object sender, EventArgs e)
        {
            if (banDangChon == "")
            {
                MessageBox.Show("Chưa chọn bàn!");
                return;
            }

            int sl = int.Parse(txtsoluong.Text);


            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();

                // Nếu CHƯA có hóa đơn → tạo hóa đơn mới
                if (maHoaDonHienTai == 0)
                {
                    string sqlInsertHD = @"INSERT INTO HoaDon(MaBan, NgayLap, TongTien, TrangThaiPay)
                                           VALUES(@MaBan, GETDATE(), 0, 0);
                                           SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdHD = new SqlCommand(sqlInsertHD, conn);
                    cmdHD.Parameters.AddWithValue("@MaBan", banDangChon);

                    maHoaDonHienTai = Convert.ToInt32(cmdHD.ExecuteScalar());
                }
                // Thêm đồ vào chi tiết hóa đơn
                string sql = @"INSERT INTO ChiTietHoaDon (MaHD, MaDoUong, SoLuong, ThanhTien)
                               VALUES (@MaHD, @MaDU, @SL, @TT)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHoaDonHienTai);
                cmd.Parameters.AddWithValue("@MaDU", maDoUong);
                cmd.Parameters.AddWithValue("@SL", sl);
                cmd.Parameters.AddWithValue("@TT", sl * donGia);

                cmd.ExecuteNonQuery();

                // Cập nhật trạng thái bàn thành Có khách
                string sqlBan = "UPDATE Ban SET TrangThai = N'Có khách' WHERE MaBan = @Ban";
                SqlCommand cmdBan = new SqlCommand(sqlBan, conn);
                cmdBan.Parameters.AddWithValue("@Ban", banDangChon);
                cmdBan.ExecuteNonQuery();

                MessageBox.Show("Đã thêm món!");

            }
            // load lại hóa đơn và load lại trạng thái bàn
            LoadChiTietHoaDon();
            LoadBan();
        }
        // Load chi tiết hóa đơn lên DataGridView
        void LoadChiTietHoaDon()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT c.MaDoUong, d.TenDoUong, c.SoLuong, c.ThanhTien
                    FROM ChiTietHoaDon c
                    JOIN DoUong d ON c.MaDoUong = d.MaDoUong
                    WHERE c.MaHD = @MaHD", conn);

                da.SelectCommand.Parameters.AddWithValue("@MaHD", maHoaDonHienTai);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewchitiethoadon.DataSource = dt;
                dataGridViewchitiethoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewchitiethoadon.RowHeadersVisible = false;
                
            }
        }
        // Thanh toán
        private void butthanhtoan_Click(object sender, EventArgs e)
        {
            if (maHoaDonHienTai == 0)
            {
                MessageBox.Show("Chưa có hóa đơn!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();

                // Cập nhật tổng tiền cho hóa đơn
                SqlCommand cmdSum = new SqlCommand(
                    "UPDATE HoaDon SET TongTien = (SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE MaHD = @MaHD) WHERE MaHD = @MaHD", conn);
                cmdSum.Parameters.AddWithValue("@MaHD", maHoaDonHienTai);
                cmdSum.ExecuteNonQuery();

                // Cập nhật trạng thái pay
                SqlCommand cmd1 = new SqlCommand(
                    "UPDATE HoaDon SET TrangThaiPay = 1 WHERE MaHD = @MaHD", conn);
                cmd1.Parameters.AddWithValue("@MaHD", maHoaDonHienTai);
                cmd1.ExecuteNonQuery();

                // Trả bàn về Trống
                SqlCommand cmd2 = new SqlCommand(
                    "UPDATE Ban SET TrangThai = N'Trống' WHERE MaBan = @Ban", conn);
                cmd2.Parameters.AddWithValue("@Ban", banDangChon);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Thanh toán thành công!");

                // reload lại giao diện
                maHoaDonHienTai = 0;
                dataGridViewchitiethoadon.DataSource = null;

                LoadBan();
            }
        }
        // In hóa đơn
        private void butInhoadon_Click(object sender, EventArgs e)
        {
            if (maHoaDonHienTai == 0)
            {
                MessageBox.Show("Không có hóa đơn nào!");
                return;
            }
            // Mở form hóa đơn
            formhoadon f = new formhoadon(maHoaDonHienTai);
            f.ShowDialog();

        }

    }
}
