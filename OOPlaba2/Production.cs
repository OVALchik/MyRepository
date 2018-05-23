﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlaba2
{
    public abstract class Production
    {       
        public string NameProduction { get; private set; }
        public Size SizeProduction { get; private set; }
        public int CountProduction { get; private set; }
        public decimal PriceProduction { get; private set; }

        public Production(string name, double length, double width, double hight, double weight, int count, decimal price)
        {
            NameProduction = name;
            SizeProduction = new Size(length, width, hight, weight);
            CountProduction = count;
            PriceProduction = price;
        }

        public abstract void ShowInfoProduction();

    }
}
