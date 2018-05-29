using System;

namespace OOPlaba2
{
    public abstract class Production
    {       
        public string NameProduction { get; private set; }
        public Size SizeProduction { get; private set; }
        public int CountProduction { get; private set; }
        public decimal PriceProduction { get; private set; }

        protected Production(string name, double length, double width, double hight, double weight, int count, decimal price)
        {
            if(length<=0 || width<=0 || hight<=0 || weight<=0)
                throw new ArgumentException("Габариты продукции введены неверно");

            NameProduction = name;
            SizeProduction = new Size(length, width, hight, weight);
            CountProduction = count;
            PriceProduction = price;
        }

        public abstract void ShowInfoProduction();

    }
}
