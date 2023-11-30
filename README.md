# PrimeNumber

PrimeNumber is a project to evaluate the performance of various prime number calculation algorithms written in C#.

With C++ 32-bit the performance is 2x of these numbers\
With C++ 64-bit the performance is 3x of these numbers

## Installation

To build this project Visual Studio for Mac was used. In total there are 8 prime number algorithms out of which 3 are commented out due to extremely poor performance with large numbers.
The performance numbers of the remaining 5 algorithms are as follows:

Algorithm Name: **Textbook Large Prime Rules**\
Elapsed time to compute first 100 numbers: 00:00:00.0002091\
Elapsed time to compute first 1000 numbers: 00:00:00.0000194\
Elapsed time to compute first 10000 numbers: 00:00:00.0001732\
Elapsed time to compute first 100000 numbers: 00:00:00.0026653\
Elapsed time to compute first 1000000 numbers: 00:00:00.0522971\
Elapsed time to compute first 10000000 numbers: 00:00:01.2028524

Algorithm Name: **Miller-Rabin**\
Elapsed time to compute first 100 numbers: 00:00:00.0000936\
Elapsed time to compute first 1000 numbers: 00:00:00.0000124\
Elapsed time to compute first 10000 numbers: 00:00:00.0001330\
Elapsed time to compute first 100000 numbers: 00:00:00.0020180\
Elapsed time to compute first 1000000 numbers: 00:00:00.0385992\
Elapsed time to compute first 10000000 numbers: 00:00:00.8614289

Algorithm Name: **Fermat Prime**\
Elapsed time to compute first 100 numbers: 00:00:00.0004196\
Elapsed time to compute first 1000 numbers: 00:00:00.0004382\
Elapsed time to compute first 10000 numbers: 00:00:00.0044553\
Elapsed time to compute first 100000 numbers: 00:00:00.0437330\
Elapsed time to compute first 1000000 numbers: 00:00:00.4233037\
Elapsed time to compute first 10000000 numbers: 00:00:04.4346076

Algorithm Name: **O(n) time complexity**\
Elapsed time to compute first 100 numbers: 00:00:00.0001957\
Elapsed time to compute first 1000 numbers: 00:00:00.0000284\
Elapsed time to compute first 10000 numbers: 00:00:00.0004326\
Elapsed time to compute first 100000 numbers: 00:00:00.0084800\
Elapsed time to compute first 1000000 numbers: 00:00:00.1851462\
Elapsed time to compute first 10000000 numbers: 00:00:04.6511019

Algorithm Name: **Primality Test Prime**\
Elapsed time to compute first 100 numbers: 00:00:00.0001666\
Elapsed time to compute first 1000 numbers: 00:00:00.0000137\
Elapsed time to compute first 10000 numbers: 00:00:00.0001499\
Elapsed time to compute first 100000 numbers: 00:00:00.0023587\
Elapsed time to compute first 1000000 numbers: 00:00:00.0407939\
Elapsed time to compute first 10000000 numbers: 00:00:00.8754322

## Contributing

Various sources in the Internet such as Forums and Wikipedia was used to obtain the various prime number calculation algorithms.

## License

[MIT](https://choosealicense.com/licenses/mit/)
