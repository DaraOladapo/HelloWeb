﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CattyWebLibary.Models.Binding
{
    public class AddCatBindingModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Size Size { get; set; }
        public string Color { get; set; }
    }
}
