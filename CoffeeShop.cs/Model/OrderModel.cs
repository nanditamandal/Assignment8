﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.cs.Model
{
    public class OrderModel
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string ItemName{ set; get; }
        public int Quantity { set; get; }
    }
}
