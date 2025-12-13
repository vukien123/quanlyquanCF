using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_Quán_Cafe.ObjectData
{
    public class User
    {
        public int Userid { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string PassWordHash { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
    }
}

