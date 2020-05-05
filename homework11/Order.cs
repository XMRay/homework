using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace orderSql
{
    public class Order
    {
        public string OrderID { get; set; }
        [Required]
        public string CltName { get; set; }
        public double Sum { set; get; }

        public Order(string num, string client)
        {
            OrderID = num;
            CltName = client;
            Sum = this.getSum();
        }
        public List<OrderDetails> details = new List<OrderDetails>();
        public Order() { }

        //获取总价
        public double getSum()
        {
            double total = 0;
            foreach (OrderDetails detail in details)
            {
                total += detail.num * detail.price;
            }
            return total;
        }
        //equals
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o == null || o.OrderID == OrderID || o.OrderID == ""/*&& o.CltName == CltName*/;
        }


        //添加商品
        public void add(OrderDetails d)
        {
            bool isRepeat = false;
            foreach (OrderDetails de in details)
            {
                if (de.Equals(d))
                {
                    //Console.WriteLine(Equals(o));
                    isRepeat = true;
                    break;
                }
            }
            if (!isRepeat)
            {
                details.Add(d);
            }
            else
            {
                Console.WriteLine("重复了");
            }
            Sum += d.num * d.price;
            d.OrderID = this.OrderID;
            d.CltName = this.CltName;
        }

        public override string ToString()
        {
            string s = "";
            foreach (OrderDetails d in details)
            {
                s += d.ToString();
            }
            return "订单号:" + OrderID + "\n客户名:" + CltName + "\n总价:" + Sum + "\n订单明细:" + s + "\n";
        }

        public override int GetHashCode()
        {
            int hashCode = 813372120;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CltName);
            hashCode = hashCode * -1521134295 + Sum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(details);
            return hashCode;
        }
    }
}
