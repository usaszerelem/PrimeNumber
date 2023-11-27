using System;

namespace PrimeNumber
{
    public class FermatPrime : PrimeAlgorithm
    {
        public FermatPrime() : base("Fermat Prime")
        {
        }

        /// <summary>
        /// This method is a probabilistic method and is based on Fermat’s Little Theorem.
        /// If n is a prime number, then for every a, 1 < a < n-1,
        /// 
        ///   n-1 ? 1 (mod n)
        /// a 
        /// OR
        ///   n-1 % n = 1
        /// a
        /// If a given number is prime, then this method always returns true. If the
        /// given number is composite (or non-prime), then it may return true or
        /// false, but the probability of producing incorrect results for composite
        /// is low and can be reduced by doing more iterations.
        /// Below is algorithm: 
        /// // Higher value of k indicates probability of correct
        /// results for composite inputs become higher. For prime inputs, result is
        /// always correct
        /// 1)  Repeat following k times:
        ///   a) Pick a randomly in the range[2, n - 2]
        ///   b) If gcd(a, n) ? 1, then return false
        ///   c) If an-1 &nequiv; 1 (mod n), then return false
        /// 2) Return true [probably prime].
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        protected override bool IsPrime(uint n)
        {
            uint k = 2;

            // Corner cases
            if (n <= 1 || n == 4) return false;
            if (n <= 3) return true;

            // Try k times
            while (k > 0)
            {
                // Pick a random number in [2..n-2]     
                // Above corner cases make sure that n > 4
                Random rand = new Random();
                uint a = 2 + (uint)(rand.Next() % (n - 4));

                // Fermat's little theorem
                if (power(a, n - 1, n) != 1)
                    return false;

                k--;
            }

            return true;
        }

        // Iterative Function to calculate (a^n)%p in O(logy)
        static uint power(uint a, uint n, uint p)
        {
            uint res = 1;      // Initialize result
            a = a % p;  // Update 'a' if 'a' >= p

            while (n > 0)
            {
                // If n is odd, multiply 'a' with result
                if ((n & 1) == 1)
                    res = (res * a) % p;

                // n must be even now
                n = n >> 1; // n = n/2
                a = (a * a) % p;
            }
            return res;
        }

        // Recursive function to calculate Greatest Common Divisor of 2 numbers
        static uint gcd(uint a, uint b)
        {
            if (a < b)
                return gcd(b, a);
            else if (a % b == 0)
                return b;
            else
                return gcd(b, a % b);
        }
    }
}
