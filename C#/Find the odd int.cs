
internal class Kata
{
    public static int find_it(int[] seq)
    {
        return seq.GroupBy(n => n)
            .Where(g => g.Count() % 2 != 0)
            .Select(g => g.Key)
            .FirstOrDefault();
    }
}
