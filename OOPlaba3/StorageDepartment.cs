﻿using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    public sealed class StorageDepartment : Department
    {      
        public List<RobotMachine> MachineList { get; private set; }
        
        public StorageDepartment(List<RobotMachine> machinelList, string name, List<string> pipleList, List<Production> productionList)
            : base(name, pipleList, productionList)
        {
            if(machinelList==null)
                throw  new ArgumentException("Список авт. систем не должен быть пустым");

            if(pipleList == null)
                throw new ArgumentException("Список рабочих не должен быть пустым");

            if (productionList == null)
                throw new ArgumentException("Список продукции не должен быть пустым");

            MachineList = machinelList;
        }

        public void ShowInfoMachine()
        {
            foreach (var machine in MachineList)
            {
                Console.WriteLine($"Наименование:{machine.NameMachine} Кол-во ед. техники:{machine.CountMachine}");
            }
            int count = 0;
            foreach (var machine in MachineList)
                count += machine.CountMachine;

            Console.WriteLine($"Общее число ед. техники:{count}");
        }

        public override void ShowInfoDepartment()
        {
            Console.WriteLine($"Название цеха:{NameDepartment}");

            Console.WriteLine("Список рабочих:");
            for (int i = 0; i < PipleList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{PipleList[i]}");
            }
            Console.WriteLine($"Общее число рабочих:{CountPiples}");

            Console.WriteLine($"Список автоматизированных систем:");
            ShowInfoMachine();

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
    }
}
