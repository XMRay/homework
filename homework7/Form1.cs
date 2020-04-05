using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {            
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(n, 200, 310, length, -Math.PI / 2);
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int n = 10;
        double length = 100;
        Pen pen1 = new Pen(Color.Blue);
        
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n-1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n-1, x1, y1, per2 * leng, th-th2);
            
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen1,(int)x0, (int)y0, (int)x1, (int)y1);
        }

        //右分支角度
        private void t5_TextChanged(object sender, EventArgs e)
        {

            string tth1 = t5.Text;
            if (!double.TryParse(tth1, out th1))
            {
                t5.Text = "请输入数字";
            }
            else
            {
                th1 = Convert.ToDouble(tth1) * Math.PI / 180;
            }
        }
        //左分支角度
        private void t6_TextChanged(object sender, EventArgs e)
        {
            string tth2 = t6.Text;
            if (!double.TryParse(tth2, out th2))
            {
                t6.Text = "请输入数字";
            }
            else
            {
                th2 = Convert.ToDouble(tth2) * Math.PI / 180;
            }
        }
        //递进层数
        private void t1_TextChanged_1(object sender, EventArgs e)
        {
            string tn = t1.Text;
            n = Convert.ToInt32(tn);
        }
        //主干长度
        private void t2_TextChanged_1(object sender, EventArgs e)
        {
            string tl = t2.Text;
            if (!double.TryParse(tl, out length))
            {
                t2.Text = "请输入数字";
            }
            else
            {
                length = Convert.ToDouble(tl);
            }
        }
        //右分支长度
        private void t3_TextChanged(object sender, EventArgs e)
        {
            string tp1 = t3.Text;
            if (!double.TryParse(tp1, out per1))
            {
                t3.Text = "请输入数字";
            }
            else
            {
                per1 = Convert.ToDouble(tp1);
            }
        }
        //左分支长度
        private void t4_TextChanged(object sender, EventArgs e)
        {
            string tp2 = t4.Text;
            if (!double.TryParse(tp2, out per2))
            {
                t4.Text = "请输入数字";
            }
            else
            {
                per2 = Convert.ToDouble(tp2);
            }
            
        }

        private void bc_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            pen1.Color = c;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
