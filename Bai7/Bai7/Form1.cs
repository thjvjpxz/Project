using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        private string phepTinh;
        private long so1;
        private double so2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tbTinh.Clear();
            tbKetQua.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tbTinh.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            phepTinh = "+";
            so1 = long.Parse(tbTinh.Text);
            tbTinh.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (phepTinh)
            {
                case "+": so2 = so1 + long.Parse(tbTinh.Text);
                    tbTinh.Text = so1 + "+" + tbTinh.Text + "="; 
                    tbKetQua.Text = so2 + "";
                    break;
                case "-": so2 = so1 - long.Parse(tbTinh.Text);
                    tbTinh.Text = so1 + "-" + tbTinh.Text + "="; 
                    tbKetQua.Text = so2 + "";
                    break;
                case "*": so2 = so1 * long.Parse(tbTinh.Text);
                    tbTinh.Text = so1 + "*" + tbTinh.Text + "=";
                    tbKetQua.Text = so2 + "";
                    break;
                case "/":
                    if (tbTinh.Text == "0")
                        tbKetQua.Text = "Không chia được";
                    else
                    {
                        so2 = (double) so1 / long.Parse(tbTinh.Text);
                        tbTinh.Text = so1 + "/" + tbTinh.Text + "=";
                        tbKetQua.Text = so2 + "";
                    }
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbTinh.Text == "")
            {
                tbTinh.Text = "-";
            }
            else
            {
                phepTinh = "-";
                so1 = long.Parse(tbTinh.Text);
                tbTinh.Clear();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            phepTinh = "*";
            so1 = long.Parse(tbTinh.Text);
            tbTinh.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            phepTinh = "/";
            so1 = long.Parse(tbTinh.Text);
            tbTinh.Clear();
        }

    }
}
