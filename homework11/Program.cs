using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace orderSql
{

    class Program
    {
        static void Main(string[] args)
        {
            string newOrderID = "";
            string newProID = "";
            using (var context = new OrderContext())
            {
                var order = new Order { OrderID = "1546", CltName = "lili" };
                order.details= new List<OrderDetails>() {
                    new OrderDetails() { num = 3, ProID = "apple", price=45},
                    new OrderDetails() { num = 5, ProID = "banana", price=25}
                };
                context.Orders.Add(order);
                context.SaveChanges();
                newOrderID = order.OrderID;
            }
            using (var context = new OrderContext())
            {
                var detail = new OrderDetails() { num = 5, ProID = "banana", price = 25, OrderID = newOrderID };
                context.Entry(detail).State = EntityState.Added;
                context.SaveChanges();
                newProID = detail.ProID;
            }

        }
    }
}
