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
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                    250m),
                new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500, 1500m),
                new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Beam, "Брус W-10", new Size(10, 10, 200, 15), 400, 500m),
                new PrimaryProduction(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200, 1000m)
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
                new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                    new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                    250m)),
                new SecondaryProduction("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                    new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                        1500m)),
                new SecondaryProduction("Заготовка-W11", new Size(100, 50,50, 45),
                    new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Beam, "Брус W-10", new Size(10, 10, 200, 15), 400,
                        500m)),
                new SecondaryProduction("Заготовка-I95", new Size(10, 2, 2, 10),
                    new PrimaryProduction(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200,
                        1000m))
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
                new FinalProduction("Станок измерительный",new Size( 100, 200, 160, 15), 1100, 
                    new List<SecondaryProduction>
                    {
                        new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                            new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                250m)),
                        new SecondaryProduction("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                            new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                1500m))
                        }),
                new FinalProduction("Станок автоматизированный", new Size(200, 50, 50, 17), 2100,
                    new List<SecondaryProduction>
                    {
                        new SecondaryProduction("Заготовка-W11", new Size(100, 50,50, 45),
                            new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Beam, "Брус W-10", new Size(10, 10, 200, 15), 400,
                                500m)),
                        new SecondaryProduction("Заготовка-I95", new Size(10, 2, 2, 10),
                            new PrimaryProduction(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200,
                                1000m))
                    }),
                new FinalProduction("Измеритель", new Size(50, 50, 30, 1.2), 1500,
                    new List<SecondaryProduction>
                    {
                        new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                            new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                250m)),
                        new SecondaryProduction("Заготовка-I95", new Size(10, 2, 2, 10),
                            new PrimaryProduction(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200,
                                1000m))
                    })
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
                          new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Plate,"Лист W-4",new Size( 50, 70, 5, 3), 10000, 250m),
                          new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Rod,"Прут W-5",new Size( 0.5, 0.5, 5, 7), 5000, 150m)
                       };

                        var newSt = new StorageDepartment(machineList, "Заготовительный цех№2", pipleList, new List<Production>(productionList));
                        industry.AddDepartment(newSt);
                    }
                    break;
                case 2:
                    {
                        var productionList = new List<SecondaryProduction>
                        {
                            new SecondaryProduction("Заготовка-I5",new Size( 50, 50, 12, 5),
                                new PrimaryProduction(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200, 1000m)),
                            new SecondaryProduction("Заготовка-P3",new Size( 150, 50, 7, 40),
                                new PrimaryProduction(TypeMaterial.Iron, TypeProduction.Plate, "Лист IR-3",new Size( 5, 5, 1, 9), 250, 1500m))
                        };

                        var newPd = new ProcessingDepartment("Обрабатывающий цех№2", pipleList, new List<Production>(productionList));
                        industry.AddDepartment(newPd);
                    }
                    break;
                case 3:
                    {
                        var productionList = new List<FinalProduction>
                        {
                            new FinalProduction("Станок A09", new Size(100, 200, 160, 15), 100,
                                new List<SecondaryProduction>
                                {
                                    new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProduction("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                            1500m))
                                }),
                            new FinalProduction("Станок автоматизированный B-8", new Size(200, 50, 50, 17), 100,
                                new List<SecondaryProduction>
                                {
                                    new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProduction("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                            1500m))
                                }),
                            new FinalProduction("Измеритель ЭТМ", new Size(50, 50, 30, 1.2), 100,
                                new List<SecondaryProduction>
                                {
                                    new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m))                                    
                                }),
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
                            industry.Departaments[itemDep - 1].AddProduction(new FinalProduction("Станок автоматизированный PT-8", new Size(200, 50, 50, 17), 100,
                                new List<SecondaryProduction>
                                {
                                    new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProduction("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                            1500m))
                                }));
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
                            new FinalProduction("Станок автоматизированный B-8",new Size( 200, 50, 50, 17), 100,
                                new List<SecondaryProduction>
                                {
                                    new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProduction("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                            1500m))
                                }),
                            new FinalProduction("Измеритель ЭТМ", new Size(50, 50, 30, 1.2), 100,  
                                new List<SecondaryProduction>
                                {
                                    new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProduction("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                            1500m))
                                })

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

        public static void ShowInfoReport(Industry industry)
        {
            Report report = new Report();
            object objectIndustry = industry;
            ShowInfo showInfo;

            Console.WriteLine("Выбор пункта:");
            Console.WriteLine("1.Просмотр полной информации производства");
            Console.WriteLine("2.Просмотр полного листа продукции");
            Console.WriteLine("3.Просмотр полного списка рабочих");
            Console.WriteLine("4.Просмотр информации о цехе");                                   
            Console.WriteLine("5.Просмотр информации производительности по цехам");
            Console.WriteLine("6.Просмотр информации об автоматизированных систеиах");

            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:                  
                    showInfo = report.ShowInfoIndustry;
                    showInfo(objectIndustry);
                    break;
                case 2:
                    showInfo = report.ShowListProduction;
                    showInfo(objectIndustry);
                    break;
                case 3:
                    showInfo = report.ShowListPiples;
                    showInfo(objectIndustry);
                    break;
                case 4:
                    Console.WriteLine("Выбор цеха:");
                    for (int i = 0; i < industry.Departaments.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{industry.Departaments[i].NameDepartment}");
                    }
                    int item = Convert.ToInt32(Console.ReadLine());

                    object objectDepartment = industry.Departaments[item - 1];                   
                    showInfo = report.ShowInfoDepartment;
                    showInfo(objectDepartment);
                    break;
                case 5:
                    showInfo = report.ShowInfoProductivity;
                    showInfo(objectIndustry);
                    break;
                case 6:
                    showInfo = report.ShowInfoMachine;
                    showInfo(objectIndustry);
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
                Console.WriteLine("1.Просмотр информации");
                Console.WriteLine("2.Добавить, удалить, изменить цех");                
                Console.WriteLine("3.Выход");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ShowInfoReport(industry);
                        break;
                    case 2:
                        ChangeDepartment(industry);
                        break;                   
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Введено неверное значение");
                        break;
                }
            }
        }

        delegate void ShowInfo(object obj);

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
