using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard;

namespace TestLab_2_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, -2, 3 };
            int pn = 2;
            int mn = 1;

            var result = Key.Res(0, 0, a);
            int p = result.p;
            int m = result.m;

            Assert.AreEqual(pn, p);
            Assert.AreEqual(mn, m);
        }
    }
}
