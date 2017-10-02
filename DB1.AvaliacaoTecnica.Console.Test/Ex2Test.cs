using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyEx2 = DB1.AvaliacaoTecnica.Console.Ex2.Ex2;

namespace DB1.AvaliacaoTecnica.Console.Test
{
    [TestClass]
    public class Ex2Test
    {
        [TestMethod]
        public void TestOnlyOddNumbers()
        {
            int[] collection1 = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            int[] collection2 = { 3, 21, 24, 25, 34, 36, 41, 45, 47, 53, 57 };
            int[] collection3 = { 3, 5, 7, 11, 15, 17, 19, 21, 23, 25, 27 };

            Assert.AreEqual(false, MyEx2.AreOnlyOddNumbers(collection1));
            Assert.AreEqual(false, MyEx2.AreOnlyOddNumbers(collection2));
            Assert.AreEqual(true, MyEx2.AreOnlyOddNumbers(collection3));
        }
    }
}
