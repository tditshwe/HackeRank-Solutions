using System;
using System.Collections.Generic;

namespace MyConsole
{
    class Program
    {
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            long[] zeroes = new long[n];
            long tot = 0, max = 0;

            foreach (var q in queries)
            {
                zeroes[q[0] - 1] += q[2];

                if (q[1] < n)
                    zeroes[q[1]] -= q[2];

            }

            for (int i = 0; i < n; i++)
            {
                tot += zeroes[i];
                max = tot > max ? tot : max;
            }

            return max;
        }

        static void Main(string[] args)
        {
            List<List<int>> queries = new()
            {
                new() { 1, 2, 100 },
                new() { 2, 5, 100 },
                new() { 3, 4, 100 }
            };

            Console.WriteLine(arrayManipulation(5, queries));
        }
    }
}
