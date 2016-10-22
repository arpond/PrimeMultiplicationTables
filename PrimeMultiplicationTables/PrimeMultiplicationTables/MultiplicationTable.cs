using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTables
{
    class MultiplicationTable
    {

        public List<List<ulong>> CreateMultiplicationTable(List<ulong> toMultiply)
        {
            var multiplicationTable = new List<List<ulong>>(toMultiply.Count);

            if (toMultiply.Count == 0)
            {
                return multiplicationTable;
            }
            return multiplicationTable;
        }
    }
}
