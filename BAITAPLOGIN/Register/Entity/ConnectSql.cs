using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entity
{
    class ConnectSql
    {
        private string strConn = "Data Source=DESKTOP-BED894K;Initial Catalog=Acc;Integrated Security=True";
        private SqlConnection conn = null;

        public ConnectSql()
        {
            conn = new SqlConnection(strConn);
        }

        private void OpenConnect()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void CloseConnect()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private bool checkTaiKhoan(string taiKhoan, out SqlDataReader reader)
        {
            string query = "SELECT TaiKhoan, MatKhau FROM DangKy WHERE TaiKhoan = @user";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", taiKhoan);

            reader = cmd.ExecuteReader();
            bool check = false;
            if (reader.HasRows)
                check = true;
            return check;
        }

        public bool AddAccount(Account acc)
        {
            OpenConnect();
            SqlDataReader reader = null;
            if (checkTaiKhoan(acc.TaiKhoan, out reader))
            {
                CloseConnect();
                return false;
            }
            reader.Close();
            string query = "INSERT INTO DangKy VALUES (@user, @pass, @sdt)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", acc.TaiKhoan);
            cmd.Parameters.AddWithValue("@pass", acc.MatKhau);
            cmd.Parameters.AddWithValue("@sdt", acc.SoDienThoai);

            bool check = cmd.ExecuteNonQuery() == 1;

            CloseConnect();
            return check;
        }

        public bool findUser(Account acc)
        {
            OpenConnect();
            bool check = false;
            SqlDataReader reader = null;
            if (checkTaiKhoan(acc.TaiKhoan, out reader))
            {
                if (reader.Read() && reader.GetString(1) == acc.MatKhau)
                    check = true;
            }
            reader.Close();
            CloseConnect();
            return check;
        }
    }
}
