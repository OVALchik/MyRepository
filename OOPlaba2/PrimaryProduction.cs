﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlaba2
{
    public class PrimaryProduction : Production
    {
        public enum TypeMaterial
        {
            Aluminum,
            Iron,
            Steel,
            Titanium,
            Wood
        }

        public enum TypeProduction
        {
            Plate, //Пластина, лист
            Ingot, //Слиток, болванка
            Rod, //Прут
            Beam //Брус, балка
        }

        public TypeMaterial Material { get; private set; }
        public TypeProduction Type { get; private set; }

        public PrimaryProduction(TypeMaterial typeMaterial, TypeProduction typeProduction, string name, double length, double width, double hight, double weight, int count, decimal price)
            : base(name, length, width, hight, weight, count, price)
        {
            Material = typeMaterial;
            Type = typeProduction;
        }

        public override void ShowInfoProduction()
        {
            Console.WriteLine($"Наименование:{NameProduction} Тип:{Type} Тип материала:{Material}");
            Console.WriteLine($"Габариты:{SizeProduction.Length}x{SizeProduction.Width}x{SizeProduction.Hight}(m) Вес:{SizeProduction.Weigth}(kg)");
            Console.WriteLine($"Кол-во:{CountProduction} Цена за ед.:{PriceProduction}");
        }
    }

}
