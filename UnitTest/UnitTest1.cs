using Microsoft.VisualStudio.TestTools.UnitTesting;
using program_1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form = new Form1();
            form.mass = new int[] { 0, 0, 0 };
            Assert.AreEqual(0, form.currentNumber);
        }
    }
}
