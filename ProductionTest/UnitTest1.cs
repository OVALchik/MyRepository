using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPlaba2;

namespace ProductionTest
{
    [TestClass]
    public class Production
    {
        [TestMethod]
        public void ProductionConstructor_Error()
        {
            try
            {
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", new Size(0, 0, 0, 0), 1000,
                    250m);
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Габариты продукции введены неверно", e.Message);
            }
           
        }

        [TestMethod]
        public void GetPrice()
        {
            var secondaryProduction = new List<SecondaryProduction>
            {
                new SecondaryProduction("Заготовка-AL5", new Size(50, 50, 12, 5),
                    new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4",
                        new Size(50, 70, 5, 3), 1000,
                        250m)),
                new SecondaryProduction("Заготовка-ТТ3", new Size(150, 7, 7, 40),
                    new PrimaryProduction(TypeMaterial.Steel, TypeProduction.Rod, "Прут ST-5",
                        new Size(0.5, 0.5, 5, 7), 500,
                        1500m))
            };

            FinalProduction production = new FinalProduction("Станок измерительный", new Size(100, 200, 160, 15),
                1100, secondaryProduction);


            Assert.AreEqual(3937.50m, production.PriceProduction);
        }
    }
}
