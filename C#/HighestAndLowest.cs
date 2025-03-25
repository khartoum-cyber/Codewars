
internal class Kata
{
    public static string HighAndLow(string numbers)
    {
        var numberList = numbers.Split(' ').Select(int.Parse).ToList();
        return $"{numberList.Max()} {numberList.Min()}";
    }
}
