using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    public sealed class FinalProduction : Production
    {
        public List<SecondaryProduction> SecondaryProductionList { get; private set; }

        public FinalProduction(string name, Size size, int count, List<SecondaryProduction>list)
            : base(name, size, count, GetPrice(list))
        {
            SecondaryProductionList = list;          
        }

        public static decimal GetPrice(List<SecondaryProduction> secondaryProductionList)
        {
            const decimal koef = 1.5m;
            decimal sumPrice = 0m;
            foreach (var production in secondaryProductionList)
                sumPrice += production.PriceProduction;

            sumPrice *= koef;
            return sumPrice;
        }

        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction}");
            SizeProduction.ShowSize();
            Console.WriteLine($"Кол-во:{CountProduction} Цена за ед.:{PriceProduction}");
            Console.WriteLine("Список сырья для изготовления:");
            foreach (var production in SecondaryProductionList)
            {
                production.ShowInfoProduction();
            }
        }

    }
}
