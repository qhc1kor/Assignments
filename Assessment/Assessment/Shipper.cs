using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderSystem
{
    public class Shipper : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void ShipOrder(Order order)
        {
            Console.WriteLine($"Shipper {Name} is shipping order for {order.Product.Name}.");
        }
    }
}
