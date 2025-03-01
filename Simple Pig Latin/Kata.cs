using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Pig_Latin
{
    internal class Kata
    {
        public static string PigIt(string str) => String.Join(" ", str.Split(' ').Select(ch => ch.Any(char.IsPunctuation) ? ch : ch[1..] + ch[0] + "ay"));
    }
}
