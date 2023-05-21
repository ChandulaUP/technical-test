using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    abstract class Order
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string OrderDueDate { get; set; }
        public int OrderNumber { get; set; }
        public List<Stationery> OrderedItems { get; set; }

        public abstract void GenerateReport();
        public string ToString()
        {
            return "\nName: " + CustomerName + " Address: " + CustomerAddress + " Due Date: " + OrderDueDate + " Order #: " + OrderNumber;
        }
    }
}
