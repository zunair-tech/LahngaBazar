﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LehngaBazar.Entities
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }

        public Category category { get; set; }

    }
}
