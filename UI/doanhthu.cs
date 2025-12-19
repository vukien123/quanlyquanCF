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
    public partial class doanhthu : UserControl
    {
        public doanhthu()
        {
            InitializeComponent();
        }
        // load hóa đơn theo ngày
        void LoadHoaDonTheoNgay(DateTime from, DateTime to)
        {
            using (SqlConnection conn = new SqlConnection(DBconection.connectionString))
            {
                conn.Open();

                string sql = @"SELECT MaHD, NgayLap, TongTien, TrangThaiPay, MaBan
                               FROM HoaDon
                               WHERE NgayLap BETWEEN @from AND @to
                               AND TrangThaiPay = 1";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@from", from);
                da.SelectCommand.Parameters.AddWithValue("@to", to);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewHoadon.AutoGenerateColumns = true;  // đảm bảo bật
                dataGridViewHoadon.DataSource = dt;
                dataGridViewHoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewHoadon.RowHeadersVisible = false;
                

                // tính tổng doanh thu
                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["TongTien"]);
                }

                txttongtien.Text = total.ToString("N0") + " VNĐ";
            }
        }
        // load form doanhthu mặc định là 7 ngày gần nhất
        private void doanhthu_Load(object sender, EventArgs e)
        {
            DTtừngày.Value = DateTime.Now.AddDays(-7);
            DTđếnngày.Value = DateTime.Now;

            LoadHoaDonTheoNgay(DTtừngày.Value, DTđếnngày.Value);
        }
        // nút lọc theo ngày
        private void butLọctgian_Click_1(object sender, EventArgs e)
        {
            LoadHoaDonTheoNgay(DTtừngày.Value.Date, DTđếnngày.Value.Date);
        }
    }
}
