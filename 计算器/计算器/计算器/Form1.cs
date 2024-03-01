using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {

        public string Number { get; set; }
        public string outcome { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
      

        private void button20_Click(object sender, EventArgs e)
        {
            double Num = 0;
            string symbol = string.Empty;
            try
            {
                string result = label1.Text.Substring(0, label1.Text.Length - 1);
                symbol = label1.Text.Substring(label1.Text.Length - 1);
                Num = double.Parse(result);

                if (symbol.Contains("-"))
                {
                    label1.Text = (Num - double.Parse(label2.Text)).ToString();
                    Number = label1.Text;
                }
                else if (symbol.Contains("+"))
                {
                    label1.Text = (Num + double.Parse(label2.Text)).ToString();
                    Number = label1.Text;
                }
                else if (symbol.Contains("*"))
                {
                    label1.Text = (Num * double.Parse(label2.Text)).ToString();
                    Number = label1.Text;
                }
                else if (symbol.Contains("/"))
                {
                    label1.Text = (Num / double.Parse(label2.Text)).ToString();
                    Number = label1.Text;
                }
                Number = "";
                label2.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Number = "";
            label1.Text = "";
            label2.Text = "0";
        }

        #region 数字
        private void button18_Click(object sender, EventArgs e)
        {
            Number = Number + "0";
            label2.Text = double.Parse(Number).ToString();
        }
        private void button13_Click(object sender, EventArgs e)
        {

            Number = Number + "1";
            label2.Text = double.Parse(Number).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Number = Number + "2";
            label2.Text = double.Parse(Number).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Number = Number + "3";
            label2.Text = double.Parse(Number).ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Number = Number + "4";
            label2.Text = double.Parse(Number).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Number = Number + "5";
            label2.Text = double.Parse(Number).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Number = Number + "6";
            label2.Text = double.Parse(Number).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number = Number + "7";
            label2.Text = double.Parse(Number).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number = Number + "8";
            label2.Text = double.Parse(Number).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number = Number + "9";
            label2.Text = double.Parse(Number).ToString();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            Number = Number + ".";
            label2.Text = double.Parse(Number).ToString();
        }
        #endregion
        #region 符号
        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = Number + "-";
                label2.Text = Number = "";
            }
            else
            {
                string symbol = string.Empty;
                string result = string.Empty;
                try
                {
                    result = label1.Text.Substring(0, label1.Text.Length - 1);
                    symbol = label1.Text.Substring(label1.Text.Length - 1);
                    double.Parse(symbol);
                    label1.Text = label1.Text + "-";
                    label2.Text = Number = "";
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrEmpty(symbol) && !string.IsNullOrEmpty(result))
                    {
                        label1.Text = result + "-";
                        label2.Text = Number = "";
                    }
                }
            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = Number + "+";
                label2.Text = Number = "";
            }
            else
            {
                string symbol = string.Empty;
                string result = string.Empty;
                try
                {
                    result = label1.Text.Substring(0, label1.Text.Length - 1);
                    symbol = label1.Text.Substring(label1.Text.Length - 1);
                    double.Parse(symbol);
                    label1.Text = label1.Text + "+";
                    label2.Text = Number = "";
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrEmpty(symbol) && !string.IsNullOrEmpty(result))
                    {
                        label1.Text = result + "+";
                        label2.Text = Number = "";
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = Number + "*";
                label2.Text = Number = "";
            }
            else
            {
                string symbol = string.Empty;
                string result = string.Empty;
                try
                {
                    result = label1.Text.Substring(0, label1.Text.Length - 1);
                    symbol = label1.Text.Substring(label1.Text.Length - 1);
                    double.Parse(symbol);
                    label1.Text = label1.Text + "*";
                    label2.Text = Number = "";
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrEmpty(symbol) && !string.IsNullOrEmpty(result))
                    {
                        label1.Text = result + "*";
                        label2.Text = Number = "";
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = Number + "/";
                label2.Text = Number = "";
            }
            else
            {
                string symbol = string.Empty;
                string result = string.Empty;
                try
                {
                    result = label1.Text.Substring(0, label1.Text.Length - 1);
                    symbol = label1.Text.Substring(label1.Text.Length - 1);
                    double.Parse(symbol);
                    label1.Text = label1.Text + "/";
                    label2.Text = Number = "";
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrEmpty(symbol) && !string.IsNullOrEmpty(result))
                    {
                        label1.Text = result + "/";
                        label2.Text = Number = "";
                    }
                }
            }
        }
        #endregion

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(label2.Text))
                {
                    label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
                    Number = label2.Text;
                }
            }
            catch (Exception ex)
            {

            }
        }

       

        private void button17_Click(object sender, EventArgs e)
        {
        }
    }
}
