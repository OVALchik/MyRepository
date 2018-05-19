using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlaba2
{  
    class Program
    {         
        public static List<StorageDepartment.RobotMachine> CreateRobotMachine()
        {
            List<StorageDepartment.RobotMachine> machineList = new List<StorageDepartment.RobotMachine>();
            machineList.Add(new StorageDepartment.RobotMachine("Станочный резчик по металлу",10));
            machineList.Add(new StorageDepartment.RobotMachine("Автоматизированный станок резьбы по дереву",5));
            machineList.Add(new StorageDepartment.RobotMachine("Прессовочный аппарат",10));
            
            return machineList;
        }       

        public static List<PrimaryProduction> CreatePrimaryProduction()
        {
            List<PrimaryProduction> productionList = new List<PrimaryProduction>();

            productionList.Add(new PrimaryProduction(PrimaryProduction.TypeMaterial.Aluminum, PrimaryProduction.TypeProduction.Plate,"Лист AL-4",50,70,5,3,1000,250m));
            productionList.Add(new PrimaryProduction(PrimaryProduction.TypeMaterial.Steel, PrimaryProduction.TypeProduction.Rod, "Прут ST-5", 0.5, 0.5, 5, 7, 500, 1500m));
            productionList.Add(new PrimaryProduction(PrimaryProduction.TypeMaterial.Wood, PrimaryProduction.TypeProduction.Beam, "Брус W-10", 10, 10, 200, 15, 400, 500m));
            productionList.Add(new PrimaryProduction(PrimaryProduction.TypeMaterial.Iron, PrimaryProduction.TypeProduction.Rod, "Прут IR-5", 0.5, 0.5, 5, 7, 200, 1000m));

            return productionList;
        }

        public static List<string> CreatePipleListForStorageDepartment()
        {
            List<string> pipleList = new List<string>();

            pipleList.Add("Захарова Е.Ф.");
            pipleList.Add("Лубинин П.Я.");
            pipleList.Add("Нестеров Н.П.");           

            return pipleList;
        }

        public static List<SecondaryProduction> CreateSecondaryProduction()
        {
            List<SecondaryProduction> productionList = new List<SecondaryProduction>();

            productionList.Add(new SecondaryProduction(SecondaryProduction.TypeMaterial.Aluminum, "Заготовка-AL5", 50, 50, 12, 5, 500, 350m));
            productionList.Add(new SecondaryProduction(SecondaryProduction.TypeMaterial.Titanium, "Заготовка-ТТ3", 150, 50, 7, 40, 200, 1500m));
            productionList.Add(new SecondaryProduction(SecondaryProduction.TypeMaterial.Wood, "Заготовка-W11", 50, 50, 100, 45, 1500, 450m));

            return productionList;
        }

        public static List<string> CreatePipleListForProcessingDepartment()
        {
            List<string> pipleList = new List<string>();

            pipleList.Add("Зимин Е.М.");
            pipleList.Add("Лясова А.А.");
            pipleList.Add("Носов Н.П.");
            pipleList.Add("Зинков В.В.");
            pipleList.Add("Никитина В.З.");         

            return pipleList;
        }

        public static List<FinalProduction> CreateFinalProduction()
        {
            List<FinalProduction> productionList = new List<FinalProduction>();

            productionList.Add(new FinalProduction("Станок измерительный", 100, 200, 160, 15, 1100, 5000m));
            productionList.Add(new FinalProduction("Станок автоматизированный", 200, 50, 50, 17, 2100, 6000m));
            productionList.Add(new FinalProduction("Измеритель", 50, 50, 30, 1.2, 1500, 300m));

            return productionList;
        }

        public static List<string> CreatePipleListForAssembluDepartment()
        {
            List<string> pipleList = new List<string>();

            pipleList.Add("Зимин Е.М.");
            pipleList.Add("Лясова А.А.");
            pipleList.Add("Носов Н.П.");
            pipleList.Add("Зинков В.В.");
            pipleList.Add("Никитина В.З.");
            pipleList.Add("Зорченко Ю.В.");
            pipleList.Add("Захарова Ю.Ф.");

            return pipleList;
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
                        {
                            Console.WriteLine("Выбор цеха:");
                            for (int i = 0; i < industry.Departaments.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}.{industry.Departaments[i].NameDepartment}");
                            }
                            int item = Convert.ToInt32(Console.ReadLine());
                            industry.Departaments[item - 1].ShowInfoDepartment();
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Выбор пункта:");
                            Console.WriteLine("1.Добавить цех");
                            Console.WriteLine("2.Удалить цех");
                            Console.WriteLine("3.Изменить цех");
                            int item = Convert.ToInt32(Console.ReadLine());

                            switch (item)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Выбор типа цеха:");
                                        Console.WriteLine("1.Заготавливающий цех");
                                        Console.WriteLine("2.Обрабатывающий цех");
                                        Console.WriteLine("3.Сборочно-монтажный цех");
                                        int itemDep = Convert.ToInt32(Console.ReadLine());

                                        List<string> pipleList = new List<string>();
                                        pipleList.Add("Зощенко Е.Ф.");
                                        pipleList.Add("Клубина П.Я.");
                                        pipleList.Add("Носов Н.П.");

                                        switch (itemDep)
                                        {
                                            case 1:
                                                {
                                                    List<StorageDepartment.RobotMachine> machineList = new List<StorageDepartment.RobotMachine>();
                                                    machineList.Add(new StorageDepartment.RobotMachine("Станочный резчик по дереву", 15));
                                                    machineList.Add(new StorageDepartment.RobotMachine("Автоматизированный станок резьбы по дереву", 10));

                                                    List<PrimaryProduction> productionList = new List<PrimaryProduction>();
                                                    productionList.Add(new PrimaryProduction(PrimaryProduction.TypeMaterial.Wood, PrimaryProduction.TypeProduction.Plate, "Лист W-4", 50, 70, 5, 3, 10000, 250m));
                                                    productionList.Add(new PrimaryProduction(PrimaryProduction.TypeMaterial.Wood, PrimaryProduction.TypeProduction.Rod, "Прут W-5", 0.5, 0.5, 5, 7, 5000, 150m));

                                                    StorageDepartment newSt = new StorageDepartment(machineList, "Заготовительный цех№2", pipleList, new List<Production>(productionList));
                                                    industry.Departaments.Add(newSt);
                                                }
                                                break;
                                            case 2:
                                                {
                                                    List<SecondaryProduction> productionList = new List<SecondaryProduction>();
                                                    productionList.Add(new SecondaryProduction(SecondaryProduction.TypeMaterial.Iron, "Заготовка-I5", 50, 50, 12, 5, 5000, 350m));
                                                    productionList.Add(new SecondaryProduction(SecondaryProduction.TypeMaterial.Iron, "Заготовка-I3", 150, 50, 7, 40, 2000, 1500m));

                                                    ProcessingDepartment newPd = new ProcessingDepartment("Обрабатывающий цех№2", pipleList, new List<Production>(productionList));
                                                    industry.Departaments.Add(newPd);
                                                }
                                                break;
                                            case 3:
                                                {
                                                    List<FinalProduction> productionList = new List<FinalProduction>();
                                                    productionList.Add(new FinalProduction("Станок A09", 100, 200, 160, 15, 100, 5000m));
                                                    productionList.Add(new FinalProduction("Станок автоматизированный B-8", 200, 50, 50, 17, 100, 6000m));
                                                    productionList.Add(new FinalProduction("Измеритель ЭТМ", 50, 50, 30, 1.2, 100, 300m));

                                                    AssemblyDepartment newAd = new AssemblyDepartment("Сборочно-монтажный цех№2", pipleList, new List<Production>(productionList));
                                                    industry.Departaments.Add(newAd);
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Выбор цеха:");
                                        for (int i = 0; i < industry.Departaments.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}.{industry.Departaments[i].NameDepartment}");
                                        }
                                        int itemDep = Convert.ToInt32(Console.ReadLine());
                                        industry.Departaments.RemoveAt(itemDep - 1);
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Выбор пункта:");
                                        Console.WriteLine("1.Изменить продукцию цеха");
                                        Console.WriteLine("2.Изменить бригаду цеха");
                                        Console.WriteLine("3.Переспециализировать цех (полные изменения)");
                                        int item1 = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Выбор цеха:");
                                        for (int i = 0; i < industry.Departaments.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}.{industry.Departaments[i].NameDepartment}");
                                        }
                                        int itemDep = Convert.ToInt32(Console.ReadLine());

                                        switch (item1)
                                        {
                                            case 1:
                                                {
                                                    if (industry.Departaments[itemDep - 1].GetType() == typeof(StorageDepartment))
                                                    {
                                                        industry.Departaments[itemDep - 1].RemoveProduction(0);
                                                    }
                                                    if (industry.Departaments[itemDep - 1].GetType() == typeof(ProcessingDepartment))
                                                    {
                                                        industry.Departaments[itemDep - 1].RemoveProduction(0);
                                                    }
                                                    if (industry.Departaments[itemDep - 1].GetType() == typeof(AssemblyDepartment))
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
                                                    List<string> pipleList = new List<string>();
                                                    pipleList.Add("Зощин Е.Ф.");
                                                    pipleList.Add("Кубина П.Я.");
                                                    List<FinalProduction> productionList = new List<FinalProduction>();
                                                    productionList.Add(new FinalProduction("Станок автоматизированный B-8", 200, 50, 50, 17, 100, 6000m));
                                                    productionList.Add(new FinalProduction("Измеритель ЭТМ", 50, 50, 30, 1.2, 100, 300m));
                                                    AssemblyDepartment newAd = new AssemblyDepartment("Сборочно-монтажный цех№3", pipleList, new List<Production>(productionList));

                                                    industry.EditDepartment((item1 - 1), newAd);
                                                }
                                                break;
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case 3:
                        {
                            industry.ShowInfoIndustry();
                        }
                        break;
                    case 4:
                        {
                            industry.ShowListProduction();
                        }
                        break;
                    case 5:
                        {
                            industry.ShowListPiples();
                        }
                        break;
                    case 6:
                        {
                            industry.ShowInfoProductivity();
                        }
                        break;
                    case 7:
                        {
                            flag = false;
                        }
                        break;
                }          
        }
    }

        static void Main(string[] args)
        {
            StorageDepartment st = new StorageDepartment(CreateRobotMachine(), "Заготовительный цех№1", CreatePipleListForStorageDepartment(), new List<Production>(CreatePrimaryProduction()));
            ProcessingDepartment pd = new ProcessingDepartment("Обрабатывающий цех№1", CreatePipleListForProcessingDepartment(), new List<Production>(CreateSecondaryProduction()));
            AssemblyDepartment ad = new AssemblyDepartment("Сборочно-монтажный цех№1", CreatePipleListForAssembluDepartment(), new List<Production>(CreateFinalProduction()));

            List<Department> department = new List<Department>();
            department.Add(st);
            department.Add(pd);
            department.Add(ad);

            Industry industry = new Industry("Инастриз", department);
            ShowClassWork(industry);

        }
    }
}
