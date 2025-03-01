using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detect_Pangram
{
    internal class Kata
    {
        public static bool IsPangram(string str)
        {
            //string pangram = "The quick brown fox jumps over the lazy dog";

            return str.ToLower().Where(char.IsLetter).Distinct().Count() == 26;
        }
    }
}
