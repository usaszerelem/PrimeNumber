using System.Collections.Specialized;
using System.Diagnostics;

namespace PrimeNumber
{
	public class MillerRabinPrime : PrimeAlgorithm
    {
        public MillerRabinPrime() : base("Miller-Rabin")
        {
        }

        /// <summary>
        /// This function uses a deterministic version of the Miller-Rabin primality
        /// test, which efficiently checks whether a given number is prime.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        protected override bool IsPrime(uint number)
        {
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            // Check if the number is divisible by 2 or 3
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            int k = 5;
            while (k * k <= number)
            {
                if (number % k == 0 || number % (k + 2) == 0)
                    return false;
                k += 6;
            }

            return true;
        }
    }
}
