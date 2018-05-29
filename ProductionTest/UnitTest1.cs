using System;
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
                new PrimaryProduction(TypeMaterial.Aluminum, TypeProduction.Plate, "Лист AL-4", 0, 70, 5, 0, 1000,
                    250m);
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Габариты продукции введены неверно", e.Message);
            }
           
        }
    }
}
