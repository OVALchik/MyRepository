using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPlaba2
{
    public sealed class Industry
    {
        public string NameIndusry { get; private set; }
        public List<Department> Departaments { get; private set; }
        public List<string>[] PipleArray { get; private set; }
        public int CountPiples { get; private set; }
        public List<Production>[] ProductionArray { get; private set; }
        public int CountNameProduction { get; private set; }

        public Industry(string name, List<Department> departmentList)
        {
            NameIndusry = name;
            Departaments = departmentList;
            CountPiples = GetCountPiples(Departaments);
            CountNameProduction = GetCountProduction(Departaments);
            ProductionArray = new List<Production>[Departaments.Count];
            PipleArray = new List<string>[Departaments.Count];

            RefreshArrayProduction(ProductionArray, Departaments);
            RefreshArrayPiple(PipleArray, Departaments);
        }

        private static int GetCountPiples(IEnumerable<Department> departaments)
        {
            return departaments.Sum(t => t.CountPiples);
        }

        private static int GetCountProduction(IEnumerable<Department> departaments)
        {
            return departaments.Sum(t => t.CountNameProductions);
        }

        private static void RefreshArrayProduction(IList<List<Production>> productionArray, IReadOnlyList<Department> departaments)
        {
            for (int i = 0; i < departaments.Count; i++)
            {
                productionArray[i] = departaments[i].Productions;
            }
        }

        private static void RefreshArrayPiple(IList<List<string>> pipleArray, IReadOnlyList<Department> departaments)
        {
            for (int i = 0; i < departaments.Count; i++)
            {
                pipleArray[i] = departaments[i].PipleList;
            }
        }

        public void AddDepartment(Department departaments)
        {
            Departaments.Add(departaments);
            RefreshArrayProduction(ProductionArray, Departaments);
            RefreshArrayPiple(PipleArray, Departaments);
        }

        public void RemoveDepartment(int index)
        {
            Departaments.RemoveAt(index);
            RefreshArrayProduction(ProductionArray, Departaments);
            RefreshArrayPiple(PipleArray, Departaments);
        }

        public void EditDepartment(int index, Department departaments)
        {
            Departaments[index] = departaments;
        }

        public void ShowListProduction()
        {
            Console.WriteLine("Лист продукции:");
            foreach (var products in ProductionArray)
            {
                foreach (var product in products)
                {
                    product.ShowInfoProduction();
                }
            }
            Console.WriteLine($"Всего наименований:{CountNameProduction} человек(а)");
        }

        public void ShowListPiples()
        {
            Console.WriteLine("Список рабочих, занятых в производсте:");
            foreach (var piples in PipleArray)
            {
                foreach (string piple in piples)
                {
                    Console.WriteLine($"{piple}");
                }
            }
            Console.WriteLine($"Всего:{CountPiples} человек(а)");
        }

        public void ShowInfoIndustry()
        {
            Console.WriteLine($"Название производства:{NameIndusry}");
            Console.WriteLine($"Кол-во рабочих:{CountPiples} Кол-во наименований продукции:{CountNameProduction}");
            Console.WriteLine($"Кол-во цехов:{Departaments.Count}");
            Console.WriteLine($"Подробная информация по цехам:");
            for (int i = 0; i < Departaments.Count; i++)
            {
                Console.Write($"{i + 1}.");
                Departaments[i].ShowInfoDepartment();
            }
        }

        public void ShowInfoProductivity()
        {
            Departaments.Sort();
            foreach (var department in Departaments)
            {
                Console.WriteLine($"{department.NameDepartment} Производительность:{department.Productivity}");
            }
        }
    }
}
