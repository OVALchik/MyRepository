using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace OOPlaba2
{
   [XmlInclude(typeof(StorageDepartmentDTO))]
   [XmlInclude(typeof(ProcessingDepartmentDTO))]
   [XmlInclude(typeof(AssemblyDepartmentDTO))]
   //[Serializable]
    public abstract class DepartmentDTO: DTO,IComparable
    {
        public string NameDepartment { get; set; }
        public List<string> PipleList { get; set; }
        public int CountPiples { get; set; }
        public List<ProductionDTO> Productions { get; set; }
        public int CountNameProductions { get; set; }
        public int Productivity { get; set; }

        protected DepartmentDTO()
        { }

        protected DepartmentDTO(string name, List<string> pipleList, List<ProductionDTO> productionList)
        {
            if (pipleList == null)
                throw new ArgumentException("Список рабочих не должен быть пустым");

            if (productionList == null)
                throw new ArgumentException("Список продукции не должен быть пустым");

            NameDepartment = name;
            PipleList = pipleList;           
            CountPiples = PipleList.Count;
            Productions = productionList;
            CountNameProductions = Productions.Count;
            Productivity = GetProductivity();              
        }

        private int GetProductivity()
        {
            int generalProduction = 0;
            foreach (var production in Productions)
                generalProduction += production.CountProduction;

            return generalProduction / CountPiples;
        }      

        int IComparable.CompareTo(object obj)
        {
            var d = (DepartmentDTO)obj;
            double t = d.Productivity;
            return Productivity.CompareTo(t);
        }

        public void AddProduction(ProductionDTO production)
        {
            Productions.Add(production);
        }

        public void RemoveProduction(int index)
        {
            Productions.RemoveAt(index);
        }

        public void EditProduction(int index, ProductionDTO production)
        {
            Productions[index] = production;
        }

        public void AddPiple(string piple)
        {
            PipleList.Add(piple);
        }

        public void RemovePiple(int index)
        {
            PipleList.RemoveAt(index);
        }

        public void EditPiple(int index, string piple)
        {
            PipleList[index] = piple;
        }
    }
}
