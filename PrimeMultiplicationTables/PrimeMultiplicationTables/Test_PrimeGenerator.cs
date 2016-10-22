using System;
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

        /// <summary>
        /// Check that the first two primes are 1 and 2.
        /// </summary>
        [Fact]
        public void GetTwoPrimes()
        {
            PrimeGenerator testGenerator = new PrimeGenerator();
            List<ulong> testList = new List<ulong>();
            testList.Add(1);
            testList.Add(2);
            Assert.Equal<List<ulong>>(testList, testGenerator.GetNPrimes(2));
        }

        /// <summary>
        /// Check that the List returned is the same size as the number of primes asked for.
        /// </summary>
        /// <param name="numberOfPrimes">The number of primes to be generated</param>
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(100)]
        public void SizeOfList(int numberOfPrimes)
        {
            PrimeGenerator testGenerator = new PrimeGenerator();
            Assert.Equal(numberOfPrimes, testGenerator.GetNPrimes(numberOfPrimes).Count);
        }


        /// <summary>
        /// Check that a negative number of primes returns an empty list
        /// </summary>
        /// <param name="numberOfPrimes"></param>
        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void NegativeSizedList(int numberOfPrimes)
        {
            PrimeGenerator testGenerator = new PrimeGenerator();
            Assert.Equal(0, testGenerator.GetNPrimes(numberOfPrimes).Count);
        }
    }
}
