using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Say_Me_Please_Operations
{
    internal class Kata
    {
        public static string sayMeOperations(string stringNumbers)
        {
            var numArray = stringNumbers.Split(' ');
            var returnList = new List<string>();

            for (int i = 0; i < numArray.Length - 2; i++)
            {
                if (int.Parse(numArray[i]) + int.Parse(numArray[i + 1]) == int.Parse(numArray[i + 2]))
                    returnList.Add("addition");
                else if (int.Parse(numArray[i]) - int.Parse(numArray[i + 1]) == int.Parse(numArray[i + 2]))
                    returnList.Add("subtraction");
                else if (int.Parse(numArray[i]) * int.Parse(numArray[i + 1]) == int.Parse(numArray[i + 2]))
                    returnList.Add("multiplication");
                else if (int.Parse(numArray[i]) / int.Parse(numArray[i + 1]) == int.Parse(numArray[i + 2]))
                    returnList.Add("division");
            }

            return string.Join(", ", returnList);
        }

        public static string Disemvowel(string str)
        {
            //var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            //var newString = "";

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (!vowels.Contains(str[i]))
            //    {
            //        newString += str[i];
            //    }
            //}

            //return newString;

            return Regex.Replace(str, "[aeiouAEIOU]", "");
        }
    }
}
