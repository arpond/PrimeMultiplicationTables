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
        /// <returns>A String representing the table with headers</returns>
        public String CreateStringTable(List<ulong> toMultiply)
        {
            String stringTable = "";

            if (toMultiply.Count == 0)
            {
                return stringTable;
            }

            var results = CreateMultiplicationTable(toMultiply);
            stringTable = FormatTable(toMultiply, results);

            return stringTable;
        }

        /// <summary>
        /// Formats a table
        /// </summary>
        /// <param name="headers">The headers for the table</param>
        /// <param name="results">The table results</param>
        /// <returns>A formated table with the headers and results specified</returns>
        private String FormatTable(List<ulong> headers, List<List<ulong>> results)
        {
            int numberOfValues = headers.Count;

            for (int rowNumber = 0; rowNumber < numberOfValues; rowNumber++)
            {
                results[rowNumber].Insert(0, headers[rowNumber]);
            }

            ulong largestResult = results[numberOfValues - 1][numberOfValues - 1];
            int maxSize = largestResult.ToString().Length;

            String formatedTable = "|";
            formatedTable = formatedTable.PadRight(maxSize + 3);
            formatedTable += FormatRow(headers, maxSize);

            for (int row = 0; row < numberOfValues; row++)
            {
                var currentRow = results[row];
                formatedTable += FormatRow(currentRow, maxSize);
            }

            return formatedTable;
        }

        /// <summary>
        /// Formats a single row
        /// </summary>
        /// <param name="row">Row to be formated</param>
        /// <returns>A single formated row</returns>
        private String FormatRow(List<ulong> row, int columnWidth)
        {
            String formatedRow = String.Concat(row.Select(value => String.Format("| {0," + columnWidth + "} ", value))) + "|\n";
            return formatedRow;
        }

        /// <summary>
        /// Creates a multiplication table of the values passed
        /// </summary>
        /// <param name="toMultiply">The values to multiply</param>
        /// <returns>The results of the multiplication as a list of lists</returns>
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
