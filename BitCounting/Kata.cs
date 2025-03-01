using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    internal class Kata
    {
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
