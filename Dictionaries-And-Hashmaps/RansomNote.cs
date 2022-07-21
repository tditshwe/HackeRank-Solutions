using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsole
{
    class RansomNote
    {
        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            Dictionary<string, int> magWords = new Dictionary<string, int>();
            
            foreach (string str in magazine)
            {
                if (magWords.ContainsKey(str))
                    magWords[str] += 1;
                else
                    magWords.Add(str, 1);
            }
            
            foreach (string str in note)
            {
                if (magWords.ContainsKey(str))
                {
                    if (magWords[str] == 0)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                    
                    magWords[str] -= 1;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }                 
            }
            
            Console.WriteLine("Yes");
        }

        static void Main(string[] args)
        {
            List<string> mag = new() { "attack", "at", "dawn" },
                note = new() { "attack", "at", "dawn" };

            checkMagazine(mag, note);
        }
    }
}