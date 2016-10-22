using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeMultiplicationTables.Tests
{
    public class Tests_MultiplicationTable
    {
        /// <summary>
        /// The empty list should return an empty String
        /// </summary>
        [Fact]
        public void EmptyList()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            Assert.Equal("", testTable.CreateStringTable(new List<ulong>()));
        }
    }
}
