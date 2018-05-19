using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlaba2
{
    public class SecondaryProduction : Production
    {
        public enum TypeMaterial
        {
            Aluminum,
            Iron,
            Steel,
            Titanium,
            Wood
        }

        public TypeMaterial Material { get; set; }

        public SecondaryProduction(TypeMaterial type, string name, double length, double width, double hight, double weight, int count, decimal price)
            : base(name, length, width, hight, weight, count, price)
        {
            Material = type;
        }

        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction} Типа материала:{Material}");
            Console.WriteLine($"Габариты:{SizeProduction.Length}x{SizeProduction.Width}x{SizeProduction.Hight}(m) Вес:{SizeProduction.Weigth}(kg)");
            Console.WriteLine($"Кол-во:{CountProduction} Цена за ед.:{PriceProduction}");
        }
    }
}
