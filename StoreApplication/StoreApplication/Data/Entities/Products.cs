using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Data.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CostPrice { get; set; }
        public int SalePrice { get; set; }
        public int Count { get; set; }
        public DateTime CratedAt { get; set; } = DateTime.UtcNow.AddHours(4);
        
    }
}
