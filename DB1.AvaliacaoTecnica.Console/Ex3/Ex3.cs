using System.Linq;

namespace DB1.AvaliacaoTecnica.Console.Ex3
{
    public static class Ex3
    {
        /// <summary>
        /// Calculate the array resulting from the difference of two arrays.
        /// </summary>
        /// <param name="array1">Main array.</param>
        /// <param name="array2">Array to be subtracted</param>
        /// <returns>Result of subtraction of <paramref name="array2"/> from <paramref name="array1"/>.</returns>
        public static int[] Difference(int[] array1, int[] array2)
        {
            return array1.Except(array2).ToArray();
        }
    }
}
