using System.Collections.Generic;

namespace OOPlaba2
{
    class Init
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

        public static Industry InitializeOrganization(Industry industry)
        {
            var st = new StorageDepartment(CreateRobotMachine(), "Заготовительный цех№1",
                CreatePipleListForStorageDepartment(), new List<Production>(CreatePrimaryProduction()));

            var pd = new ProcessingDepartment("Обрабатывающий цех№1", CreatePipleListForProcessingDepartment(),
                new List<Production>(CreateSecondaryProduction()));

            var ad = new AssemblyDepartment("Сборочно-монтажный цех№1", CreatePipleListForAssembluDepartment(),
                new List<Production>(CreateFinalProduction()));

            var department = new List<Department> { st, pd, ad };

            return new Industry("Инастриз", department);
        }
    }
}
