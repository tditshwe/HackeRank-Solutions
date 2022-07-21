using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsole
{
    class FrequencyQueries
    {
        static List<int> freqQuery(List<List<int>> queries) {
            List<int> output = new List<int>();
            Dictionary<int, int> structList = new Dictionary<int, int>();

            foreach (var q in queries)
            {
                int op = q[1];
                
                switch (q[0])
                {
                    case 1:
                        if (structList.ContainsKey(op)) 
                            structList[op] += 1;
                        else
                            structList.Add(op, 1);
                        break;
                    case 2:
                        if (structList.ContainsKey(op) && structList[op] > 0)
                            structList[op] -= 1;
                        break;
                    case 3:                   
                        if (structList.ContainsValue(op))
                            output.Add(1);
                        else
                            output.Add(0);
                    
                        break;
                }
            }
            
            return output;
        }

        static void Main(string[] args)
        {
            List<List<int>> queries = new() { 
                new() { 1, 1 },
                new() { 2, 2 },
                new() { 3, 2 },
                new() { 1, 1 },
                new() { 1, 1 },
                new() { 2, 1 },
                new() { 3, 2 }
            };

            List<int> frequencies = freqQuery(queries);

            frequencies.ForEach(f =>
            {
                Console.WriteLine(f);
            });
        }
    }
}