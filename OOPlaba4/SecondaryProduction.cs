using System;

namespace OOPlaba2
{
    [Serializable]
    public sealed class SecondaryProduction : Production
    {
        public TypeMaterial Material { get; set; }     

        public SecondaryProduction()
        { }

        public SecondaryProduction(string name, Size size, TypeMaterial type, int count)
            : base(name, size, count)
        {
            Material = type;
        }

        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction} Типа материала:{Material}");
            SizeProduction.ShowSize();
            Console.WriteLine($"Кол-во:{CountProduction}");
        }
    }
}