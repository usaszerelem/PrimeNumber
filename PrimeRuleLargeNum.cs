using System;
namespace PrimeNumber
{
	public class PrimeRuleLargeNum : PrimeAlgorithm
    {
		public PrimeRuleLargeNum() : base("Textbook Large Prime Rules")
        {
		}

        /// <summary>
        /// Time Complexity: O(sqrt(n))
        /// Auxiliary space: O(1)
        /// We will deal with a few numbers such as 1, 2, 3, and the numbers which
        /// are divisible by 2 and 3 in separate cases and for remaining numbers.
        /// Iterate from 5 to sqrt(n) and check for each iteration whether (that
        /// value) or (that value + 2) divides n or not and increment the value by 6
        /// [because any prime can be expressed as 6n+1 or 6n-1]. If we find any
        /// number that divides, we return false.
        /// </summary>
        /// <param name="uNum"></param>
        /// <returns>Boolean True if number is prime</returns>
        protected override bool IsPrime(uint number)
        {
            if (number <= 1)
                return false;

            if (number == 2 || number == 3)
                return true;

            // // Check whether n is divisible by 2 or 3
            if ((number % 2) == 0 || (number % 3) == 0)
                return false;

            // Check from 5 to square root of n
            // Iterate i by (i+6)
            for (int i = 5; i <= Math.Sqrt(number); i += 6)
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;

            return true;
        }
    }
}
