using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class CCheckLogin
    {
        private ECheckLogin check;

        public CCheckLogin()
        {
            check = new ECheckLogin();
        }

        public bool CheckLogin(string taiKhoan, string matKhau)
        {
            return check.CheckLogin(taiKhoan, matKhau);
        }
    }
}
