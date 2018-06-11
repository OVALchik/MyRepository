using System;
using System.Xml.Serialization;

namespace OOPlaba2
{
    [XmlInclude(typeof(PrimaryProduction))]
    [XmlInclude(typeof(FinalProduction))]
    [XmlInclude(typeof(SecondaryProduction))]
    [Serializable]
    public abstract class Production
    {       
        public string NameProduction { get; set; }
        public Size SizeProduction { get; set; }
        public int CountProduction { get; set; }
        public decimal PriceProduction { get; set; }

        protected Production()
        { }

        protected Production(string name, Size size, int count, decimal price)
        {
            NameProduction = name;
            SizeProduction = size;
            CountProduction = count;
            PriceProduction = price;
        }

            public abstract void ShowInfoProduction();
    }    
}
