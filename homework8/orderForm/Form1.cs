using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using orderServ;


namespace ordersForms
{
    public partial class Form1 : Form
    {
        OrderService orderService = new OrderService();
        OrderService orderService1 = new OrderService();
        Order os = new Order("", "");
        int n = 0;
        string orID = "";
        string orName = "";
        string comName = "";
        int comNum = 0;
        double comPrice = 0;

        public string KeyWord { get; set; }
        string s;
        public Form1()
        {
            InitializeComponent();
            Order o1 = new Order("165", "李");
            OrderDetails d7 = new OrderDetails(9, "chair", 10);           //数量，名称，价格 
            OrderDetails d1 = new OrderDetails(1, "apple", 11);
            OrderDetails d2 = new OrderDetails(2, "banana", 5);
            o1.add(d1);
            o1.add(d2);
            o1.add(d7);
            Order o2 = new Order("192", "赵");
            OrderDetails d3 = new OrderDetails(3, "chair", 10);
            OrderDetails d4 = new OrderDetails(4, "desk", 6);
            o2.add(d3);
            o2.add(d4);
            Order o3 = new Order("15", "王");
            OrderDetails d5 = new OrderDetails(5, "egg", 3);
            OrderDetails d6 = new OrderDetails(6, "fish", 2);
            o3.add(d5);
            o3.add(d6);
            
            orderService.add(o1);
            orderService.add(o2);
            orderService.add(o3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bindingSource2.DataSource = orderService.orders;
            //bindingSource1.DataSource = orderService.orders;
            textBox1.DataBindings.Add("Text", this, "KeyWord");           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //n = dataGridView1.CurrentCell.RowIndex;
            //textBox2.Text = n.ToString();
            //s = dataGridView1.Rows[n].Cells[0].Value.ToString();
            //var query = orderService.orders.First(t => t.OrderID == s);
            //bindingSource1.DataSource = query.details;

        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    n = dataGridView1.CurrentCell.RowIndex;
        //    textBox2.Text = n.ToString();
        //    s = dataGridView1.Rows[n].Cells[0].Value.ToString();
        //    var query = orderService.orders.First(t => t.OrderID == s);
        //    bindingSource1.DataSource = query.details;

        //}
        private void button1_Click(object sender, EventArgs e)
        {
            if (KeyWord == null || KeyWord == "")
            {
                bindingSource2.DataSource = orderService.orders;
            }
            else
            {
                bindingSource2.DataSource =
                   orderService.orders.Where(s => s.OrderID == KeyWord);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            orID = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            n = dataGridView1.CurrentCell.RowIndex;         
            s = dataGridView1.Rows[n].Cells[0].Value.ToString();
            var query = orderService.orders.First(t => t.OrderID == s);
                bindingSource1.DataSource = query.details;
            textBox7.Text ="订单号"+query.OrderID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            orName = textBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order o = new Order(orID, orName);
            orderService.add(o);
            button1_Click(this, e);
            bindingSource2.DataSource = orderService1.orders;
            bindingSource2.DataSource = orderService.orders;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            comName = textBox4.Text;

            if (!int.TryParse(textBox5.Text, out comNum))
            {

                textBox5.Text = "请输入整数";
            }
            else
            {
                if (!double.TryParse(textBox6.Text, out comPrice))
                {

                    textBox6.Text = "请输入数字";
                }
                else
                {
                    OrderDetails d = new OrderDetails(comNum,comName,comPrice);
                    n = dataGridView1.CurrentCell.RowIndex;
                    s = dataGridView1.Rows[n].Cells[0].Value.ToString();
                    var query = orderService.orders.First(t => t.OrderID == s);
                    query.add(d);
                    bindingSource2.DataSource = orderService1.orders;
                    bindingSource2.DataSource = orderService.orders;
                    bindingSource1.DataSource = os.details;
                    bindingSource1.DataSource = query.details;
                    textBox7.Text = "订单号" + query.OrderID;
                }
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        