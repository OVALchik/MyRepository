using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPlaba2
{
    [Serializable]
    public sealed class Industry
    {
        public string NameIndusry { get; set; }
        public List<Department> Departaments { get; set; }
        public List<string>[] PipleArray { get; set; }
        public int CountPiples { get; set; }
        public List<Production>[] ProductionArray { get; set; }
        public int CountNameProduction { get; set; }

        public Industry()
        { }

        public Industry(string name, List<Department> departmentList)
        {
            if(departmentList==null)
                throw new ArgumentException("На производстве должен быть хотя бы один цех");
            
            NameIndusry = name;
            Departaments = departmentList;
            CountPiples = GetCountPiples(Departaments);
            CountNameProduction = GetCountProduction(Departaments);
            ProductionArray = new List<Production>[Departaments.Count];
            PipleArray = new List<string>[Departaments.Count];

            UnionArrayProduction(ProductionArray, Departaments);
            UnionArrayPiple(PipleArray, Departaments);
        }

        private static int GetCountPiples(IEnumerable<Department> departaments)
        {
            return departaments.Sum(t => t.CountPiples);
        }

        private static int GetCountProduction(IEnumerable<Department> departaments)
        {
            return departaments.Sum(t => t.CountNameProductions);
        }

        private static void UnionArrayProduction(IList<List<Production>> productionArray, IReadOnlyList<Department> departaments)
        {
            for (int i = 0; i < departaments.Count; i++)
            {
                productionArray[i] = departaments[i].Productions;
            }
        }

        private static void UnionArrayPiple(IList<List<string>> pipleArray, IReadOnlyList<Department> departaments)
        {
            for (int i = 0; i < departaments.Count; i++)
            {
                pipleArray[i] = departaments[i].PipleList;
            }
        }

        public void AddDepartment(Department departaments)
        {
            Departaments.Add(departaments);
        }

        public void RemoveDepartment(int index)
        {
            try
            {
                Departaments.RemoveAt(index);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void EditDepartment(int index, Department departaments)
        {
            try
            {
                Departaments[index] = departaments;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
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
            Console.WriteLine($"Всего наименований:{CountNameProduction}");
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
