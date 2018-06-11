using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPlaba2
{
    [Serializable]
    public  class Industry
    {      
        public string NameIndusry { get; set; }
        public List<Department> Departaments { get; set; }
        public List<string> PipleList { get; set; } = new List<string>();
        public int CountPiples { get; set; }
        public List<Production> ProductionList { get; set; } = new List<Production>();
        public int CountNameProduction { get; set; }

        public Industry()
        { }

        public Industry(string name, List<Department> departmentList)
        {
            if(departmentList == null)
                throw new ArgumentException("На производстве должен быть хотя бы один цех");

            NameIndusry = name;
            Departaments = departmentList;
            CountPiples = GetCountPiples(Departaments);
            CountNameProduction = GetCountProduction(Departaments);

            UnionArrayProduction(ProductionList, Departaments);
            UnionArrayPiple(PipleList, Departaments);
        }      

        private static int GetCountPiples(IEnumerable<Department> departaments)
        {
            return departaments.Sum(t => t.CountPiples);
        }

        private static int GetCountProduction(IEnumerable<Department> departaments)
        {
            return departaments.Sum(t => t.CountNameProductions);
        }

        private static void UnionArrayProduction(List<Production> productionList, IReadOnlyList<Department> departments)
        {
            foreach (var department in departments)
            {
                productionList.AddRange(department.Productions);
            }
        }

        private static void UnionArrayPiple(List<string> pipleList, IReadOnlyList<Department> departments)
        {
            foreach (var department in departments)
            {
                pipleList.AddRange(department.PipleList);
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
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }
        }

        public void EditDepartment(int index, Department departaments)
        {
            try
            {
                Departaments[index] = departaments;
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }
            
        }
        
    }
}
