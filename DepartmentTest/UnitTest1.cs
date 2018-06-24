using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPlaba2;

namespace DepartmentTest
{
    [TestClass]
    public class Department
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
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(50, 70, 5, 3), 100),
                new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",new Size( 0.5, 0.5, 5, 7), 50),
                new PrimaryProduction(TypeMaterial.Wood, TypeProduction.Beam, "Брус W-10", new Size(10, 10, 200, 15), 40),
                new PrimaryProduction(TypeMaterial.Iron, TypeProduction.Rod, "Прут IR-5",new Size( 0.5, 0.5, 5, 7), 20)
            };
            return productionList;
        }

        public static List<string> CreatePipleList()
        {
            var pipleList = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
            return pipleList;
        }
     
        [TestMethod]
        public void StorageDepartmentConstructor_ErrorMachineList()
        {
            try
            {
                var pipleListSt = CreatePipleList();
                var productionListSt = CreatePrimaryProduction();

                var unused = new StorageDepartment(null, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));

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
                var machineList = CreateRobotMachine();             
                var productionListSt = CreatePrimaryProduction();

                var unused = new StorageDepartment(machineList, "Заготовительный цех№1", null,
                    new List<Production>(productionListSt));

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
                var machineList = CreateRobotMachine();
                var pipleListSt = CreatePipleList();

                var unused = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,null);

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
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt, new List<Production>(productionListSt));

            Assert.AreEqual(70,st.Productivity);  
        }

        [TestMethod]
        public void StorageDepartmentAddProduction()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));

            Production productionAdd = new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4",
                new Size(50, 70, 5, 3), 1000);

            st.AddProduction(productionAdd);

            Assert.AreEqual(5, st.Productions.Count);
        }

        [TestMethod]
        public void StorageDepartmentRemoveProduction()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));
           
            st.RemoveProduction(0);

            Assert.AreEqual(3, st.Productions.Count);
        }

        [TestMethod]
        public void StorageDepartmentRemoveProduction_ERROR()
        {
            try
            {
                var machineList = CreateRobotMachine();
                var pipleListSt = CreatePipleList();
                var productionListSt = CreatePrimaryProduction();

                var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));

                st.RemoveProduction(66);

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Неверный индекс", e.Message);
            }
        }

        [TestMethod]
        public void StorageDepartmentEditProduction()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));

            Production production = new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4",
                new Size(50, 70, 5, 3), 1000);

            st.EditProduction(0,production);

            Assert.AreEqual(production, st.Productions[0]);
        }

        [TestMethod]
        public void StorageDepartmentEditProduction_ERROR()
        {
            try
            {
                var machineList = CreateRobotMachine();
                var pipleListSt = CreatePipleList();
                var productionListSt = CreatePrimaryProduction();

                var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));

                Production production = new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4",
                    new Size(50, 70, 5, 3), 1000);

                st.EditProduction(66,production);

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Неверный индекс", e.Message);
            }
        }

        [TestMethod]
        public void StorageDepartmentAddPiple()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            string piple = "Жууновский В.Я.";

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));

            st.AddPiple(piple);

            Assert.AreEqual(4, st.PipleList.Count);
        }

        [TestMethod]
        public void StorageDepartmentRemovePiple()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));

            st.RemovePiple(0);

            Assert.AreEqual(2, st.PipleList.Count);
        }

        [TestMethod]
        public void StorageDepartmentRemovePiple_ERROR()
        {
            try
            {
                var machineList = CreateRobotMachine();
                var pipleListSt = CreatePipleList();
                var productionListSt = CreatePrimaryProduction();

                var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));

                st.RemovePiple(66);

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Неверный индекс", e.Message);
            }                      
        }

        [TestMethod]
        public void StorageDepartmentEditPiple()
        {
            var machineList = CreateRobotMachine();
            var pipleListSt = CreatePipleList();
            var productionListSt = CreatePrimaryProduction();

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));

            string piple = "Жууновский В.Я.";

            st.EditPiple(0,piple);

            Assert.AreEqual(piple, st.PipleList[0]);
        }

        [TestMethod]
        public void StorageDepartmentEditPiple_ERROR()
        {
            try
            {
                var machineList = CreateRobotMachine();
                var pipleListSt = CreatePipleList();
                var productionListSt = CreatePrimaryProduction();

                var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));

                string piple = "Жууновский В.Я.";
                st.EditPiple(66,piple);

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Неверный индекс", e.Message);
            }
        }
    }
}
