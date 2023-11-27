using System;
namespace PrimeNumber
{
	public class OoverNPrime : PrimeAlgorithm
    {
		public OoverNPrime() : base("O(n) time complexity")
        {
		}

        /// <summary>
        /// Time Complexity: O(N)
        /// Auxiliary Space: O(N) if we consider the recursion stack.Otherwise, it is O(1).
        /// Iterate through all numbers from 2 to ssquare root of n and for every
        /// number check if it divides n [because if a number is expressed as n = xy
        /// and any of the x or y is greater than the root of n, the other must be
        /// less than the root value]. If we find any number that divides, we return
        /// false.
        /// </summary>
        /// <param name="uNum"></param>
        /// <returns>Boolean True if number is prime</returns>
        protected override bool IsPrime(uint number)
        {
            if (number <= 1)
                return false;

            if (number == 2 || number == 3)
                return true;

            // Check from 2 to sqrt(n)
            for (int i = 2; i < Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}

