using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorSeiveofEratosthenes
{
    public static class Program
    {

        public static int Main()
        {
            var sieve = new SieveOfEratosthenes(10);
            var primes = sieve.Primes();

            foreach(var p in primes)
            {
                Console.Write($"{p}, ");
            }

            Console.ReadKey();

            return 0;
        }
    }


    public class SieveOfEratosthenes
    {
        private long MaxCandidateval; 
        
        public SieveOfEratosthenes(long limit)
        {
            MaxCandidateval = limit;
        }

        public IEnumerable<long> Primes()
        {
            long[] PossiblePrime = new long[MaxCandidateval];

            for (long n = 1; n <= MaxCandidateval; n++)
            {
                PossiblePrime[n-1] = n;

            }
            return PossiblePrime;
            
        }
    }
}



