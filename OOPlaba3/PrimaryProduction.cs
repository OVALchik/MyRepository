﻿using System;

namespace OOPlaba2
{
    [Serializable]
    public class PrimaryProduction : Production
    {
        public TypeMaterial Material { get; set; }
        public TypeProduction Type { get; set; }

        public PrimaryProduction()
        { }

        public PrimaryProduction(TypeMaterial typeMaterial, TypeProduction typeProduction, string name, Size size, int count, decimal price)
            : base(name, size, count, price)
        {
            Material = typeMaterial;
            Type = typeProduction;
        }

        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction} Тип:{Type} Тип материала:{Material}");
            SizeProduction.ShowSize();
            Console.WriteLine($"Кол-во:{CountProduction} Цена за ед.:{PriceProduction}");
        }
    }

}

