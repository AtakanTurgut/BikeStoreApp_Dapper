﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.Models.StoreProcedure
{
    public class UpdateProductSP : InsertProductSP
    {
        public int product_id { get; set; }
    }
}
