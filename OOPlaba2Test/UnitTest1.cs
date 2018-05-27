using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPlaba2;

namespace OOPlaba2Test
{    
    [TestClass]
    public class Idustry
    {
        [TestMethod]
        public void IndustryConstructor_Error()
        {
            try
            {
                new Industry("TestInd", null);
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
            var productionListSt = new List<PrimaryProduction>
            {
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", 50, 70, 5, 3, 1000,
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
            var productionListPr = new List<SecondaryProduction>
            {
                new SecondaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Заготовка-AL5", 50, 50, 12, 5,
                    500, 350m)
            };

            var pipleListAs = new List<string> {"Захарова Е.Ф.", "Лубинин П.Я."};
            var productionListAs = new List<FinalProduction>
            {
                new FinalProduction("Станок измерительный", 100, 200, 160, 15, 1100, 5000m)
            };

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));
            var pd = new ProcessingDepartment("Обрабатывающий цех№1", pipleListPr,
                new List<Production>(productionListPr));
            var ad = new AssemblyDepartment("Сборочно-монтажный цех№1", pipleListAs,
                new List<Production>(productionListAs));

            var department = new List<Department> {st, pd, ad};

            var industry = new Industry("Инастриз", department);

            Assert.AreEqual(11, industry.CountPiples);
        }

        [TestMethod]
        public void GetCountProductionName()
        {
            var machineList = new List<RobotMachine> {new RobotMachine("Станочный резчик по металлу", 10)};
            var pipleListSt = new List<string> {"Захарова Е.Ф.", "Лубинин П.Я.", "Нестеров Н.П."};
            var productionListSt = new List<PrimaryProduction>
            {
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", 50, 70, 5, 3, 1000,
                    250m),
                new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5", 0.5, 0.5, 5, 7, 500, 1500m)
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
            var productionListPr = new List<SecondaryProduction>
            {
                new SecondaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Заготовка-AL5", 50, 50, 12, 5,
                    500, 350m),
                new SecondaryProduction(TypeMaterial.Titanium, TypeProduction.Ingot, "Заготовка-ТТ3", 150, 50, 7, 40,
                    200, 1500m)
            };

            var pipleListAs = new List<string> {"Захарова Е.Ф.", "Лубинин П.Я."};
            var productionListAs = new List<FinalProduction>
            {
                new FinalProduction("Станок измерительный", 100, 200, 160, 15, 1100, 5000m),
                new FinalProduction("Станок автоматизированный", 200, 50, 50, 17, 2100, 6000m)
            };

            var st = new StorageDepartment(machineList, "Заготовительный цех№1", pipleListSt,
                new List<Production>(productionListSt));
            var pd = new ProcessingDepartment("Обрабатывающий цех№1", pipleListPr,
                new List<Production>(productionListPr));
            var ad = new AssemblyDepartment("Сборочно-монтажный цех№1", pipleListAs,
                new List<Production>(productionListAs));

            var department = new List<Department> {st, pd, ad};

            var industry = new Industry("Инастриз", department);

            Assert.AreEqual(6, industry.CountNameProduction);
        }
    }
}
