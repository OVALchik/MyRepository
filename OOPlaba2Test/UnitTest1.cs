using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPlaba2;

namespace OOPlaba2Test
{    
    [TestClass]
    public class IdustryDTO
    {
        [TestMethod]
        public void IndustryConstructor_Error()
        {
            try
            {
                new IndustryDTO("TestInd", null);
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("На производстве должен быть хотя бы один цех", e.Message);
            }
        }

        [TestMethod]
        public void GetCountPiples()
        {
            var machineList = new List<RobotMachine> {new RobotMachine("Станочный резчик по металлу", 10)};
            var pipleListSt = new List<string> {"Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П."};
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3),  1000,
                    250m)
            };

            var pipleListPr = new List<string>
            {
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П.",
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П. "
            };
            var productionListPr = new List<SecondaryProductionDTO>
            {            
                new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                    250m))
            };

            var pipleListAs = new List<string> {"Захарова Е.Ф.", "Лубинин П.Я."};
            var productionListAs = new List<FinalProductionDTO>
            {               
                new FinalProductionDTO("Станок измерительный",new Size( 100, 200, 160, 15), 1100,
                new List<SecondaryProductionDTO>
                {
                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                            250m))                    
                })               
            };

            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                new List<ProductionDTO>(productionListSt));
            var pd = new ProcessingDepartmentDTO("Обрабатывающий цех№1", pipleListPr,
                new List<ProductionDTO>(productionListPr));
            var ad = new AssemblyDepartmentDTO("Сборочно-монтажный цех№1", pipleListAs,
                new List<ProductionDTO>(productionListAs));

            var department = new List<DepartmentDTO> {st, pd, ad};

            var industry = new IndustryDTO("Инастриз", department);

            Assert.AreEqual(11, industry.CountPiples);
        }

        [TestMethod]
        public void GetCountProductionName()
        {
            var machineList = new List<RobotMachine> {new RobotMachine("Станочный резчик по металлу", 10)};
            var pipleListSt = new List<string> {"Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П."};
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3),  1000,
                    250m),
                new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Beam, "Лист V09", new Size(50, 100, 5, 5),  500,
                250m)
            };

            var pipleListPr = new List<string>
            {
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П.",
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П. "
            };
            var productionListPr = new List<SecondaryProductionDTO>
            {               
                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                            250m)),
                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                            1500m))                
            };

            var pipleListAs = new List<string> {"Захарова Е.Ф.", "Лубинин П.Я."};
            var productionListAs = new List<FinalProductionDTO>
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
                new FinalProductionDTO("Станок измерительный",new Size( 100, 200, 160, 15), 1100,
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

            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                new List<ProductionDTO>(productionListSt));
            var pd = new ProcessingDepartmentDTO("Обрабатывающий цех№1", pipleListPr,
                new List<ProductionDTO>(productionListPr));
            var ad = new AssemblyDepartmentDTO("Сборочно-монтажный цех№1", pipleListAs,
                new List<ProductionDTO>(productionListAs));

            var department = new List<DepartmentDTO> {st, pd, ad};

            var industry = new IndustryDTO("Инастриз", department);

            Assert.AreEqual(6, industry.CountNameProduction);
        }

        [TestMethod]
        public void UnionArrayProduction()
        {
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3),  1000,
                    250m),
                new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Beam, "Лист V09", new Size(50, 100, 5, 5),  500,
                250m)
            };

            var pipleListPr = new List<string>
            {
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П.",
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П. "
            };
            var productionListPr = new List<SecondaryProductionDTO>
            {
                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                            250m)),
                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                            1500m))
            };

            var pipleListAs = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я." };
            var productionListAs = new List<FinalProductionDTO>
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
                new FinalProductionDTO("Станок измерительный",new Size( 100, 200, 160, 15), 1100,
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

            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                new List<ProductionDTO>(productionListSt));
            var pd = new ProcessingDepartmentDTO("Обрабатывающий цех№1", pipleListPr,
                new List<ProductionDTO>(productionListPr));
            var ad = new AssemblyDepartmentDTO("Сборочно-монтажный цех№1", pipleListAs,
                new List<ProductionDTO>(productionListAs));

            var department = new List<DepartmentDTO> { st, pd, ad };

            var industry = new IndustryDTO("Инастриз", department);

            Assert.AreEqual(6, industry.ProductionList.Count);
        }

        [TestMethod]
        public void UnionArrayPiple()
        {
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3),  1000,
                    250m),
                new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Beam, "Лист V09", new Size(50, 100, 5, 5),  500,
                250m)
            };

            var pipleListPr = new List<string>
            {
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П.",
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П. "
            };
            var productionListPr = new List<SecondaryProductionDTO>
            {
                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                            250m)),
                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                            1500m))
            };

            var pipleListAs = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я." };
            var productionListAs = new List<FinalProductionDTO>
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
                new FinalProductionDTO("Станок измерительный",new Size( 100, 200, 160, 15), 1100,
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

            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                new List<ProductionDTO>(productionListSt));
            var pd = new ProcessingDepartmentDTO("Обрабатывающий цех№1", pipleListPr,
                new List<ProductionDTO>(productionListPr));
            var ad = new AssemblyDepartmentDTO("Сборочно-монтажный цех№1", pipleListAs,
                new List<ProductionDTO>(productionListAs));

            var department = new List<DepartmentDTO> { st, pd, ad };

            var industry = new IndustryDTO("Инастриз", department);

            Assert.AreEqual(11, industry.PipleList.Count);
        }

        [TestMethod]
        public void AddDepartment()
        {
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3),  1000,
                    250m),
                new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Beam, "Лист V09", new Size(50, 100, 5, 5),  500,
                250m)
            };

            var pipleListPr = new List<string>
            {
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П.",
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П. "
            };
            var productionListPr = new List<SecondaryProductionDTO>
            {
                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                            250m)),
                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                            1500m))
            };
          
            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                new List<ProductionDTO>(productionListSt));
            var department = new List<DepartmentDTO> { st };
            var pd = new ProcessingDepartmentDTO("Обрабатывающий цех№1", pipleListPr,
                new List<ProductionDTO>(productionListPr));

            var industry = new IndustryDTO("Инастриз", department);
            industry.AddDepartment(pd);
            Assert.AreEqual(2, industry.Departaments.Count);
        }

        [TestMethod]
        public void RemoveDepartment_ERROR()
        {
            try
            {
                var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
                var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
                var productionListSt = new List<PrimaryProductionDTO>
                {
                    new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3),  1000,
                        250m),
                    new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Beam, "Лист V09", new Size(50, 100, 5, 5),  500,
                        250m)
                };

                var pipleListPr = new List<string>
                {
                    "Захарова Е.Ф.",
                    "Лубинин П.Я.",
                    "Нестеров Н.П.",
                    "Захарова Е.Ф.",
                    "Лубинин П.Я.",
                    "Нестеров Н.П. "
                };
                var productionListPr = new List<SecondaryProductionDTO>
                {
                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                            250m)),
                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                            1500m))
                };

                var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<ProductionDTO>(productionListSt));
                var pd = new ProcessingDepartmentDTO("Обрабатывающий цех№1", pipleListPr,
                    new List<ProductionDTO>(productionListPr));

                var department = new List<DepartmentDTO> { st, pd };
                
                var industry = new IndustryDTO("Инастриз", department);
                industry.RemoveDepartment(5);

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Ошибка в Assert.Fail.", e.Message);
            }           
        }

        [TestMethod]
        public void RemoveDepartment()
        {
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3),  1000,
                    250m),
                new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Beam, "Лист V09", new Size(50, 100, 5, 5),  500,
                250m)
            };

            var pipleListPr = new List<string>
            {
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П.",
                "Захарова Е.Ф.",
                "Лубинин П.Я.",
                "Нестеров Н.П. "
            };
            var productionListPr = new List<SecondaryProductionDTO>
            {
                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                            250m)),
                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                            1500m))
            };

            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                new List<ProductionDTO>(productionListSt));
            var pd = new ProcessingDepartmentDTO("Обрабатывающий цех№1", pipleListPr,
                new List<ProductionDTO>(productionListPr));

            var department = new List<DepartmentDTO> { st , pd};
           

            var industry = new IndustryDTO("Инастриз", department);
            industry.RemoveDepartment(1);
            Assert.AreEqual(1, industry.Departaments.Count);
        }

        [TestMethod]
        public void EditDepartment_ERROR()
        {
            try
            {
                var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
                var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
                var productionListSt = new List<PrimaryProductionDTO>
                {
                    new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3),  1000,
                        250m),
                    new PrimaryProductionDTO(TypeMaterial.Iron, TypeProduction.Beam, "Лист V09", new Size(50, 100, 5, 5),  500,
                        250m)
                };

                var pipleListPr = new List<string>
                {
                    "Захарова Е.Ф.",
                    "Лубинин П.Я.",
                    "Нестеров Н.П.",
                    "Захарова Е.Ф.",
                    "Лубинин П.Я.",
                    "Нестеров Н.П. "
                };
                var productionListPr = new List<SecondaryProductionDTO>
                {
                    new SecondaryProductionDTO("Заготовка-AL5", new Size(50, 50, 12, 5),
                        new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 1000,
                            250m)),
                    new SecondaryProductionDTO("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                        new PrimaryProductionDTO(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 500,
                            1500m))
                };

                var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<ProductionDTO>(productionListSt));
                var department = new List<DepartmentDTO> { st };
                var pd = new ProcessingDepartmentDTO("Обрабатывающий цех№1", pipleListPr,
                    new List<ProductionDTO>(productionListPr));

                var industry = new IndustryDTO("Инастриз", department);
                industry.EditDepartment(5,pd);

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Ошибка в Assert.Fail.", e.Message);
            }
        }
    }
}
