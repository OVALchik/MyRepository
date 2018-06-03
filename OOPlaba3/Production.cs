using System;
using System.Xml.Serialization;

namespace OOPlaba2
{
    [XmlInclude(typeof(PrimaryProductionDTO))]
    [XmlInclude(typeof(FinalProductionDTO))]
    [XmlInclude(typeof(SecondaryProductionDTO))]
    //[Serializable]
    public abstract class ProductionDTO: DTO
    {       
        public string NameProduction { get; set; }
        public Size SizeProduction { get; set; }
        public int CountProduction { get; set; }
        public decimal PriceProduction { get; set; }

        protected ProductionDTO()
        { }

        protected ProductionDTO(string name, Size size, int count, decimal price)
        {
            NameProduction = name;
            SizeProduction = size;
            CountProduction = count;
            PriceProduction = price;
        }

            public abstract void ShowInfoProduction();
    }    
}
