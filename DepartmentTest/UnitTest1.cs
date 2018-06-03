using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPlaba2;

namespace DepartmentTest
{
    [TestClass]
    public class DepartmentDTO
    {
        [TestMethod]
        public void StorageDepartmentConstructor_ErrorMachineList()
        {
            try
            {
                var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
                var productionListSt = new List<PrimaryProductionDTO>
                {
                    new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size( 50, 70, 5, 3), 1000,
                        250m)
                };

                var st = new StorageDepartmentDTO(null, "Заготовительный цех№1", pipleListSt,
                    new List<ProductionDTO>(productionListSt));

                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Список авт. систем не должен быть пустым",e.Message);
            }         
        }
        
        [TestMethod]
        public void StorageDepartmentConstructor_ErrorPipleList()
        {
            try
            {
                var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
                var productionListSt = new List<PrimaryProductionDTO>
                {
                    new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size( 50, 70, 5, 3), 1000,
                        250m)
                };

                var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", null,
                    new List<ProductionDTO>(productionListSt));

                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Список рабочих не должен быть пустым", e.Message);
            }
        }
        
        [TestMethod]
        public void StorageDepartmentConstructor_ErrorProductionList()
        {
            try
            {
                var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
                var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };                             

                var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,null);

                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Список продукции не должен быть пустым", e.Message);
            }
        }

        [TestMethod]
        public void GetProductivity()
        {
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Лубинин П.Я." };
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size( 50, 70, 5, 3), 1000,
                250m)
            };
            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt, new List<ProductionDTO>(productionListSt));

            Assert.AreEqual(333,st.Productivity);  
        }

        [TestMethod]
        public void StorageDepartmentAddProduction()
        {
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
                var productionListSt = new List<PrimaryProductionDTO>
                {
                    new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size( 50, 70, 5, 3), 1000,
                        250m)
                };

                var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<ProductionDTO>(productionListSt));

            ProductionDTO productionAdd = new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4",
                new Size(50, 70, 5, 3), 1000,
                250m);

            st.AddProduction(productionAdd);

            Assert.AreEqual(2, st.Productions.Count);
        }

        [TestMethod]
        public void StorageDepartmentRemoveProduction()
        {
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size( 50, 70, 5, 3), 1000,
                    250m),
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4",
                    new Size(50, 70, 5, 3), 1000,
                    250m)
        };

            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                new List<ProductionDTO>(productionListSt));
           
            st.RemoveProduction(0);

            Assert.AreEqual(1, st.Productions.Count);
        }

        [TestMethod]
        public void StorageDepartmentAddPiple()
        {
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size( 50, 70, 5, 3), 1000,
                    250m)
            };

            string piple = "Жууновский В.Я.";
            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                new List<ProductionDTO>(productionListSt));

            st.AddPiple(piple);

            Assert.AreEqual(4, st.PipleList.Count);
        }

        [TestMethod]
        public void StorageDepartmentRemovePiple()
        {
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            var productionListSt = new List<PrimaryProductionDTO>
            {
                new PrimaryProductionDTO(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size( 50, 70, 5, 3), 1000,
                    250m)               
            };

            var st = new StorageDepartmentDTO(machineList, "Заготовительный цех№1", pipleListSt,
                new List<ProductionDTO>(productionListSt));

            st.RemovePiple(0);

            Assert.AreEqual(2, st.PipleList.Count);
        }
    }
}
