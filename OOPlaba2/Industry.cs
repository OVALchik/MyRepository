using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private static int GetCountPiples(List<Department> Departaments)
        {
            int count = 0;
            for (int i = 0; i < Departaments.Count; i++)
                count += Departaments[i].CountPiples;

            return count;
        }

        private static int GetCountProduction(List<Department> Departaments)
        {
            int count = 0;
            for (int i = 0; i < Departaments.Count; i++)
                count += Departaments[i].CountNameProductions;

            return count;
        }

        private static void RefreshArrayProduction(List<Production>[] ProductionArray, List<Department> Departaments)
        {
            for (int i = 0; i < Departaments.Count; i++)
            {
                ProductionArray[i] = Departaments[i].Productions;
            }
        }

        private static void RefreshArrayPiple(List<string>[] PipleArray, List<Department> Departaments)
        {
            for (int i = 0; i < Departaments.Count; i++)
            {
                PipleArray[i] = Departaments[i].PipleList;
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
            foreach (List<Production> products in ProductionArray)
            {
                foreach (Production product in products)
                {
                    product.ShowInfoProduction();
                }
            }
            Console.WriteLine($"Всего наименований:{CountNameProduction} человек(а)");
        }

        public void ShowListPiples()
        {
            Console.WriteLine("Список рабочих, занятых в производсте:");
            foreach (List<string> piples in PipleArray)
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
            foreach (Department department in Departaments)
            {
                Console.WriteLine($"{department.NameDepartment} Производительность:{department.Productivity}");
            }
        }
    }
}
