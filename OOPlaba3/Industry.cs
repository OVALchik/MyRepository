using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace OOPlaba2
{
    public sealed class IndustryDTO: DTO
    {
        private string _nameIndustry;

        [XmlElement()]
        public string NameIndusry
        {
            get { return _nameIndustry;}
            set { _nameIndustry = value;}
        }

        public List<DepartmentDTO> Departaments { get; set; }
        public List<string> PipleList { get; set; } = new List<string>();
        public int CountPiples { get; set; }
        public List<ProductionDTO> ProductionList { get; set; } = new List<ProductionDTO>();
        public int CountNameProduction { get; set; }

        public IndustryDTO()
        { }

        public IndustryDTO(string name, List<DepartmentDTO> departmentList)
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

        private static int GetCountPiples(IEnumerable<DepartmentDTO> departaments)
        {
            return departaments.Sum(t => t.CountPiples);
        }

        private static int GetCountProduction(IEnumerable<DepartmentDTO> departaments)
        {
            return departaments.Sum(t => t.CountNameProductions);
        }

        private static void UnionArrayProduction(List<ProductionDTO> productionList, IReadOnlyList<DepartmentDTO> departments)
        {
            foreach (var department in departments)
            {
                productionList.AddRange(department.Productions);
            }
        }

        private static void UnionArrayPiple(List<string> pipleList, IReadOnlyList<DepartmentDTO> departments)
        {
            foreach (var department in departments)
            {
                pipleList.AddRange(department.PipleList);
            }
        }

        public void AddDepartment(DepartmentDTO departaments)
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

        public void EditDepartment(int index, DepartmentDTO departaments)
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
        
    }
}
