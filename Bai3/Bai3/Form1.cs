using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        private int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = DieuKien.NguyenTo(n);
            label6.Text = DieuKien.ChinhPhuong(n);
            label7.Text = DieuKien.HoanHao(n);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out n))
                label8.Text = "Vui lòng nhập số";
            else
            {
                label8.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (n <= 0 || n >= 1000)
                label8.Text = "0 < n < 1000";
        }
    }
}
