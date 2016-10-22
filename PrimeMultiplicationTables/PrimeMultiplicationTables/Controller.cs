using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTables
{
    class Controller
    {
        /// <summary>
        /// Checks if the input is a valid number 
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns>Tuple of it's validity and the value itself(otherwise -1)</returns>
        public static Tuple<bool, int> ValidateInput(String input)
        {
            int number;
            if (!Int32.TryParse(input, out number) || number <= 0)
            {
                return new Tuple<bool, int>(false, -1);
            }
            else
            {
                return new Tuple<bool, int>(true, number);
            }
        }

        /// <summary>
        /// Generates a string representing the multiplication table for the number of values given
        /// </summary>
        /// <param name="numberOfValues">The number of values to generate the table with</param>
        /// <returns>String representation of the table</returns>
        public static String GenerateTableForNValues(int numberOfValues)
        {
            PrimeGenerator pg = new PrimeGenerator();
            MultiplicationTable mt = new MultiplicationTable();

            var primes = pg.GetNPrimes(numberOfValues);
            var stringTable = mt.CreateStringTable(primes);
            return stringTable;
        }
    }
}
