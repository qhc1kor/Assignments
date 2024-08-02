using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderSystem
{
    public class Employee : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Invoice ProcessOrder(Order order)
        {
            return new Invoice { Order = order, ProcessedBy = this, InvoiceDate = DateTime.Now };
        }
    }
}
