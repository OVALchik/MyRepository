using System.Collections.Generic;
using System.Linq;

namespace OOPlaba2
{
    public sealed class Industry
    {
        public string NameIndusry { get; private set; }
        public List<Department> Departaments { get; private set; }
        public List<string> PipleList { get; private set; }= new List<string>();
        public int CountPiples { get; private set; }
        public List<Production>ProductionList { get; private set; }= new List<Production>();
        public int CountNameProduction { get; private set; }

        public Industry(string name, List<Department> departmentList)
        {        
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
            Departaments.RemoveAt(index);
        }

        public void EditDepartment(int index, Department departaments)
        {
            Departaments[index] = departaments;
        }                 
    }
}
