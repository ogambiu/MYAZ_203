﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_3
{
    public class CartItem
    {
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
