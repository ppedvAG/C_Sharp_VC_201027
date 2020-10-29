using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fahrzeugpark;

namespace UnitTest_Fahrzeugpark
{
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_PKW_ueber_MaxG()
        {
            PKW pkw1 = new PKW("BMW", 210, 25000, 3);

            pkw1.StarteMotor();
            pkw1.Beschleunige(220);

            Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Bremse_PKW_unter_0()
        {
            PKW pkw1 = new PKW("BMW", 210, 25000, 3);

            pkw1.StarteMotor();
            pkw1.Beschleunige(220);
            pkw1.Beschleunige(-300);

            Assert.AreEqual(-5, pkw1.AktGeschwindigkeit);

        }
    }
}
