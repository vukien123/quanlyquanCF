using Microsoft.Data.SqlClient;
using Quản_lý_Quán_Cafe.DAL;
using Quản_lý_Quán_Cafe.ObjectData;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_Quán_Cafe.DAL
{
    public class UserRepo
    {
        public User GetUserByUserName(string username)
        {
            User user = null;
            string sql =  @"SELECT Userid, UserName, PassWordHash, RoleName, FullName 
                            FROM [User] 
                            WHERE UserName = @UserName";

            using (SqlConnection connection = DBconection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    Userid = reader.GetInt32(0),
                                    UserName = reader.GetString(1),
                                    PassWordHash = reader.GetString(2),
                                    RoleName = reader.GetString(3),
                                    FullName = reader.GetString(4),
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi truy vấn người dùng: \n" + ex.Message);
                    }
                }
            }
            return user;

        }
    }
}
