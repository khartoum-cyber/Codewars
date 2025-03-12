
internal class Kata
{
    public int IsSolved(int[,] board)
    {
        bool zeroFound = false;
        List<int[]> lines = new List<int[]>();

        lines.Add(new int[3] { board[0, 0], board[1, 0], board[2, 0] });
        lines.Add(new int[3] { board[0, 1], board[1, 1], board[2, 1] });
        lines.Add(new int[3] { board[0, 2], board[1, 2], board[2, 2] });
        lines.Add(new int[3] { board[0, 0], board[0, 1], board[0, 2] });
        lines.Add(new int[3] { board[1, 0], board[1, 1], board[1, 2] });
        lines.Add(new int[3] { board[2, 0], board[2, 1], board[2, 2] });
        lines.Add(new int[3] { board[0, 0], board[1, 1], board[2, 2] });
        lines.Add(new int[3] { board[2, 0], board[1, 1], board[0, 2] });

        foreach (var line in lines)
        {
            if (line.All(n => n == 1))
                return 1;
            if (line.All(n => n == 2))
                return 2;
            if (line.Contains(0))
                zeroFound = true;
        }

        return zeroFound ? -1 : 0;
    }
}
