using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Data.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; } = null!;
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending"; // Pending, Completed, Cancelled

        // Relations
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

}
