using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Data.Entities
{
    public class Comments
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(4);
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public Users User { get; set; }
        public Products Product { get; set; }
    }
}
