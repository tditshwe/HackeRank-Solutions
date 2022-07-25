using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsole
{
    class NewYearChaos
    {
        public static void minimumBribes(List<int> q)
        {        
            int count, bribes = 0;
            bool chaotic = false;        
            
            for (count = 0; count < q.Count; count++)
            {
                int pos = q[count], start;
                
                if (q[count] - 2 > 0)
                    start = q[count] - 2;
                else
                    start = 0;
                    
                for (int i = start; i < count; i++)
                    if (q[i] > pos)
                        bribes++;
                                
                if (pos - (count + 1) > 2)
                    chaotic = true;                
            }
                
            if (chaotic)
                Console.WriteLine("Too chaotic");
            else
                Console.WriteLine(bribes);
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 2, 1, 5, 3, 4 };

            minimumBribes(arr);
        }
    }
}