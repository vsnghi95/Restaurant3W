using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject2
{
    public partial class Food
    {
        public Food()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Fid { get; set; }
        public string Fname { get; set; }
        public decimal? Price { get; set; }
        public int? Cateid { get; set; }

        public virtual FoodCategory Cate { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
