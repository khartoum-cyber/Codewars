using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Replace_all_vowel_to_exclamation_mark
{
    internal static class Kata
    {
        public static string Replace(string s)
        {
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            var newString = "";

            foreach (var ch in s)
            {
                if (!vowels.Contains(ch))
                {
                    newString += ch;
                }
                else
                {
                    newString += '!';
                }
            }

            return newString;

        } /*=> Regex.Replace(s, "[aeiou]", "!", RegexOptions.IgnoreCase);*/
    }
}