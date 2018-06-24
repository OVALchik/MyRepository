using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    [Serializable]
    public sealed class FinalProduction : Production
    {
        public List<SecondaryProduction> SecondaryProductionList { get; set; }

        public FinalProduction()
        { }

        public FinalProduction(string name, Size size, int count)
            : base(name, size, count)
        {
            
        }

       
        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction}");
            SizeProduction.ShowSize();
            Console.WriteLine($"Кол-во:{CountProduction}");
            Console.WriteLine("Список сырья для изготовления:");
            foreach (var production in SecondaryProductionList)
            {
                production.ShowInfoProduction();
            }
        }

    }
}