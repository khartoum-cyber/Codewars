namespace Reverse_String
{
    internal class Kata
    {
        public static string Solution(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }
    }
}
