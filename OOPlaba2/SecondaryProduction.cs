using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlaba2
{
    public sealed class SecondaryProduction : PrimaryProduction
    {
        public SecondaryProduction(TypeMaterial typeMaterial, TypeProduction typeProduction, string name, double length, double width, double hight, double weight, int count, decimal price)
            : base(typeMaterial, typeProduction,name, length, width, hight, weight, count, price)
        {
          
        }

        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction} Типа материала:{Material}");
            Console.WriteLine($"Габариты:{SizeProduction.Length}x{SizeProduction.Width}x{SizeProduction.Hight}(m) Вес:{SizeProduction.Weigth}(kg)");
            Console.WriteLine($"Кол-во:{CountProduction} Цена за ед.:{PriceProduction}");
        }
    }
}
