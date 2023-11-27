using System;
using System.Collections.Specialized;
using System.Diagnostics;

namespace PrimeNumber
{
	public abstract class PrimeAlgorithm
	{
        public class Statistics
        {
            public Statistics()
            {
                uNumPrime = 0;
                elapsed = TimeSpan.MinValue;
            }

            public uint uNumPrime;
            public TimeSpan elapsed;
        }

        private Stopwatch stopwatch = new Stopwatch();
        
        public PrimeAlgorithm(string algorithmName)
		{
            AlgorithmName = algorithmName;
        }

        public string AlgorithmName
        {
            get;
            private set;
        }

        public List<KeyValuePair<uint, Statistics?>> StartComputation(uint[] uNumbers)
        {
            uint uMaxLimit = 0;
            var stats = new List<KeyValuePair<uint, Statistics?>>();

            try
            {
                for (uint uNumIdx = 0; uNumIdx < uNumbers.Count(); uNumIdx++)
                {
                    stopwatch.Reset();
                    stopwatch.Start();
                    Statistics primeStats = new Statistics();
                    uMaxLimit = uNumbers[uNumIdx];

                    Console.WriteLine("Computing the first {0} prime numbers...", uMaxLimit);

                    for (uint uOneNumber = 0; uOneNumber <= uMaxLimit; uOneNumber++)
                    {
                        if (IsPrime(uOneNumber) == true)
                        {
                            primeStats.uNumPrime++;
                        }
                    }

                    stopwatch.Stop();
                    primeStats.elapsed = stopwatch.Elapsed;
                    stats.Add(new KeyValuePair<uint, Statistics?>(uMaxLimit, primeStats));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                stats.Add(new KeyValuePair<uint, Statistics?>(uMaxLimit, null));
            }

            return stats;
        }

        abstract protected bool IsPrime(uint number);
    }
}
