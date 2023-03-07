using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace Register
{
    public partial class FormRegister : Form
    {
        private CAddAccount cAdd;

        public FormRegister()
        {
            InitializeComponent();
            cAdd = new CAddAccount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte lenTK = (byte)txtUser.Text.Length;
            byte lenMK = (byte)txtPass.Text.Length;
            byte lenSDT = (byte)txtPhoneNumber.Text.Length;
            int a;

            if (lenTK == 0)
                MessageBox.Show("Vui lòng nhập tài khoản", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (lenMK == 0)
                MessageBox.Show("Vui lòng nhập mật khẩu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (lenSDT == 0)
                MessageBox.Show("Vui lòng nhập số điện thoại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!int.TryParse(txtPhoneNumber.Text, out a))
                MessageBox.Show("Số điện thoại phải nhập số", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cAdd.AddAccount(txtUser.Text, txtPass.Text, txtPhoneNumber.Text))
            {
                MessageBox.Show("Tạo tài khoản thành công");
            }
            else
                MessageBox.Show("Tài khoản đã tồn tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
