using DB1.AvaliacaoTecnica.Console.Ex1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DB1.AvaliacaoTecnica.Console.Test
{
    [TestClass]
    public class CollatzTest
    {
        [TestMethod]
        public void CollatzMaxLengthInRange()
        {
            Assert.AreEqual(3, Collatz.CollatzMaxLengthInRange(1, 5));
            Assert.AreEqual(6, Collatz.CollatzMaxLengthInRange(1, 6));
            Assert.AreEqual(97, Collatz.CollatzMaxLengthInRange(1, 100));
            Assert.AreEqual(171, Collatz.CollatzMaxLengthInRange(1, 200));
            Assert.AreEqual(235, Collatz.CollatzMaxLengthInRange(1, 300));
        }
    }
}
