using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    internal class Program
    {
        public static List<RobotMachine> CreateRobotMachine()
        {
            var machineList = new List<RobotMachine>
            {
                new RobotMachine("Станочный резчик по металлу", 10),
                new RobotMachine("Автоматизированный станок резьбы по дереву", 5),
                new RobotMachine("Прессовочный аппарат", 10)
            };
            return machineList;
        }

        public static List<PrimaryProduction> CreatePrimaryProduction()
        {
            var productionList = new List<PrimaryProduction>
            {
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", 50, 70, 5, 3, 1000,
                    250m),
                new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5", 0.5, 0.5, 5, 7, 500, 1500m),
                new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Beam, "Брус W-10", 10, 10, 200, 15, 400, 500m),
                new PrimaryProduction(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5", 0.5, 0.5, 5, 7, 200, 1000m)
            };
            return productionList;
        }

        public static List<string> CreatePipleListForStorageDepartment()
        {
            var pipleList = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            return pipleList;
        }

        public static List<SecondaryProduction> CreateSecondaryProduction()
        {
            var productionList = new List<SecondaryProduction>
            {
                new SecondaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Заготовка-AL5", 50, 50, 12, 5,
                    500, 350m),
                new SecondaryProduction(TypeMaterial.Titanium, TypeProduction.Ingot, "Заготовка-ТТ3", 150, 50, 7, 40,
                    200, 1500m),
                new SecondaryProduction(TypeMaterial.Wood, TypeProduction.Rod, "Заготовка-W11", 50, 50, 100, 45, 1500,
                    450m)
            };
            return productionList;
        }

        public static List<string> CreatePipleListForProcessingDepartment()
        {
            var pipleList =
                new List<string> { "Зимин Е.М.", "Лясова А.А.", "Носов Н.П.", "Зинков В.В.", "Никитина В.З." };
            return pipleList;
        }

        public static List<FinalProduction> CreateFinalProduction()
        {
            var productionList = new List<FinalProduction>
            {
                new FinalProduction("Станок измерительный", 100, 200, 160, 15, 1100, 5000m),
                new FinalProduction("Станок автоматизированный", 200, 50, 50, 17, 2100, 6000m),
                new FinalProduction("Измеритель", 50, 50, 30, 1.2, 1500, 300m)
            };
            return productionList;
        }

        public static List<string> CreatePipleListForAssembluDepartment()
        {
            var pipleList = new List<string>
            {
                "Зимин Е.М.",
                "Лясова А.А.",
                "Носов Н.П.",
                "Зинков В.В.",
                "Никитина В.З.",
                "Зорченко Ю.В.",
                "Захарова Ю.Ф."
            };
            return pipleList;
        }

        public static void ShowInfoDepartment(Industry industry)
        {
            Console.WriteLine("Выбор цеха:");
            for (int i = 0; i < industry.Departaments.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{industry.Departaments[i].NameDepartment}");
            }
            int item = Convert.ToInt32(Console.ReadLine());
            industry.Departaments[item - 1].ShowInfoDepartment();
        }

        public static void AddDepartmentFromIndusty(Industry industry)
        {
            Console.WriteLine("Выбор типа цеха:");
            Console.WriteLine("1.Заготавливающий цех");
            Console.WriteLine("2.Обрабатывающий цех");
            Console.WriteLine("3.Сборочно-монтажный цех");
            int itemDep = Convert.ToInt32(Console.ReadLine());

            var pipleList = new List<string> { "Зощенко Е.Ф.", "Клубина П.Я.", "Носов Н.П." };

            switch (itemDep)
            {
                case 1:
                    {
                        var machineList = new List<RobotMachine>
                       {
                          new RobotMachine("Станочный резчик по дереву", 15),
                          new RobotMachine("Автоматизированный станок резьбы по дереву",10)
                       };

                        var productionList = new List<PrimaryProduction>
                       {
                          new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Plate,"Лист W-4", 50, 70, 5, 3, 10000, 250m),
                          new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Rod,"Прут W-5", 0.5, 0.5, 5, 7, 5000, 150m)
                       };

                        var newSt = new StorageDepartment(machineList, "Заготовительный цех№2", pipleList, new List<Production>(productionList));
                        industry.AddDepartment(newSt);
                    }
                    break;
                case 2:
                    {
                        var productionList = new List<SecondaryProduction>
                        {
                            new SecondaryProduction(TypeMaterial.Iron, TypeProduction.Rod,"Заготовка-I5", 50, 50, 12, 5, 5000, 350m),
                            new SecondaryProduction(TypeMaterial.Iron, TypeProduction.Plate,"Заготовка-I3", 150, 50, 7, 40, 2000, 1500m)
                        };

                        var newPd = new ProcessingDepartment("Обрабатывающий цех№2", pipleList, new List<Production>(productionList));
                        industry.AddDepartment(newPd);
                    }
                    break;
                case 3:
                    {
                        var productionList = new List<FinalProduction>
                        {
                            new FinalProduction("Станок A09", 100, 200, 160, 15, 100, 5000m),
                            new FinalProduction("Станок автоматизированный B-8", 200, 50, 50, 17, 100, 6000m),
                            new FinalProduction("Измеритель ЭТМ", 50, 50, 30, 1.2, 100, 300m)
                        };

                        var newAd = new AssemblyDepartment("Сборочно-монтажный цех№2", pipleList, new List<Production>(productionList));
                        industry.AddDepartment(newAd);
                    }
                    break;
                default:
                    Console.WriteLine("Введено неверное значение");
                    break;
            }
        }

        public static void RemoveDepartmentFromIndustry(Industry industry)
        {
            Console.WriteLine("Выбор цеха:");
            for (int i = 0; i < industry.Departaments.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{industry.Departaments[i].NameDepartment}");
            }
            var itemDep = Convert.ToInt32(Console.ReadLine());
            industry.RemoveDepartment(itemDep - 1);
        }

        public static void EditDepartmentFromIndustry(Industry industry)
        {
            Console.WriteLine("Выбор пункта:");
            Console.WriteLine("1.Изменить продукцию цеха");
            Console.WriteLine("2.Изменить бригаду цеха");
            Console.WriteLine("3.Переспециализировать цех (полные изменения)");
            int item = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выбор цеха:");
            for (int i = 0; i < industry.Departaments.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{industry.Departaments[i].NameDepartment}");
            }

            int itemDep = Convert.ToInt32(Console.ReadLine());

            switch (item)
            {
                case 1:
                    {
                        if (industry.Departaments[itemDep - 1] is StorageDepartment)
                        {
                            industry.Departaments[itemDep - 1].RemoveProduction(0);
                        }
                        if (industry.Departaments[itemDep - 1] is ProcessingDepartment)
                        {
                            industry.Departaments[itemDep - 1].RemoveProduction(0);
                        }
                        if (industry.Departaments[itemDep - 1] is AssemblyDepartment)
                        {
                            industry.Departaments[itemDep - 1].AddProduction(new FinalProduction("Станок автоматизированный PT-8", 200, 50, 50, 17, 100, 6000m));
                        }
                    }
                    break;
                case 2:
                    {
                        industry.Departaments[itemDep - 1].RemovePiple(1);
                        industry.Departaments[itemDep - 1].AddPiple("Зощин Е.Ф.");
                        industry.Departaments[itemDep - 1].AddPiple("Кубина П.Я.");
                    }
                    break;
                case 3:
                    {
                        var pipleList = new List<string> { "Зощин Е.Ф.", "Кубина П.Я." };
                        var productionList = new List<FinalProduction>
                        {
                            new FinalProduction("Станок автоматизированный B-8", 200, 50, 50, 17, 100, 6000m),
                            new FinalProduction("Измеритель ЭТМ", 50, 50, 30, 1.2, 100, 300m)
                    };
                        var newAd = new AssemblyDepartment("Сборочно-монтажный цех№3", pipleList, new List<Production>(productionList));

                        industry.EditDepartment((item - 1), newAd);
                    }
                    break;
                default:
                    Console.WriteLine("Введено неверное значение");
                    break;
            }
        }

        public static void ChangeDepartment(Industry industry)
        {
            Console.WriteLine("Выбор пункта:");
            Console.WriteLine("1.Добавить цех");
            Console.WriteLine("2.Удалить цех");
            Console.WriteLine("3.Изменить цех");
            int item = Convert.ToInt32(Console.ReadLine());

            switch (item)
            {
                case 1:
                    AddDepartmentFromIndusty(industry);
                    break;
                case 2:
                    RemoveDepartmentFromIndustry(industry);
                    break;
                case 3:
                    EditDepartmentFromIndustry(industry);
                    break;
                default:
                    Console.WriteLine("Введено неверное значение");
                    break;
            }
        }

        public static void ShowClassWork(Industry industry)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выбор пункта:");
                Console.WriteLine("1.Просмотр информации о цехе");
                Console.WriteLine("2.Добавить, удалить, изменить цех");
                Console.WriteLine("3.Просмотр информации о производстве");
                Console.WriteLine("4.Просмотр полного списка продукции производства");
                Console.WriteLine("5.Просмотр полного списка рабочих производства");
                Console.WriteLine("6.Просмотр информации производительности по цехам");
                Console.WriteLine("7.Выход");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ShowInfoDepartment(industry);
                        break;
                    case 2:
                        ChangeDepartment(industry);
                        break;
                    case 3:
                        industry.ShowInfoIndustry();
                        break;
                    case 4:
                        industry.ShowListProduction();
                        break;
                    case 5:
                        industry.ShowListPiples();
                        break;
                    case 6:
                        industry.ShowInfoProductivity();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Введено неверное значение");
                        break;
                }
            }
        }

        private static void Main()
        {
            var st = new StorageDepartment(CreateRobotMachine(), "Заготовительный цех№1", CreatePipleListForStorageDepartment(), new List<Production>(CreatePrimaryProduction()));
            var pd = new ProcessingDepartment("Обрабатывающий цех№1", CreatePipleListForProcessingDepartment(), new List<Production>(CreateSecondaryProduction()));
            var ad = new AssemblyDepartment("Сборочно-монтажный цех№1", CreatePipleListForAssembluDepartment(), new List<Production>(CreateFinalProduction()));

            var department = new List<Department> { st, pd, ad };

            var industry = new Industry("Инастриз", department);
            ShowClassWork(industry);

        }
    }
}
