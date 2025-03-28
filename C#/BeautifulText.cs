
internal class Kata
{
    public bool BeautifulText(string s, int l, int r)
    {
        string[] arr = s.Split();

        for (int i = l; i <= r; i++)
        {
            Queue<string> q = new Queue<string>(arr);
            List<string> lines = new List<string>();

            while (q.Count > 0)
            {
                string line = "";

                while (line.Length < i && q.Count > 0)
                {
                    string word = q.Dequeue();

                    if (!string.IsNullOrEmpty(line))
                        line += " ";

                    line += word;
                }

                lines.Add(line);

                if (line.Length != i)
                    break;
            }

            if (lines.All(line => line.Length == i))
                return true;
        }

        return false;
    }
}
