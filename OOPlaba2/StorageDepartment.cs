using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlaba2
{
    public sealed class StorageDepartment : Department
    {
        public struct RobotMachine
        {
            public string NameMachine { get; private set; }
            public int CountMachine { get; private set; }

            public RobotMachine(string nameMachine, int count)
            {
                NameMachine = nameMachine;
                CountMachine = count;
            }
        }

        public List<RobotMachine> MachineList { get; private set; } = new List<RobotMachine>();

        public StorageDepartment(List<RobotMachine> machinelList, string name, List<string> pipleList, List<Production> productionList)
            : base(name, pipleList, productionList)
        {
            MachineList = machinelList;
        }

        public void ShowInfoMachine()
        {
            foreach (RobotMachine machine in MachineList)
            {
                Console.WriteLine($"Наименование:{machine.NameMachine} Кол-во ед. техники:{machine.CountMachine}");
            }
            int count = 0;
            for (int i = 0; i < MachineList.Count; i++)
                count += MachineList[i].CountMachine;
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
