using System.Collections.Generic;

namespace DB1.AvaliacaoTecnica.Console.Ex1
{
    public static class Collatz
    {
        /// <summary>
        /// Calculates the value that generates the largest Collatz set of a given range.
        /// </summary>
        /// <param name="begin">Range's initial number.</param>
        /// <param name="end">Range's final number.</param>
        /// <returns>Number that generates greater solution set.</returns>
        public static long CollatzMaxLengthInRange(int begin, int end)
        {
            Dictionary<long, long> buffer = new Dictionary<long, long>
            {
                { 1, 1 }
            };

            long maxLength = 0, maxNumber;
            int high, low;
            
            if (begin > end)//Sorts the input
            {
                high = begin;
                low = end;
            }
            else
            {
                high = end;
                low = begin;
            }

            maxNumber = low;

            for (int i = high; i >= low ; i--)//Starts with the largest number to better fill the buffer
            {
                long newMax;
                if ((newMax = BufferedRecursiveCollatzLength(i, buffer)) > maxLength)
                {
                    maxLength = newMax;
                    maxNumber = i;
                }
            }

            return maxNumber;
        }

        //Made recursive to facilitate storage of values in the middle of the process
        private static long BufferedRecursiveCollatzLength(long number, Dictionary<long, long> buffer)
        {
            if (buffer.ContainsKey(number))//Buffer used to store the values already calculated
            {
                return buffer[number];
            }
            else
            {
                long value = BufferedRecursiveCollatzLength((number % 2 == 0) ? (number / 2) : (3 * number) + 1, buffer) + 1;
                buffer.Add(number, value);//Stores the calculated values in the middle of the process for future use
                return value;
            }
        }
    }
}
