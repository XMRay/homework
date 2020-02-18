using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a = 0;
        double b = 0;
        double c = 0;
        int which = 0;
        bool isN = true;
        string s;
        //string sA;
        //string sB;
        public void show(int n)
        {
            t1.Text = t1.Text + n.ToString();
           // double d = Convert.ToDouble(n);
            if (which == 0)
            {              
                a = a * 10 + n;
            }
            else
            {
                b = b * 10 + n;
            }
            isN = false;
        }
        private void b9_Click(object sender, EventArgs e)
        {
            show(9);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            show(0);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            show(3);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            show(2);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            show(1);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            show(6);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            show(5);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            show(4);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            show(8);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            show(7);
        }

        private void ba_Click(object sender, EventArgs e)
        {
            if (isN == false) { 
                t1.Text = t1.Text + "+";
                s = "+";
                which++;
                isN = true;
            }    
        }

        private void bb_Click(object sender, EventArgs e)
        {
            if (isN == false)
            {
                t1.Text = t1.Text + "-";
                s = "-";
                which++;
                isN = true;
            }
        }

        private void bc_Click(object sender, EventArgs e)
        {
            if (isN == false)
            {
                t1.Text = t1.Text + "*";
                s = "*";
                which++;
                isN = true;
            }
        }

        private void bd_Click(object sender, EventArgs e)
        {
            if (isN == false)
            {
                t1.Text = t1.Text + "/";
                s = "/";
                which++;
                isN = true;
            }
        }

        private void be_Click(object sender, EventArgs e)
        {
            if (isN == false)
            {
                t1.Text = t1.Text + "=";
                switch (s)
                {
                    case "+":
                        c = a + b;
                        break;
                    case "-":
                        c = a - b;
                        break;
                    case "*":
                        c = a * b;
                        break;
                    case "/":
                        if (b != 0)
                        {
                            c = a / b;
                        }
                        break;
                    default:
                        c = a;
                        break;
                }
                isN = true;
                string line = "\r\n";
                t1.Text = t1.Text + c.ToString()+line;
                a = 0;
                b = 0;
                which = 0;
            }
        }
        private void bf_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            c = 0;
            a = 0;
            b = 0;
            which = 0;
            isN = true;

        }
    }
}

