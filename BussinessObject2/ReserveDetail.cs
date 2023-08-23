using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject2
{
    public partial class ReserveDetail
    {
        public int Rdid { get; set; }
        public int? Rid { get; set; }
        public int? Tid { get; set; }

        public virtual Reservation RidNavigation { get; set; }
        public virtual TablesRe TidNavigation { get; set; }
    }
}
