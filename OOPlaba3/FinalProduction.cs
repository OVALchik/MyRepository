using System;
using System.Collections.Generic;

namespace OOPlaba2
{
   // [Serializable]
    public sealed class FinalProductionDTO : ProductionDTO
    {
        public List<SecondaryProductionDTO> SecondaryProductionList { get; set; }

        public FinalProductionDTO()
        { }

        public FinalProductionDTO(string name, Size size, int count, List<SecondaryProductionDTO> list)
            : base(name, size, count, GetPrice(list))
        {
            SecondaryProductionList = list;
        }

        public static decimal GetPrice(List<SecondaryProductionDTO> secondaryProductionList)
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