using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsole
{
    class MinimumSwaps
    {
        static int minimumSwaps(int[] arr) {
            List <KeyValuePair <int, int> > arrValPair = 
                new List <KeyValuePair <int, int>>();
            int n = arr.Length, swaps = 0;
            bool[] visited = new bool[n];
                
            for (int i = 0; i < n; i++)
                arrValPair.Add(new KeyValuePair <int, int> (arr[i], i));
                
            arrValPair.Sort((a,b)=> a.Key-b.Key);
            
            for (int i = 0; i < n; i++)
            {
                if (visited[i] || arrValPair[i].Value == i)
                    continue;
        
                int cycles = 0;
                int j = i;
                
                while (!visited[j])
                {
                    visited[j] = true;
            
                    j = arrValPair[j].Value;
                    cycles++;
                }
        
                if (cycles > 0)
                    swaps += (cycles - 1);
            }
            
            return swaps;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 1, 3, 2, 4, 5, 6 };

            Console.WriteLine(minimumSwaps(arr));
        }
    }
}