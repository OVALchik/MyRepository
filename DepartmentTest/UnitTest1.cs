using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPlaba2;

namespace DepartmentTest
{
    [TestClass]
    public class Department
    {
        [TestMethod]
        public void StorageDepartmentConstructor_ErrorMachineList()
        {
            try
            {
                var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
                var productionListSt = new List<PrimaryProduction>
                {
                    new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", 50, 70, 5, 3, 1000,
                        250m)
                };

                var st = new StorageDepartment(null, "Заготовительный цех№1", pipleListSt,
                    new List<Production>(productionListSt));

                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Список авт. систем не должен быть пустым",e.Message);
            }         
        }
        /*
        [TestMethod]
        public void StorageDepartmentConstructor_ErrorPipleList()
        {
            try
            {
                var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
                var productionListSt = new List<PrimaryProduction>
                {
                    new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", 50, 70, 5, 3, 1000,
                        250m)
                };

                var st = new StorageDepartment(machineList, "Заготовительный цех№1", null,
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
                var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П." };
                var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };                             

                var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,null);

                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Список продукции не должен быть пустым", e.Message);
            }
        }*/

        [TestMethod]
        public void GetProductivity()
        {
            var pipleListSt = new List<string> { "Захарова Е.Ф.", "Лубинин П.Я.", "Лубинин П.Я." };
            var machineList = new List<RobotMachine> { new RobotMachine("Станочный резчик по металлу", 10) };
            var productionListSt = new List<PrimaryProduction>
            {
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", 50, 70, 5, 3, 1000,
                250m)
            };
            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt, new List<Production>(productionListSt));

            Assert.AreEqual(333,st.Productivity);  
        }

        
    }
}
