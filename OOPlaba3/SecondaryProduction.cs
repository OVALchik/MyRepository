using System;

namespace OOPlaba2
{
    //[Serializable]
    public sealed class SecondaryProductionDTO : ProductionDTO
    {
        public TypeMaterial Material { get; set; }
        private const decimal Koef = 1.5m;

        public SecondaryProductionDTO()
        { }

        public SecondaryProductionDTO(string name, Size size, PrimaryProductionDTO production)
            : base(name, size, production.CountProduction, production.PriceProduction * Koef)
        {
            Material = production.Material;
        }

        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction} Типа материала:{Material}");
            SizeProduction.ShowSize();
            Console.WriteLine($"Кол-во:{CountProduction} Цена за ед.:{PriceProduction}");
        }
    }
}