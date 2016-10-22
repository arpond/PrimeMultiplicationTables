using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTables
{
    class MultiplicationTable
    {
        /// <summary>
        /// Creates a String multiplication table based on the list of values passed
        /// </summary>
        /// <param name="toMultiply">List of values to multiply</param>
        /// <returns></returns>
        public String CreateStringTable(List<ulong> toMultiply)
        {
            int numberOfValues = toMultiply.Count;
            String stringTable = "";

            if (numberOfValues == 0)
            {
                return stringTable;
            }

            var multiplicationTable = CreateMultiplicationTable(toMultiply);
            List<ulong> headers = toMultiply;

            for (int rowNumber = 0; rowNumber < numberOfValues; rowNumber++)
            {
                multiplicationTable[rowNumber].Insert(0, headers[rowNumber]);
            }

            stringTable = "|\t|\t" + string.Join("|\t", toMultiply.ToArray()) + "|\n";

            for(int row = 0; row < numberOfValues; row++)
            {
                var currentRow = multiplicationTable[row];
                stringTable += "|\t" + string.Join("|\t",currentRow.ToArray()) + "|\n";
            }

            return stringTable;
        }

        /// <summary>
        /// Creates a multiplication table of the values passed
        /// </summary>
        /// <param name="toMultiply">The values to multiply</param>
        /// <returns></returns>
        internal List<List<ulong>> CreateMultiplicationTable(List<ulong> toMultiply)
        {
            var multiplicationTable = new List<List<ulong>>();
            var numberOfValues = toMultiply.Count;
            List<ulong> zeroedRow;

            for (int row = 0; row < numberOfValues; row++)
            {
                zeroedRow = new List<ulong>(new ulong[numberOfValues]);
                multiplicationTable.Add(zeroedRow);
            }

            for (int row = 0; row < numberOfValues; row++)
            {
                for (int column = 0; column < numberOfValues; column++)
                {
                    multiplicationTable[row][column] = toMultiply[row] * toMultiply[column];
                }
            }
            return multiplicationTable;
        }
    }
}
