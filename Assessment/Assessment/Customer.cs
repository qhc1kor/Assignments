using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderSystem
{
    public class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Order PlaceOrder(Product product)
        {
            return new Order { Customer = this, Product = product, OrderDate = DateTime.Now, OrderDetail = new OrderDetail { Quantity = 1, UnitPrice = product.Price } };
        }
    }
}
