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
        /// The empty list should return an empty table
        /// </summary>
        [Fact]
        public void EmptyList()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            Assert.Equal(new List<List<ulong>>(), testTable.CreateMultiplicationTable(new List<ulong>()));
        }

        /// <summary>
        /// Check that the result of a list containing just the number two returns a table with the result 4.
        /// </summary>
        [Fact]
        public void SingleObjectMultiplicationList()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            List<ulong> testList = new List<ulong>();
            testList.Add(2);

            var resultList = new List<List<ulong>>();
            resultList.Add(new List<ulong>());
            resultList[0].Add(4);
            Assert.Equal(resultList, testTable.CreateMultiplicationTable(testList));
        }

        /// <summary>
        /// Check that the result of a list containing the numbers 2 and 3 returns the correct table.
        /// </summary>
        [Fact]
        public void MultipleObjectMultiplicationList()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            List<ulong> testList = new List<ulong>();
            testList.Add(2);
            testList.Add(3);

            var resultList = new List<List<ulong>>();
            resultList.Add(new List<ulong>());
            resultList.Add(new List<ulong>());
            resultList[0].Add(4);
            resultList[0].Add(6);
            resultList[1].Add(6);
            resultList[1].Add(9);
            Assert.Equal(resultList, testTable.CreateMultiplicationTable(testList));
        }

        /// <summary>
        /// Check that an empty list returns an empty string
        /// </summary>
        [Fact]
        public void EmptyStringTable()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            Assert.Equal("", testTable.CreateStringTable(new List<ulong>()));
        }

        /// <summary>
        /// Check that a list of a single item returns the correct string for the table
        /// </summary>
        [Fact]
        public void SingleObjectStringTable()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            List<ulong> testList = new List<ulong>();
            testList.Add(2);
            Assert.Equal("|   | 2 |\n| 2 | 4 |\n", testTable.CreateStringTable(testList));
        }

        /// <summary>
        /// Check that a list of multiple items returns the correct string for the table
        /// </summary>
        [Fact]
        public void MultipleObjectStringTable()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            List<ulong> testList = new List<ulong>();
            testList.Add(2);
            testList.Add(3);
            Assert.Equal("|   | 2 | 3 |\n| 2 | 4 | 6 |\n| 3 | 6 | 9 |\n", testTable.CreateStringTable(testList));
        }

        /// <summary>
        /// Check that a list of items returns the correct string for the table 
        /// where an item in the results is one digit larger than rest.
        /// </summary>
        [Fact]
        public void OneObjectLargerStringTable()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            List<ulong> testList = new List<ulong>();
            testList.Add(2);
            testList.Add(4);
            Assert.Equal("|    |  2 |  4 |\n|  2 |  4 |  8 |\n|  4 |  8 | 16 |\n", testTable.CreateStringTable(testList));
        }

        /// <summary>
        /// Check that a list of items returns the correct string for the table 
        /// where an item in the results is one digit larger than rest.
        /// </summary>
        [Fact]
        public void OneObjectLargerStringTable2()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            List<ulong> testList = new List<ulong>();
            testList.Add(4);
            testList.Add(2);
            Assert.Equal("|    |  4 |  2 |\n|  4 | 16 |  8 |\n|  2 |  8 |  4 |\n", testTable.CreateStringTable(testList));
        }
    }
}
