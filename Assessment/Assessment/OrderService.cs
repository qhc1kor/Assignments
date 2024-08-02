using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderSystem
{
    public class OrderService : IOrderService
    {
        public Order CreateOrder(Customer customer, Product product)
        {
            return new Order
            {
                Customer = customer,
                Product = product,
                OrderDate = DateTime.Now,
                OrderDetail = new OrderDetail { Quantity = 1, UnitPrice = product.Price }
            };
        }
        public Invoice ProcessOrder(Order order, Employee employee)
        {
            return employee.ProcessOrder(order);
        }

        public void SupplyOrder(Order order, Supplier supplier)
        {
            supplier.SupplyOrder(order);
        }

        public void ShipOrder(Order order, Shipper shipper)
        {
            shipper.ShipOrder(order);
        }
    }
}
