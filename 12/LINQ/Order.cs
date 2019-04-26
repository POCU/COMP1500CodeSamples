using System.Collections.Generic;

namespace LINQ
{
    public class Order
    {
        public long ID { get; set; }

        public string UserID { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
