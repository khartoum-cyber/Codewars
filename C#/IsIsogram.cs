
internal class Kata
{
    public static bool IsIsogram(string str) =>
        str.Where(char.IsLetter).GroupBy(char.ToLower).All(ch => ch.Count() == 1);
}
