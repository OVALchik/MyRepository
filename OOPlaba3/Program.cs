using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

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

        public static List<PrimaryProductionDTO> CreatePrimaryProduction()
        {
            var productionList = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                    250m),
                new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500, 1500m),
                new PrimaryProductionDTO(TypeMaterial.Wood, TypeProduction.Beam, "Брус W-10", new Size(10, 10, 200, 15), 400, 500m),
                new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200, 1000m)
            };
            return productionList;
        }

        public static List<string> CreatePipleListForStorageDepartment()
        {
            var pipleList = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            return pipleList;
        }

        public static List<SecondaryProductionDTO> CreateSecondaryProduction()
        {
            var productionList = new List<SecondaryProductionDTO>
            {
                new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                    new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                    250m)),
                new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                    new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                        1500m)),
                new SecondaryProductionDTO("Заготовка-W11", new Size(100, 50,50, 45),
                    new PrimaryProductionDTO(TypeMaterial.Wood, TypeProduction.Beam, "Брус W-10", new Size(10, 10, 200, 15), 400,
                        500m)),
                new SecondaryProductionDTO("Заготовка-I95", new Size(10, 2, 2, 10),
                    new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200,
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

        public static List<FinalProductionDTO> CreateFinalProduction()
        {
            var productionList = new List<FinalProductionDTO>
            {
                new FinalProductionDTO("Станок измерительный",new Size( 100, 200, 160, 15), 1100,
                    new List<SecondaryProductionDTO>
                    {
                        new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                            new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                250m)),
                        new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                            new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                1500m))
                        }),
                new FinalProductionDTO("Станок автоматизированный", new Size(200, 50, 50, 17), 2100,
                    new List<SecondaryProductionDTO>
                    {
                        new SecondaryProductionDTO("Заготовка-W11", new Size(100, 50,50, 45),
                            new PrimaryProductionDTO(TypeMaterial.Wood, TypeProduction.Beam, "Брус W-10", new Size(10, 10, 200, 15), 400,
                                500m)),
                        new SecondaryProductionDTO("Заготовка-I95", new Size(10, 2, 2, 10),
                            new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200,
                                1000m))
                    }),
                new FinalProductionDTO("Измеритель", new Size(50, 50, 30, 1.2), 1500,
                    new List<SecondaryProductionDTO>
                    {
                        new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                            new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                250m)),
                        new SecondaryProductionDTO("Заготовка-I95", new Size(10, 2, 2, 10),
                            new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200,
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

        public static void AddDepartmentFromIndusty(IndustryDTO industry)
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

                        var productionList = new List<PrimaryProductionDTO>
                       {
                          new PrimaryProductionDTO(TypeMaterial.Wood, TypeProduction.Plate,"Лист W-4",new Size( 50, 70, 5, 3), 10000, 250m),
                          new PrimaryProductionDTO(TypeMaterial.Wood, TypeProduction.Rod,"Прут W-5",new Size( 0.5, 0.5, 5, 7), 5000, 150m)
                       };

                        var newSt = new StorageDepartmentDTO(machineList, "Заготовительный цех№2", pipleList, new List<ProductionDTO>(productionList));
                        industry.AddDepartment(newSt);
                    }
                    break;
                case 2:
                    {
                        var productionList = new List<SecondaryProductionDTO>
                        {
                            new SecondaryProductionDTO("Заготовка-I5",new Size( 50, 50, 12, 5),
                                new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200, 1000m)),
                            new SecondaryProductionDTO("Заготовка-P3",new Size( 150, 50, 7, 40),
                                new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Plate, "Лист IR-3",new Size( 5, 5, 1, 9), 250, 1500m))
                        };

                        var newPd = new ProcessingDepartmentDTO("Обрабатывающий цех№2", pipleList, new List<ProductionDTO>(productionList));
                        industry.AddDepartment(newPd);
                    }
                    break;
                case 3:
                    {
                        var productionList = new List<FinalProductionDTO>
                        {
                            new FinalProductionDTO("Станок A09", new Size(100, 200, 160, 15), 100,
                                new List<SecondaryProductionDTO>
                                {
                                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                            1500m))
                                }),
                            new FinalProductionDTO("Станок автоматизированный B-8", new Size(200, 50, 50, 17), 100,
                                new List<SecondaryProductionDTO>
                                {
                                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                            1500m))
                                }),
                            new FinalProductionDTO("Измеритель ЭТМ", new Size(50, 50, 30, 1.2), 100,
                                new List<SecondaryProductionDTO>
                                {
                                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m))
                                }),
                        };

                        var newAd = new AssemblyDepartmentDTO("Сборочно-монтажный цех№2", pipleList, new List<ProductionDTO>(productionList));
                        industry.AddDepartment(newAd);
                    }
                    break;
                default:
                    Console.WriteLine("Введено неверное значение");
                    break;
            }
        }

        public static void RemoveDepartmentFromIndustry(IndustryDTO industry)
        {
            Console.WriteLine("Выбор цеха:");
            for (int i = 0; i < industry.Departaments.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{industry.Departaments[i].NameDepartment}");
            }
            var itemDep = Convert.ToInt32(Console.ReadLine());
            industry.RemoveDepartment(itemDep - 1);
        }

        public static void EditDepartmentFromIndustry(IndustryDTO industry)
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
                        if (industry.Departaments[itemDep - 1] is StorageDepartmentDTO)
                        {
                            industry.Departaments[itemDep - 1].RemoveProduction(0);
                        }
                        if (industry.Departaments[itemDep - 1] is ProcessingDepartmentDTO)
                        {
                            industry.Departaments[itemDep - 1].RemoveProduction(0);
                        }
                        if (industry.Departaments[itemDep - 1] is AssemblyDepartmentDTO)
                        {
                            industry.Departaments[itemDep - 1].AddProduction(new FinalProductionDTO("Станок автоматизированный PT-8", new Size(200, 50, 50, 17), 100,
                                new List<SecondaryProductionDTO>
                                {
                                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
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
                        var productionList = new List<FinalProductionDTO>
                        {
                            new FinalProductionDTO("Станок автоматизированный B-8",new Size( 200, 50, 50, 17), 100,
                                new List<SecondaryProductionDTO>
                                {
                                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                            1500m))
                                }),
                            new FinalProductionDTO("Измеритель ЭТМ", new Size(50, 50, 30, 1.2), 100,
                                new List<SecondaryProductionDTO>
                                {
                                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                                            250m)),
                                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                                            1500m))
                                })

                    };
                        var newAd = new AssemblyDepartmentDTO("Сборочно-монтажный цех№3", pipleList, new List<ProductionDTO>(productionList));

                        industry.EditDepartment((item - 1), newAd);
                    }
                    break;
                default:
                    Console.WriteLine("Введено неверное значение");
                    break;
            }
        }

        public static void ChangeDepartment(IndustryDTO industry)
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

        public static void ShowInfoReport(IndustryDTO industry)
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

        public static void ShowClassWork(IndustryDTO industry)
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
            Report report = new Report();

            var st = new StorageDepartmentDTO(CreateRobotMachine(), "Заготовительный цех№1", CreatePipleListForStorageDepartment(), new List<ProductionDTO>(CreatePrimaryProduction()));
            XmlSerializer formatterSt = new XmlSerializer(typeof(StorageDepartmentDTO));
            using (FileStream fs = new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\StorageDepartment.xml", FileMode.OpenOrCreate))
            {
                formatterSt.Serialize(fs, st);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\StorageDepartment.xml", FileMode.OpenOrCreate))
            {
                StorageDepartmentDTO newStorageDepartment = (StorageDepartmentDTO)formatterSt.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                report.ShowInfoDepartment(newStorageDepartment);

            }

            var pd = new ProcessingDepartmentDTO("Обрабатывающий цех№1", CreatePipleListForProcessingDepartment(), new List<ProductionDTO>(CreateSecondaryProduction()));
            XmlSerializer formatterPd = new XmlSerializer(typeof(ProcessingDepartmentDTO));
            using (FileStream fs = new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\ProcessingDepartment.xml", FileMode.OpenOrCreate))
            {
                formatterPd.Serialize(fs, pd);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\ProcessingDepartment.xml", FileMode.OpenOrCreate))
            {
                ProcessingDepartmentDTO newProcessingDepartment = (ProcessingDepartmentDTO)formatterPd.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                report.ShowInfoDepartment(newProcessingDepartment);
            }

            var ad = new AssemblyDepartmentDTO("Сборочно-монтажный цех№1", CreatePipleListForAssembluDepartment(), new List<ProductionDTO>(CreateFinalProduction()));
            XmlSerializer formatterAd = new XmlSerializer(typeof(AssemblyDepartmentDTO));
            using (FileStream fs = new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\AssemblygDepartment.xml", FileMode.OpenOrCreate))
            {
                formatterAd.Serialize(fs, ad);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\AssemblygDepartment.xml", FileMode.OpenOrCreate))
            {
                AssemblyDepartmentDTO newAssemblyDepartment = (AssemblyDepartmentDTO)formatterAd.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                report.ShowInfoDepartment(newAssemblyDepartment);
            }

            var department = new List<DepartmentDTO> { st, pd, ad };

            var industry = new IndustryDTO("Инастриз", department);
            industry.NameIndusry = "gt";
            
            XmlSerializer formatterInd = new XmlSerializer(typeof(IndustryDTO));
            using (FileStream fs = new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\Industry.xml", FileMode.OpenOrCreate))
            {
                formatterInd.Serialize(fs, industry);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\Industry.xml", FileMode.OpenOrCreate))
            {
                IndustryDTO newIndustry = (IndustryDTO)formatterInd.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                report.ShowInfoIndustry(newIndustry);
            }

            var dep = new List<DepartmentDTO>();
                //IndustryDTO ind = new IndustryDTO(dep);

            ShowClassWork(industry);
        }
    }
}
