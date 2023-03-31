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
        public static void Que2LowerCase()
        {
            string regex = "^[a-z]+_[a-z]$";
            string[] inputs = { "aa_b", "abb_b", "A_ab", "Aa_Bb", "a_b" };
            RegexPattern(inputs, regex);
        }
        public static void Que3ImageFormat()
        {
            string regex = @"([^\s]+(\.(?i)(jpg|png|pdf))$)";// \\s-string must be contain at least one character,(?i) = string ignore the case-sensitive.
            string[] inputs = { "abc.png", "im.jpg", ".gif", "abc.mp3", " .jpg","rsp.pdf" };
            RegexPattern(inputs, regex);
        }
        public static void Que4HTMLTags()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>”";
            string pattern = @"<[^>]+>";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
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
