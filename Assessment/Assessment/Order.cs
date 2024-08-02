using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderSystem
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
