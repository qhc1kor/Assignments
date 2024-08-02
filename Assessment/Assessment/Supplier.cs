using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderSystem
{
    public class Supplier : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void SupplyOrder(Order order)
        {
            Console.WriteLine($"Supplier {Name} is supplying order for {order.Product.Name}.");
        }
    }
}
