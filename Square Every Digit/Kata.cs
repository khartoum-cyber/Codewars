using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Square_Every_Digit
{
    internal class Kata
    {
        public static int SquareDigits(int n) => Convert.ToInt32(n.ToString().Aggregate("", (current, x) => current + Math.Pow(int.Parse(x.ToString()), 2)));
    }
}