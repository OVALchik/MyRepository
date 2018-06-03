using System;

namespace OOPlaba2
{
    public sealed class SecondaryProduction : Production
    {
        public TypeMaterial Material { get; private set; }
        private const decimal Koef = 1.5m;

        public SecondaryProduction(string name, Size size, PrimaryProduction production)
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
