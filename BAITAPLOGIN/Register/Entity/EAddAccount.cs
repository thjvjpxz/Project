using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EAddAccount
    {
        private ConnectSql connect;

        public EAddAccount()
        {
            connect = new ConnectSql();
        }

        public bool AddAccount(string taiKhoan, string matKhau, string soDienThoai)
        {
            return connect.AddAccount(new Account(taiKhoan, matKhau, soDienThoai));
        }
    }
}
