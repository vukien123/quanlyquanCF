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
    public partial class formhoadon : Form
    {
        int maHD;
        public formhoadon(int mahoadon)
        {
            InitializeComponent();
            maHD = mahoadon;
            LoadThongTinHoaDon();
            LoadTongTienTamTinh();
        }

        void LoadThongTinHoaDon()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();

                // Lấy thông tin hóa đơn
                string sql1 = @"SELECT HD.MaHD, HD.NgayLap, HD.TongTien, B.TenBan
                                FROM HoaDon HD
                                JOIN Ban B ON HD.MaBan = B.MaBan
                                WHERE HD.MaHD = @MaHD";

                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@MaHD", maHD);

                SqlDataReader rd = cmd1.ExecuteReader();
                if (rd.Read())
                {
                    txtmahd.Text = rd["MaHD"].ToString();
                    txtngaylap.Text = Convert.ToDateTime(rd["NgayLap"]).ToString("dd/MM/yyyy HH:mm");
                    txtban.Text = rd["TenBan"].ToString();
                    txttongtien.Text = rd["TongTien"].ToString() + " VNĐ";
                }
                rd.Close();

                // Lấy chi tiết hóa đơn
                string sql2 = @"SELECT DU.TenDoUong AS [Tên đồ uống], 
		                               CT.SoLuong AS [Số lượng], 
		                               DU.DonGia AS [Đơn giá], 
		                               CT.ThanhTien AS [Thành tiền]
                                FROM ChiTietHoaDon CT
                                JOIN DoUong DU ON CT.MaDoUong = DU.MaDoUong
                                WHERE MaHD = @MaHD";

                SqlDataAdapter da = new SqlDataAdapter(sql2, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaHD", maHD);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewchitiethd.DataSource = dt;

                // chỉnh đẹp bảng
                dataGridViewchitiethd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewchitiethd.ReadOnly = true;
            }
        }
        void LoadTongTienTamTinh()
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(ThanhTien), 0) FROM ChiTietHoaDon WHERE MaHD = @MaHD",
                    conn);

                cmd.Parameters.AddWithValue("@MaHD", maHD);

                int tongTien = Convert.ToInt32(cmd.ExecuteScalar());
                txttongtien.Text = tongTien.ToString("N0") + " VND";
            }
        }

        private void formhoadon_Load(object sender, EventArgs e)
        {

        }
    }
}
