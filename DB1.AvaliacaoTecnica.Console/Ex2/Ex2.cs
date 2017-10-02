using System.Linq;

namespace DB1.AvaliacaoTecnica.Console.Ex2
{
    public static class Ex2
    {
        /// <summary>
        /// Verify if are only odd numbers in a array.
        /// </summary>
        /// <param name="numbers">Number array.</param>
        /// <returns>True if only odd numbers, false if not.</returns>
        public static bool AreOnlyOddNumbers(int[] numbers)
        {
            return numbers.All(x => x % 2 != 0);
        }
    }
}
