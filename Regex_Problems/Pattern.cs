using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Problems
{
    internal class Pattern
    {
        public static void Que1()
        {
            string regex = "^[a]{1}[b]{2,3}$";
            string[] inputs = { "ab", "abb", "aab", "abbb" ,"a" };
            RegexPattern(inputs, regex);
        }

        public static void RegexPattern(string[] inputs, string regex)
        {
            foreach(string s in inputs)
            {
                if ( Regex.IsMatch(s, regex) )
                {
                    Console.WriteLine("{0} is valid" , s);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid" , s);
                }
            }
        }
    }
}
