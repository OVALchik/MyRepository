using System;
using System.Xml.Serialization;

namespace OOPlaba2
{
    [XmlInclude(typeof(SecondaryProduction))]
    [Serializable]
    public class PrimaryProduction : Production
    {
        public TypeMaterial Material { get; set; }
        public TypeProduction Type { get; set; }

        public PrimaryProduction()
        { }

        public PrimaryProduction(TypeMaterial typeMaterial, TypeProduction typeProduction, string name, double length, double width, double hight, double weight, int count, decimal price)
            : base(name, length, width, hight, weight, count, price)
        {
            Material = typeMaterial;
            Type = typeProduction;
        }

        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction} Тип:{Type} Тип материала:{Material}");
            Console.WriteLine($"Габариты:{SizeProduction.Length}x{SizeProduction.Width}x{SizeProduction.Hight}(m) Вес:{SizeProduction.Weigth}(kg)");
            Console.WriteLine($"Кол-во:{CountProduction} Цена за ед.:{PriceProduction}");
        }
    }

}
