using Quản_lý_Quán_Cafe.DAL;
using Quản_lý_Quán_Cafe.ObjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_Quán_Cafe.BLL
{
    public class UserService
    {
        private UserRepo _userRepo;
        public UserService()
        {
            _userRepo = new UserRepo();
        }

        public User AuthenticatedUser(string username, string password)
        {
            User user = _userRepo.GetUserByUserName(username);

            if (user == null)
            {
                return null; // Không tồn tại người dùng            
            }
            if (password == user.PassWordHash)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
