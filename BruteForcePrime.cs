using System;
namespace PrimeNumber
{
	public class BruteForcePrime : PrimeAlgorithm
    {
		public BruteForcePrime() : base("Brute Force Prime Computation")
        {
		}

        /// <summary>
        /// Brute force simple school method. A simple solution is to iterate
        /// through all numbers from 2 to n-1 and for every number check if it
        /// divides n. If we find any number that divides, we return false. 
        /// </summary>
        /// <param name="uNum"></param>
        /// <returns>Boolean True if number is prime</returns>
        protected override bool IsPrime(uint number)
        {
            if (number <= 1)
                return false;

            if (number == 2 || number == 3)
                return true;

            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}

