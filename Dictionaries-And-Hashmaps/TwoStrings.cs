using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsole
{
    class TwoStrings
    {
        public static string twoStrings(string s1, string s2)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            
            foreach (char c in s1)
            {
                if (!chars.ContainsKey(c))
                    chars.Add(c, 1);
            }
            
            foreach (char c in s2)
            {
                if (chars.ContainsKey(c))
                    return "YES";
            }
            
            return "NO";
        }

        static void Main(string[] args)
        {
            string s1 = "hello", s2 = "world";

            Console.WriteLine(twoStrings(s1, s2));
        }
    }
}