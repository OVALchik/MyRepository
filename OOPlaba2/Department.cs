using System;
using System.Collections.Generic;


namespace OOPlaba2
{
    public abstract class Department:IComparable
    {
        public string NameDepartment { get; private set; }
        public List<string> PipleList { get; private set; }
        public int CountPiples { get; private set; }
        public List<Production> Productions { get; private set; }
        public int CountNameProductions { get; private set; }
        public double Productivity { get; private set; }

        protected Department(string name, List<string> pipleList, List<Production> productionList)
        {
            NameDepartment = name;
            PipleList = pipleList;
            CountPiples = PipleList.Count;
            Productions = productionList;
            CountNameProductions = Productions.Count;
            Productivity = GetProductivity();
        }

        private double GetProductivity()
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
            Productions.RemoveAt(index);
        }

        public void EditProduction(int index, Production production)
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
