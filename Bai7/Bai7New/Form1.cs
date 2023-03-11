using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7New
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string phepTinh = "";
        bool xoaKhong = false;
        bool daCong = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblNhap.Text == "0" || (xoaKhong))
                lblNhap.Text = "";
            xoaKhong = false;

            Button bt = (Button)sender;
            lblNhap.Text += bt.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string bt = ((Button)sender).Text;

            if (result == 0)
            {
                phepTinh = bt;
                result = Double.Parse(lblNhap.Text);
                lblBieuThuc.Text = result + " " + phepTinh + " ";
            }
            else
            {
                if (!daCong)
                {
                    button14.PerformClick();
                    daCong = true;
                }
                phepTinh = bt;
                lblBieuThuc.Text = result + " " + phepTinh + " ";
            }
            xoaKhong = true;
            daCong = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblBieuThuc.Text += lblNhap.Text + " = ";
            switch (phepTinh)
            {
                case "+":
                    lblNhap.Text = (result + Double.Parse(lblNhap.Text)) + "";
                    break;
                case "-":
                    lblNhap.Text = (result - Double.Parse(lblNhap.Text)) + "";
                    break;
                case "*":
                    lblNhap.Text = (result * Double.Parse(lblNhap.Text)) + "";
                    break;
                case "/":
                    if (lblNhap.Text == "0")
                        lblNhap.Text = "Error";
                    else
                        lblNhap.Text = (result / Double.Parse(lblNhap.Text)) + "";
                    break;
            }

            if (!Double.TryParse(lblNhap.Text, out result))
            {
                lblNhap.Text = "Không tính được";
                xoaKhong = true;
            }
            daCong = true;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblBieuThuc.Text = "";
            lblNhap.Text = "";
            result = 0;
            phepTinh = "";
            daCong = false;
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                    button.BackColor = colorDialog.Color;
            }
        }

        private void changeFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control controls in this.Controls)
                    controls.Font = fontDialog.Font;
            }
        }
    }
}
