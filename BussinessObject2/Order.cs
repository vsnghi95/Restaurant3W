using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject2
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Oid { get; set; }
        public int? Rid { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? NumGuest { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Reservation RidNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
