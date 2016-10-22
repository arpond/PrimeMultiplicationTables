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
        static List<ulong> Primes;

        static PrimeGenerator()
        {
            Primes = new List<ulong>();
        }


        public static List<ulong> GetNPrimes(int numberOfPrimes)
        {
            Primes.Add(1);
            return Primes;
        }
    }
}
