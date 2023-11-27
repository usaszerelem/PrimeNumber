using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeNumber
{
	public class RecursivePrime : PrimeAlgorithm
    {
		public RecursivePrime() : base("Slow Recursive Prime")
        {
		}

        /// <summary>
        /// Time Complexity: O(N)
        /// Auxiliary Space: O(1)
        /// Naive approach (recursive): Recursion can also be used to check if a
        /// number between 2 to n – 1 divides n. If we find any number that divides,
        /// we return false.
        /// </summary>
        /// <param name="uNum"></param>
        /// <returns>Boolean True if number is prime</returns>
        protected override bool IsPrime(uint number)
        {
            //Note that this is likely to crash as it runs out of stack space.
            return IsPrime_Recursive(2, number);
        }

        static bool IsPrime_Recursive(uint i, uint number)
        {
            if (number <= 1)
            {
                return false;
            }

            // Checking Prime
            if (number == i)
                return true;

            // base cases
            if (number % i == 0)
            {
                return false;
            }

            i++;

            return IsPrime_Recursive(i, number);
        }
    }
}
