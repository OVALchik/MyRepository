﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace OOPlaba2
{
    [XmlInclude(typeof(StorageDepartment))]
    [XmlInclude(typeof(ProcessingDepartment))]
    [XmlInclude(typeof(AssemblyDepartment))]
    [Serializable]
    public abstract class Department:IComparable
    {
        public string NameDepartment { get; set; }
        public List<string> PipleList { get; set; }
        public int CountPiples { get; set; }
        public List<Production> Productions { get; set; }
        public int CountNameProductions { get; set; }
        public double Productivity { get; set; }

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

        public virtual void ShowInfoDepartment()
        {
            Console.WriteLine($"Название цеха:{NameDepartment}");

            Console.WriteLine("Список рабочих:");
            for (int i = 0; i < PipleList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{PipleList[i]}");
            }
            Console.WriteLine($"Общее число рабочих:{CountPiples}");

            Console.WriteLine("Список продукции:");
            for (int i = 0; i < Productions.Count; i++)
            {
                Console.Write($"{i + 1}.");
                Productions[i].ShowInfoProduction();
            }
            Console.WriteLine($"Число наименований продукции:{CountNameProductions}");

            Console.WriteLine($"Производительность цеха:{Productivity}");
            Console.WriteLine("________________________________________");
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }           
        }

        public void EditProduction(int index, Production production)
        {
            try
            {
                Productions[index] = production;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void EditPiple(int index, string piple)
        {
            try
            {
                PipleList[index] = piple;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
