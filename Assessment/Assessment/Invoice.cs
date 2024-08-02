using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderSystem
{
    public class Invoice
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Employee ProcessedBy { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount => Order.OrderDetail.TotalPrice;
    }
}
