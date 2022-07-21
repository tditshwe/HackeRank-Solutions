using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsole
{
    class CountTriplets
    {
        static long countTriplets(List<long> arr, long r) {
            Dictionary<long, long> numDict = new Dictionary<long, long>(),
                countDict = new Dictionary<long, long>();
            long triplets = 0;
            
            for (int i = 0; i < arr.Count; i++)
            {
                long div = arr[i] / r;
                
                if (countDict.ContainsKey(div) && arr[i] % r == 0)
                    triplets += countDict[div];
                    
                if (numDict.ContainsKey(div) && arr[i] % r == 0) {
                    if (countDict.ContainsKey(arr[i]))
                        countDict[arr[i]] += numDict[div];
                    else
                        countDict.Add(arr[i], numDict[div]);
                }
                
                if (numDict.ContainsKey(arr[i]))
                    numDict[arr[i]] += 1;
                else
                    numDict.Add(arr[i], 1);
            }
            
            return triplets;
        }

        static void Main(string[] args)
        {
            List<long> arr = new() { 1, 3, 9, 9, 27, 81};

           Console.WriteLine(countTriplets(arr, 3));
        }
    }
}