using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator_WFA
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        string c = "";
        string sa;
        string sb;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signL.Text = "+";
            c = "+";
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {
             sa = t1.Text;           
        }
        private void t2_TextChanged(object sender, EventArgs e)
        {
            sb = t2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (!double.TryParse(sa, out a))
                {
                    t1.Text = "";
                    t3.Text = "请输入数字";
                }
                else 
                { 
                    if (!double.TryParse(sb, out b))
                    {
                        t2.Text = "";
                        t3.Text = "请输入数字";
                    }
                    else
                    {
                        switch (c)
                        {
                            case "+":
                                t3.Text = (a + b).ToString();
                                break;
                            case "-":
                                t3.Text = (a - b).ToString();
                                break;
                            case "*":
                                t3.Text = (a * b).ToString();
                                break;
                            case "/":
                                if (b != 0)
                                {
                                    t3.Text = (a / b).ToString();
                                }
                                else
                                {
                                    t3.Text = "0不能被除";
                                }
                                break;
                            default:
                                t3.Text = "请输入运算";
                                break;
                        }
                        button1.Text = "点我能清空";

                    }

                } 
        }
            


        private void button3_Click(object sender, EventArgs e)
        {
            signL.Text = "-";
            c = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            signL.Text = "*";
            c = "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            signL.Text = "/";
            c = "/";
        }


        private void t3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
