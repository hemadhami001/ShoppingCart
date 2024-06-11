﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Product Products { get; set; }
        public Cart Cart { get; set; }
        public int CartId { get; set; }
    }
}
