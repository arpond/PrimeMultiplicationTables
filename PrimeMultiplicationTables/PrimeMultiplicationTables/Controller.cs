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
            if (Int32.TryParse(input, out number))
            {
                return new Tuple<bool, int>(true, number); 
            }
            else
            {
                return new Tuple<bool, int>(false, -1);
            }
        }
    }
}
