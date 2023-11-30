using System;
using System.Collections.Specialized;
using System.Diagnostics;

namespace PrimeNumber
{
	public abstract class PrimeAlgorithm
	{
        private Stopwatch stopwatch = new Stopwatch();
        
        public PrimeAlgorithm(string algorithmName, bool isFast)
		{
            AlgorithmName = algorithmName;
            IsFast = isFast;
        }

        public string AlgorithmName
        {
            get;
            private set;
        }

        public bool IsFast
        {
            get;
            private set;
        }

        public Tuple<uint[], TimeSpan> FindAllPrimes(uint uUpperLimit)
        {
            List<uint> uPrimeNumbers = new List<uint>();

            stopwatch.Reset();
            stopwatch.Start();

            for (uint uOneNumber = 0; uOneNumber <= uUpperLimit; uOneNumber++)
            {
                if (IsPrime(uOneNumber) == true)
                {
                    uPrimeNumbers.Add(uOneNumber);
                }
            }

            stopwatch.Stop();

            return Tuple.Create(uPrimeNumbers.ToArray(), stopwatch.Elapsed);
        }

        abstract protected bool IsPrime(uint number);
    }
}
