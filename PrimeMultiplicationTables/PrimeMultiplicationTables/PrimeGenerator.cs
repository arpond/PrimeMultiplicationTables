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
            if (numberOfPrimes <= 0)
            {
                return Primes;
            }

            switch (numberOfPrimes)
            {
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
                Primes.Add(GetNextPrime());
            }
            return Primes;
        }

        /// <summary>
        /// Calculates and returns the next prime in the list
        /// </summary>
        /// <returns>The next Prime that is not in the list of primes</returns>
        private ulong GetNextPrime()
        {
            var possiblePrime = Primes.Last<ulong>();
            ulong newPrime = 0;

            do
            {
                possiblePrime++;
                for(int indexOfPrime = 1; indexOfPrime < Primes.Count(); indexOfPrime++)
                {
                    var currentPrime = Primes[indexOfPrime];
                    if (currentPrime > Math.Sqrt(possiblePrime))
                    {
                        newPrime = possiblePrime;
                    }
                    if (possiblePrime % currentPrime == 0)
                    {
                        break;
                    }
                }

            } while (newPrime == 0);

            return newPrime;
        }
    }
}
