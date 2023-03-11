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
    public partial class FormLogin : Form
    {
        private CCheckLogin check;
        public FormLogin()
        {
            check = new CCheckLogin();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegister rg = new FormRegister();
            rg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
                MessageBox.Show("Vui lòng nhập tài khoản", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtPass.Text == "")
                MessageBox.Show("Vui lòng nhập mật khẩu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (check.CheckLogin(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                txtUser.Focus();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");

        }
    }
}
