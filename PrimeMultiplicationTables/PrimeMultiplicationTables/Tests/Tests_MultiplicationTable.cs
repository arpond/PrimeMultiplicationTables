﻿using System;
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

        [Fact]
        public void EmptyStringTable()
        {
            MultiplicationTable testTable = new MultiplicationTable();
            Assert.Equal("", testTable.CreateStringTable(new List<ulong>()));
        }
    }
}
