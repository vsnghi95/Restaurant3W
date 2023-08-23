﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject2
{
    public partial class FoodCategory
    {
        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }

        public int Cateid { get; set; }
        public string Catename { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
