﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models.EntityModels
{
    public class Inventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public Product Product { get; set; }

    }
}
