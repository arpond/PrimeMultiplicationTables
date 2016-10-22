using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTables
{
    /// <summary>
    /// Class for generating prime numbers
    /// </summary>
    class PrimeGenerator
    {
        List<ulong> Primes;

        public PrimeGenerator()
        {
            Primes = new List<ulong>();
        }

        /// <summary>
        /// Get a list of N Primes
        /// </summary>
        /// <param name="numberOfPrimes">The number of Primes to get</param>
        /// <returns>The first N Primes</returns>
        public List<ulong> GetNPrimes(int numberOfPrimes)
        {
            switch (numberOfPrimes)
            {
                case 0:
                    return Primes;
                case 1:
                    Primes.Add(1);
                    return Primes;
                case 2:
                    Primes.Add(1);
                    Primes.Add(2);
                    return Primes;
                default:
                    Primes.Add(1);
                    Primes.Add(2);
                    break;
            }

            for (int currPrime = 3; currPrime <= numberOfPrimes; currPrime++)
            {
                Primes.Add(0);
            }
            return Primes;
        }
    }
}
