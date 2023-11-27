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
            new FermatPrime(),
            new OoverNPrime(),
            new PrimalityTestPrime()
            // new SievePrime(), Commenting out as it is too slow
            // new RecursivePrime(), Commenting out as it exhausts the stack
            // new BruteForcePrime(), Way too slow with large numbers            
        };

        Console.WriteLine("Prime Algorithm Performance Measurements in C#");
        Console.WriteLine("With C++ 32-bit the performance is 2x of these numbers");
        Console.WriteLine("With C++ 64-bit the performance is 3x of these numbers\n");

        uint[] uLimit = { 100, 1000, 10000, 100000, 1000000, 10000000};

        foreach(PrimeAlgorithm prime in primeAlgorithms)
        {
            Console.WriteLine("Algorithm Name: {0}", prime.AlgorithmName);

            var stats = prime.StartComputation(uLimit);

            foreach (var stat in stats)
            {
                if (stat.Value == null)
                    Console.WriteLine("Error happened computing first {0} numbers.", stat.Key);
                else
                    Console.WriteLine("Elapse time to compute first {0} numbers: {1}", stat.Key, stat.Value.elapsed);
            }

            Console.WriteLine();
        }

        Console.WriteLine("Done");
        Console.ReadKey();
    }
}