using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject2
{
    public partial class TablesRe
    {
        public TablesRe()
        {
            ReserveDetails = new HashSet<ReserveDetail>();
        }

        public int Tid { get; set; }
        public string TableName { get; set; }
        public int? Capacity { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<ReserveDetail> ReserveDetails { get; set; }
    }
}
