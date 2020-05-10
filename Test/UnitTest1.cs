using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSa()
        {
            double result = OOP_lab_1_14_1.Program.Sa(3, 27);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestSg()
        {
            double result = OOP_lab_1_14_1.Program.Sg(3, 27);
            Assert.AreEqual(9, result);
        }
    }
}