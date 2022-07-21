using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsole
{
    class SherlockAndAnagrams
    {
        public static string Sorted(string sub)
        {
            char[] subArr = sub.ToCharArray();
            Array.Sort(subArr);
            
            return new String(subArr);
        }

        public static int sherlockAndAnagrams(string s)
        {
            int pairs = 0;
            
            for (int len = 1; len <= s.Length - 1; len++) {
                for (int from = 0; from <= s.Length - len; from++)
                {
                    string sub1 = Sorted(s.Substring(from, len));
                    
                    for (int to = from + 1; to <= s.Length - len; to++)
                    {
                        string sub2 = Sorted(s.Substring(to, len));
                        
                        if (sub1 == sub2)
                            pairs++;
                    }
                }
            }
            
            return pairs;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(sherlockAndAnagrams("ifailuhkqq"));
        }
    }
}