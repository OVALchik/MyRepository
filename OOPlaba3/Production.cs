using System;
using System.Xml.Serialization;

namespace OOPlaba2
{
    [XmlInclude(typeof(PrimaryProduction))]
    [XmlInclude(typeof(FinalProduction))]
    //[XmlInclude(typeof(SecondaryProduction))]
    [Serializable]
    public abstract class Production
    {       
        public string NameProduction { get; set; }
        public Size SizeProduction { get; set; }
        public int CountProduction { get; set; }
        public decimal PriceProduction { get; set; }

        protected Production()
        { }

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
