using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ECheckLogin
    {
        private ConnectSql connectSql;

        public ECheckLogin()
        {
            connectSql = new ConnectSql();
        }

        public bool CheckLogin(string taiKhoan, string matKhau)
        {

            return connectSql.findUser(new Account(taiKhoan, matKhau));
        }
    }
}
