using System;

namespace OOPlaba2
{
    public sealed class FinalProduction : Production
    {
        public FinalProduction(string name, double length, double width, double hight, double weight, int count, decimal price)
            : base(name, length, width, hight, weight, count, price)
        {

        }

        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction}");
            Console.WriteLine($"Габариты:{SizeProduction.Length}x{SizeProduction.Width}x{SizeProduction.Hight}(m) Вес:{SizeProduction.Weigth}(kg)");
            Console.WriteLine($"Кол-во:{CountProduction} Цена за ед.:{PriceProduction}");
        }

    }
}
