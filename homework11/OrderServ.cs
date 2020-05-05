using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace orderSql
{
    //订单服务类
    [Serializable]
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        public OrderService() { }
        //添加订单
        public void add(Order o)
        {
            if (o.OrderID == null || o.CltName == null || o == null)
            {
                Console.WriteLine("不能为空");
            }
            else
            {
                bool isRepeat = false;
                foreach (Order order in orders)
                {
                    if (order.Equals(o))
                    {
                        //Console.WriteLine(Equals(o));
                        isRepeat = true;
                        break;
                    }
                }
                if (!isRepeat)
                {
                    orders.Add(o);
                }
                else
                {
                    Console.WriteLine("重复了");
                }
                //自动排序
                //sort();
            }
        }

        //删除订单
        public void delete(Order o)
        {
            orders.Remove(o);
        }

        //排序
        public void sort()
        {
            orders.Sort((Order o1, Order o2) => o1.OrderID.CompareTo(o2.OrderID));
        }

        //显示全部订单
        public void show()
        {
            foreach (Order o in orders)
            {
                Console.WriteLine(o.ToString());
            }
        }

        //订单号查找
        public void seekOrderID(string a)
        {
            var query = from o in orders
                        where o.OrderID == a
                        orderby o.Sum
                        select o;
            List<Order> list = query.ToList();
            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }

        }

        //客户名查询
        public void seekCltName(string a)
        {
            var query = from o in orders
                        where o.CltName == a
                        orderby o.Sum
                        select o;
            List<Order> list = query.ToList();
            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }

        //商品名查询
        public void seekProName(string a)
        {
            List<OrderDetails> list = new List<OrderDetails>();
            foreach (Order o in orders)
            {
                var query = from d in o.details
                            where d.ProName == a
                            select d;
                List<OrderDetails> list1 = query.ToList();
                list.InsertRange(0, list1);
                list.Sort((OrderDetails o1, OrderDetails o2) => o1.num.CompareTo(o2.num));
            }
            foreach (OrderDetails d in list)
            {
                Console.WriteLine(d.ToString() + " 订单号:" + d.OrderID + " 客户名:" + d.CltName);
            }
        }

        public void Export(string p)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderService));
            using (FileStream fs = new FileStream(p, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, this);

            }
            Console.WriteLine("\nSerialized as XML:");
            Console.WriteLine(File.ReadAllText("s.xml"));
        }
        public void Import(string p)
        {
            OrderService s = new OrderService();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderService));
            using (FileStream fs = new FileStream(p, FileMode.Open))
            {
                s = (OrderService)xmlSerializer.Deserialize(fs);
                Console.WriteLine("\nDeserialized from s.xml");
                this.orders.InsertRange(0, s.orders);
                this.show();
            }
        }
    }
}
