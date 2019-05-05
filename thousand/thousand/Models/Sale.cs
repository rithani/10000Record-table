using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thousand.Models
{
    public class Sale
    {
        public string Region { get; set; }
        public string Country { get; set; }
        public string ItemType { get; set; }
        public string SalesChannel { get; set; }
        public string OrderPriority { get; set; }
        public DateTime OrderDate { get; set; }
        public float OrderId { get; set; }
        public DateTime Shipdate { get; set; }
        public float UnitsSold { get; set; }
        public float UnitPrice { get; set; }
        public float UnitCost { get; set; }
        public float TotalRevenue { get; set; }
        public float TotalCost { get; set; }
        public float TotalProfit { get; set; }

    }
}
