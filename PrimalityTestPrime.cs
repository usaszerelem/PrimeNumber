using System;

namespace PrimeNumber
{
	public class PrimalityTestPrime : PrimeAlgorithm
    {
		public PrimalityTestPrime() : base("Primality Test Prime", true)
        {
		}

        /// <summary>
        /// Time Complexity: O(√n)
        /// Auxiliary Space: O(1)
        /// Another approach: It is based on the fact that all primes greater than 3
        /// are of the form 6k ± 1, where k is any integer greater than 0. This is
        /// because all integers can be expressed as (6k + i), where i = −1, 0, 1,
        /// 2, 3, or 4. And note that 2 divides(6k + 0), (6k + 2), and(6k + 4) and 3
        /// divides(6k + 3). So, a more efficient method is to test whether n is
        /// divisible by 2 or 3, then to check through all numbers of the form
        /// 6k ± 1 <= √n.This is 3 times faster than testing all numbers up to √n.
        /// (Source: https://en.wikipedia.org/wiki/Primality_test).  
        /// </summary>
        /// <param name="uNum"></param>
        /// <returns>Boolean True if number is prime</returns>
        protected override bool IsPrime(uint number)
        {
            // since 2 and 3 are prime 
            if (number == 2 || number == 3)
                return true;

            // if n<=1 or divided by 2 or 3 then it can not be prime 
            if (number <= 1 || number % 2 == 0 || number % 3 == 0)
                return false;

            // To check through all numbers of the form 6k ± 1 
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}

