using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace OOPlaba2
{
   [XmlInclude(typeof(StorageDepartment))]
   [XmlInclude(typeof(ProcessingDepartment))]
   [XmlInclude(typeof(AssemblyDepartment))]
   [Serializable]
    public abstract class Department: IComparable
    {
        public string NameDepartment { get; set; }
        public List<string> PipleList { get; set; }
        public int CountPiples { get; set; }
        public List<Production> Productions { get; set; }
        public int CountNameProductions { get; set; }
        public int Productivity { get; set; }

        protected Department()
        { }

        protected Department(string name, List<string> pipleList, List<Production> productionList)
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
            var d = (Department)obj;
            double t = d.Productivity;
            return Productivity.CompareTo(t);
        }

        public void AddProduction(Production production)
        {
            Productions.Add(production);
        }

        public void RemoveProduction(int index)
        {
            try
            {
                Productions.RemoveAt(index);
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }            
        }

        public void EditProduction(int index, Production production)
        {
            try
            {
                Productions[index] = production;
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }
            
        }

        public void AddPiple(string piple)
        {
            PipleList.Add(piple);
        }

        public void RemovePiple(int index)
        {
            try
            {
                PipleList.RemoveAt(index);
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }
            
        }

        public void EditPiple(int index, string piple)
        {
            try
            {
                PipleList[index] = piple;
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }
            
        }
    }
}
