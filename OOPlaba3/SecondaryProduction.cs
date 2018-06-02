using System;

namespace OOPlaba2
{
    [Serializable]
    public sealed class SecondaryProduction : PrimaryProduction
    {
        public SecondaryProduction()
        { }

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
