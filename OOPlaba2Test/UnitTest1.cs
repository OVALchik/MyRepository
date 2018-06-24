using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPlaba2;

namespace OOPlaba2Test
{    
    [TestClass]
    public class Idustry
    {/*
        public static List<RobotMachine> CreateRobotMachineTest()
        {
            var machineList = new List<RobotMachine>()
            {
                new RobotMachine("Test_Robot", 5)
            };               
            return machineList;
        }

        public static List<PrimaryProduction> CreatePrimaryProductionTest()
        {
            var productionList = new List<PrimaryProduction>
            {
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Test_Product", new Size(1, 1,1, 1), 1)
                
            };
            return productionList;
        }

        public static List<string> CreatePipleListTest()
        {
            var pipleList = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            return pipleList;
        }
          

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
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000),
                new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500),
                new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Beam, "Брус W-10", new Size(10, 10, 200, 15), 400),
                new PrimaryProduction(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 200)
            };
            return productionList;
        }

        public static List<string> CreatePipleList()
        {
            var pipleList = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            return pipleList;
        }

        public static List<SecondaryProduction> CreateSecondaryProduction()
        {
            var productionList = new List<SecondaryProduction>
            {
                new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),TypeMaterial.Aluminum,6),
                new SecondaryProduction("Заготовка-ТТ3", new Size(150, 7, 7, 40),TypeMaterial.Wood,8),
                new SecondaryProduction("Заготовка-W11", new Size(100, 50,50, 45),TypeMaterial.Aluminum,8)
            };
            return productionList;
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

        [TestMethod]
        public void IndustryConstructor_Error()
        {
            try
            {
                var unused = new Industry("TestInd", null);
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("На производстве должен быть хотя бы один цех", e.Message);
            }
        }
     
        [TestMethod]
        public void UnionArrayProduction()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var pipleListPr = CreatePipleList();
            var productionListPr = CreateSecondaryProduction();

            var pipleListAs = CreatePipleList();
            var productionListAs = CreateFinalProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));
            var pd = new ProcessingDepartment("Обрабатывающий цех№1", pipleListPr,
                new List<Production>(productionListPr));
            var ad = new AssemblyDepartment("Сборочно-монтажный цех№1", pipleListAs,
                new List<Production>(productionListAs));

            var department = new List<Department> { st, pd, ad };

            var industry = new Industry("Инастриз", department);

            Assert.AreEqual(11, industry.ProductionList.Count);
        }

        [TestMethod]
        public void UnionArrayPiple()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var pipleListPr = CreatePipleList();
            var productionListPr = CreateSecondaryProduction();

            var pipleListAs = CreatePipleList();
            var productionListAs = CreateFinalProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));
            var pd = new ProcessingDepartment("Обрабатывающий цех№1", pipleListPr,
                new List<Production>(productionListPr));
            var ad = new AssemblyDepartment("Сборочно-монтажный цех№1", pipleListAs,
                new List<Production>(productionListAs));

            var department = new List<Department> { st, pd, ad };

            var industry = new Industry("Инастриз", department);

            Assert.AreEqual(9, industry.PipleList.Count);
        }

        [TestMethod]
        public void AddDepartment()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));

            var department = new List<Department> { st };

            var industry = new Industry("Инастриз", department);

            var pipleListPr = CreatePipleList();
            var productionListPr = CreateSecondaryProduction();

            var pd = new ProcessingDepartment("Обрабатывающий цех№1", pipleListPr,
                new List<Production>(productionListPr));
           
            industry.AddDepartment(pd);
            Assert.AreEqual(2, industry.Departaments.Count);
        }

        [TestMethod]
        public void RemoveDepartment_ERROR()
        {
            try
            {
                var machineList = CreateRobotMachine();
                var pipleListSt = CreatePipleList();
                var productionListSt = CreatePrimaryProduction();

                var pipleListPr = CreatePipleList();
                var productionListPr = CreateSecondaryProduction();

                var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));
                var pd = new ProcessingDepartment("Обрабатывающий цех№1", pipleListPr,
                    new List<Production>(productionListPr));

                var department = new List<Department> { st, pd };
                
                var industry = new Industry("Инастриз", department);
                industry.RemoveDepartment(5);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Неверный индекс", ex.Message);
            }           
        }

        [TestMethod]
        public void RemoveDepartment()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var pipleListPr = CreatePipleList();
            var productionListPr = CreateSecondaryProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));
            var pd = new ProcessingDepartment("Обрабатывающий цех№1", pipleListPr,
                new List<Production>(productionListPr));

            var department = new List<Department> { st , pd};
           
            var industry = new Industry("Инастриз", department);
            industry.RemoveDepartment(1);
            Assert.AreEqual(1, industry.Departaments.Count);
        }

        [TestMethod]
        public void EditDepartment_ERROR()
        {
            try
            {
                var machineList = CreateRobotMachine();
                var pipleListSt = CreatePipleList();
                var productionListSt = CreatePrimaryProduction();
                
                var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));
                var department = new List<Department> { st };

                var pipleListPr = CreatePipleList();
                var productionListPr = CreateSecondaryProduction();

                var pd = new ProcessingDepartment("Обрабатывающий цех№1", pipleListPr,
                    new List<Production>(productionListPr));

                var industry = new Industry("Инастриз", department);
                industry.EditDepartment(5,pd);

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Неверный индекс", e.Message);
            }
        }

        [TestMethod]
        public void Industry_Deserializable()
        {
            
                var machineList = CreateRobotMachineTest();
                var pipleListSt = CreatePipleListTest();
                var productionListSt = CreatePrimaryProductionTest();
                var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));
                var department = new List<Department> { st };
                var industry = new Industry("TestInd", department);

                XmlSerializer formatterIndSer = new XmlSerializer(typeof(Industry));
                using (FileStream fs =
                    new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\IndustryTestSerial.xml",
                        FileMode.OpenOrCreate))
                {
                    formatterIndSer.Serialize(fs, industry);
                }

                XmlSerializer formatterIndDes = new XmlSerializer(typeof(Industry));
                using (FileStream fs =
                    new FileStream(@"C:\Users\Алина\Documents\Visual Studio 2015\Projects\OOPlaba3\IndustryTestSerial.xml",
                        FileMode.OpenOrCreate))
                {
                    Industry newIndustry = (Industry)formatterIndDes.Deserialize(fs);
                Assert.AreEqual(industry.NameIndusry, newIndustry.NameIndusry);
            }
        }*/
    }
}
