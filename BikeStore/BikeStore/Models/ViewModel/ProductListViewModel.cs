﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.Models.ViewModel
{
    public class ProductListViewModel
    {
        public int product_id { get; set; }
        public string brand_name { get; set; }
        public string category_name { get; set; }
        public string product_name { get; set; }
        public int model_year { get; set; }
        public decimal list_price { get; set; }
    }
}
