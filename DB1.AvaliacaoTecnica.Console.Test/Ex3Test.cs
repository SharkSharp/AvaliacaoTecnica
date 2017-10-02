using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyEx3 = DB1.AvaliacaoTecnica.Console.Ex3.Ex3;

namespace DB1.AvaliacaoTecnica.Console.Test
{
    [TestClass]
    public class Ex3Test
    {
        [TestMethod]
        public void TestDifference()
        {
            int[] firstArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] secondArray = { 4, 6, 93, 7, 55, 32, 3 };
            int[] expected = { 1, 29, 42, 98, 234 };

            int[] result = MyEx3.Difference(firstArray, secondArray);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
