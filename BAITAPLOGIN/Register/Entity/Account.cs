using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Account
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string SoDienThoai { get; set; }

        public Account(string taiKhoan, string matKhau, string soDienThoai)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            SoDienThoai = soDienThoai;
        }

        public Account(string taiKhoan, string matKhau)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }
    }
}
