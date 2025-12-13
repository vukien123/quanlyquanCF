using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_Quán_Cafe.DAL
{
    internal class DBconection
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\kỹ thuật lập trình ứng dụg\Quản lý Quán Cafe\QLCAFE.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True"; // Chuỗi kết nối
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối đến csdl: \n" + ex.Message);
            }
        }
    }
}
