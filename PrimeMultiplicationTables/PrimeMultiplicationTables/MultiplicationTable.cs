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
            String stringTable = "";

            if (toMultiply.Count == 0)
            {
                return stringTable;
            }

            var results = CreateMultiplicationTable(toMultiply);
            stringTable = formatTable(toMultiply, results);

            return stringTable;
        }

        /// <summary>
        /// Formats a table
        /// </summary>
        /// <param name="headers">The headers for the table</param>
        /// <param name="results">The table results</param>
        /// <returns></returns>
        private String formatTable(List<ulong> headers, List<List<ulong>> results)
        {
            int numberOfValues = headers.Count;

            for (int rowNumber = 0; rowNumber < numberOfValues; rowNumber++)
            {
                results[rowNumber].Insert(0, headers[rowNumber]);
            }

            String formatedTable = "|\t" + formatRow(headers);

            for (int row = 0; row < numberOfValues; row++)
            {
                var currentRow = results[row];
                formatedTable += formatRow(currentRow);
            }

            return formatedTable;
        }

        /// <summary>
        /// Formats a single row
        /// </summary>
        /// <param name="row">Row to be formated</param>
        /// <returns></returns>
        private String formatRow(List<ulong> row)
        {
            String formatedRow = "|\t" + string.Join("|\t", row.ToArray()) + "|\n";
            return formatedRow;
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
