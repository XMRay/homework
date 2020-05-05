using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace orderSql
{
    //订单明细类
    public class OrderDetails
    {
        public string ProID { get; set; }
        [Required]
        public string OrderID { get; set; }
        public string CltName { get; set; }
        public int num { get; set; }
        
        public double price { get; set; }
        public string ProName { get; set; }
        public Order order { get; set; }
        public OrderDetails(int n, string proName, double p)
        {
            num = n;
            ProName = proName;
            price = p;
        }
        public OrderDetails() { }
        public override bool Equals(object obj)
        {
            OrderDetails d = obj as OrderDetails;
            return d == null || d.num == num && d.ProName == ProName && d.price == price;
        }


        public override string ToString()
        {
            return "\n    商品名:" + ProName + " 数量:" + num + " 单价:" + price;
        }

        public override int GetHashCode()
        {
            int hashCode = -1537382045;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CltName);
            hashCode = hashCode * -1521134295 + num.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProName);
            hashCode = hashCode * -1521134295 + price.GetHashCode();
            return hashCode;
        }
    }
}
