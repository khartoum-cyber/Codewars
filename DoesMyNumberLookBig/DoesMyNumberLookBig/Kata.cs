namespace DoesMyNumberLookBig
{
    using System.Linq;

    internal class Kata
    {
        //convert input to string
        //get input length
        //
        public static bool Narcissistic(int value)
        {
            var stringInput = value.ToString();

            long result = stringInput.Sum(digit => (long)Math.Pow(digit - '0', stringInput.Length));

            return value == result;
        }
    }
}
