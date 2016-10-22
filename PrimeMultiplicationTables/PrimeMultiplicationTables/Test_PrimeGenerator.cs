﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeMultiplicationTables
{
    /// <summary>
    /// Class for testing the prime generator class
    /// </summary>
    public class Test_PrimeGenerator
    {
        /// <summary>
        /// Check that the first prime is a list containing 1.
        /// </summary>
        [Fact]
        public void GetFirstPrime()
        {
            PrimeGenerator testGenerator = new PrimeGenerator();
            List<ulong> testList = new List<ulong>();
            testList.Add(1);
            Assert.Equal<List<ulong>>(testList, testGenerator.GetNPrimes(1));
        }

        
    }
}