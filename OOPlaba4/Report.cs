using System;

namespace OOPlaba2
{
    class Report
    {
        public void ShowInfoIndustry(object obj)
        {
            Industry industry = (Industry)obj;
            Console.WriteLine($"Название производства:{industry.NameIndusry}");
            Console.WriteLine($"Кол-во цехов:{industry.Departaments.Count}");
            Console.WriteLine($"Подробная информация по цехам:");
            for (int i = 0; i < industry.Departaments.Count; i++)
            {
                Console.Write($"{i + 1}.");
                Object objectDepartment = industry.Departaments[i];
                ShowInfoDepartment(objectDepartment);
            }
            Console.WriteLine($"Информация об оборудовании");
            ShowInfoMachine(industry);
        }

        public void ShowInfoProductivity(object obj)
        {
            Industry industry = (Industry)obj;
            industry.Departaments.Sort();
            foreach (var department in industry.Departaments)
            {
                Console.WriteLine($"{department.NameDepartment} Производительность:{department.Productivity}");
            }
        }

        public void ShowInfoDepartment(object obj)
        {
            Department department = (Department)obj;
            Console.WriteLine($"Название цеха:{department.NameDepartment}");

            Console.WriteLine("Список рабочих:");
            for (int i = 0; i < department.PipleList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{department.PipleList[i]}");
            }

            Console.WriteLine($"Общее число рабочих:{department.CountPiples}");

            Console.WriteLine("Список продукции:");
            for (int i = 0; i < department.Productions.Count; i++)
            {
                Console.Write($"{i + 1}.");
                department.Productions[i].ShowInfoProduction();
            }

            Console.WriteLine($"Число наименований продукции:{department.CountNameProductions}");

            Console.WriteLine($"Производительность цеха:{department.Productivity}");
            Console.WriteLine("________________________________________");
        }

        public void ShowInfoMachine(object obj)
        {
            Industry industry = (Industry)obj;
            for (int i = 0; i < industry.Departaments.Count; i++)
            {
                if (industry.Departaments[i] is StorageDepartment)
                {
                    StorageDepartment temp = (StorageDepartment)industry.Departaments[i];
                    foreach (var machine in temp.MachineList)
                    {
                        Console.WriteLine($"Наименование:{machine.NameMachine} Кол-во ед. техники:{machine.CountMachine}");
                    }
                    int count = 0;
                    foreach (var machine in temp.MachineList)
                        count += machine.CountMachine;

                    Console.WriteLine($"Общее число ед. техники:{count}");
                    Console.WriteLine($"Техника закреплена за цехом:{temp.NameDepartment}");
                }
            }

        }
    }
}
