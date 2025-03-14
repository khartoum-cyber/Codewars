
internal class Kata
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();

        var newString = "";
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (var ch in word)
        {
            if (dict.ContainsKey(ch))
                dict[ch]++;
            else
                dict[ch] = 1;
        }

        foreach (var ch in word)
        {
            if (dict[ch] == 1)
                newString += "(";
            else
                newString += ")";
        }

        return newString;
    }
}
