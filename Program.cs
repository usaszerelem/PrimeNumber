using System.Buffers.Text;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static PrimeNumber.PrimeAlgorithm;

namespace PrimeNumber;

partial class Program
{
    static void Main(string[] args)
    {
        PrimeAlgorithm[] primeAlgorithms =
        {
            new PrimeRuleLargeNum(),
            new MillerRabinPrime(),
            new PrimalityTestPrime(),
            new BruteForcePrime(),
            new SievePrime(),
            new RecursivePrime()
        };

        Console.WriteLine("Prime Algorithm Performance Measurements in C#");
        Console.WriteLine("With C++ 32-bit the performance is 2x of these numbers");
        Console.WriteLine("With C++ 64-bit the performance is 3x of these numbers\n");

        Tuple<uint, uint>[] primeLimitsArr = new Tuple<uint, uint>[]
        {
            Tuple.Create<uint, uint>(100, 25),
            Tuple.Create<uint, uint>(1000, 168),
            Tuple.Create<uint, uint>(10000, 1229),
            Tuple.Create<uint, uint>(100000, 9592),
            Tuple.Create<uint, uint>(1000000, 78498),
            Tuple.Create<uint, uint>(10000000, 664579)
        };

        foreach(PrimeAlgorithm prime in primeAlgorithms)
        {
            Console.WriteLine("Algorithm Name: {0} ({1})", prime.AlgorithmName, prime.IsFast ? "FAST" : "SLOW");

            int NumLimitRuns = prime.IsFast == true ? primeLimitsArr.Count() : 4;

            for (int runCount = 0; runCount < NumLimitRuns; runCount++)
            {
                Tuple<uint[], TimeSpan> ret = prime.FindAllPrimes(primeLimitsArr[runCount].Item1);

                if (ret.Item1.Count() != primeLimitsArr[runCount].Item2)
                {
                    Console.WriteLine("Error - Algorithm found {0} prime numbers. " +
                        "Expected: {1}", ret.Item1.Count(), primeLimitsArr[runCount].Item2);
                }
                else
                {
                    Console.WriteLine("Elapsed time to compute first {0} numbers: {1}",
                        primeLimitsArr[runCount].Item1, ret.Item2);
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine("Done");
        Console.ReadKey();
    }
}
