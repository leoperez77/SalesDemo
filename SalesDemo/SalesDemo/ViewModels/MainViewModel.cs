﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDemo.ViewModels
{
    public class MainViewModel
    {
        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            Products = new ProductsViewModel();
        }
    }
}
