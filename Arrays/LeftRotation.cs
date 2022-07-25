using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        public static List<int> rotLeft(List<int> a, int d)
        {
            int[] rotArr = new int[a.Count];


            for (int i = 0; i < a.Count; i++)
            {
                int r = a.Count - d % a.Count + i;

                if (r >= a.Count)
                    r %= a.Count;

                rotArr[r] = a[i];
            }

            return new List<int>(rotArr);
        }

        static void Main(string[] args)
        {
            List<int> arr = new() { 1, 2, 3, 4, 5 };

            Console.WriteLine(string.Join(", ", rotLeft(arr, 4)));
        }
    }
}
