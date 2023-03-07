using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class CAddAccount
    {
        private EAddAccount eAdd;

        public CAddAccount()
        {
            eAdd = new EAddAccount();
        }

        public bool AddAccount(string taiKhoan, string matKhau, string soDienThoai)
        {
            return eAdd.AddAccount(taiKhoan, matKhau, soDienThoai);
        }
    }
}
