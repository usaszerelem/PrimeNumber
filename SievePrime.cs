using System;

namespace PrimeNumber
{
    public class SievePrime : PrimeAlgorithm
    {
        public SievePrime() : base("Sieve Prime")
        {
        }

        // Uses the Sieve of Eratosthenes algorithm to determine whether the input
        // number is prime or not
        protected override bool IsPrime(uint number)
        {
            if (number <= 1)
                return false;

            // Create a boolean array "prime[0..number]" and initialize
            // all entries as true. A value in prime[i] will finally
            // be false if i is not a prime, else true.
            bool[] prime = new bool[number + 1];
            for (uint i = 2; i <= number; i++)
                prime[i] = true;

            for (uint p = 2; p * p <= number; p++)
            {
                // If prime[p] is not changed, then it is a prime
                if (prime[p] == true)
                {
                    // Update all multiples of p
                    for (uint i = p * p; i <= number; i += p)
                        prime[i] = false;
                }
            }

            // If prime[number] is true, then number is a prime
            return prime[number];
        }
    }
}
