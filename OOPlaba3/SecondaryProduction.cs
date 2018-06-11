using System;

namespace OOPlaba2
{
    [Serializable]
    public sealed class SecondaryProduction : Production
    {
        public TypeMaterial Material { get; set; }
        private const decimal Koef = 1.5m;

        public SecondaryProduction()
        { }

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