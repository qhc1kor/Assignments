using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderSystem
{
    public interface IOrderService
    {
        Order CreateOrder(Customer customer, Product product);
        Invoice ProcessOrder(Order order, Employee employee);
        void SupplyOrder(Order order, Supplier supplier);
        void ShipOrder(Order order, Shipper shipper);
    }
}
