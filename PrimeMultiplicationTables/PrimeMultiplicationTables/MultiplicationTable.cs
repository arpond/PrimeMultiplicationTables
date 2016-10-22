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
        /// Creates a multiplication table of the values passed
        /// </summary>
        /// <param name="toMultiply">The values to multiply</param>
        /// <returns></returns>
        public List<List<ulong>> CreateMultiplicationTable(List<ulong> toMultiply)
        {
            var multiplicationTable = new List<List<ulong>>();
            var numberOfValues = toMultiply.Count;

            for (int row = 0; row < numberOfValues; row++)
            {
                var zeroedRow = new List<ulong>(new ulong[numberOfValues]);
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
