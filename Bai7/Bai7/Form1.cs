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
        double result = 0;
        string operation = "";
        bool enter_value = false;
        bool dauBang = false;
        int clickCount = 0;
        bool bang = false;
        int clickBang = 0;
        bool tinh = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            clickBang++;
            if (!dauBang)
            {
                result = double.Parse(lblResult.Text);
                lblTinh.Text = result + " = ";
            }
            else
            {
                if (clickBang == 1 || tinh)
                {
                    bang = true;
                    tinh = false;
                    lblTinh.Text += lblResult.Text + " = ";
                    switch (operation)
                    {
                        case "+":
                            result += double.Parse(lblResult.Text);
                            lblResult.Text = result + "";
                            break;
                        case "-":
                            result -= double.Parse(lblResult.Text);
                            lblResult.Text = result + "";
                            break;
                        case "*":
                            result *= double.Parse(lblResult.Text);
                            lblResult.Text = result + "";
                            break;
                        case "/":
                            if (lblResult.Text == "0")
                                lblResult.Text = "Không chia được";
                            else
                            {
                                result /= double.Parse(lblResult.Text);
                                lblResult.Text = result + "";
                            }
                            break;
                    }
                }
                else
                {
                    result = double.Parse(lblResult.Text);
                    lblTinh.Text = result + " = ";
                    clickBang = 0;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            lblTinh.Text = "";
            result = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" || enter_value)
                lblResult.Text = "";
            enter_value = false;

            string txtButton = ((Button)sender).Text;
            lblResult.Text += txtButton;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickCount++;
            operation = ((Button)sender).Text;
            dauBang = true;
            enter_value = true;
            tinh = true;
            if (clickCount == 1 || bang)
            {
                if (double.TryParse(lblResult.Text, out result))
                {
                    lblTinh.Text = result + " " + operation + " ";
                }
                else
                {
                    result = 0;
                    lblTinh.Text = result + " " + operation + " ";
                }
                bang = false;
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        result += double.Parse(lblResult.Text);
                        lblResult.Text = result + "";
                        break;
                    case "-":
                        result -= double.Parse(lblResult.Text);
                        lblResult.Text = result + "";
                        break;
                    case "*":
                        result *= double.Parse(lblResult.Text);
                        lblResult.Text = result + "";
                        break;
                    case "/":
                        if (lblResult.Text == "0")
                            lblResult.Text = "Không chia được";
                        else
                        {
                            result /= double.Parse(lblResult.Text);
                            lblResult.Text = result + "";
                        }
                        break;
                }
                lblTinh.Text = lblResult.Text + " " + operation + " ";
                
            }
        }

    }
}
