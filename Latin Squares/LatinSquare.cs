using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latin_Squares
{
    internal class LatinSquare
    {
        public static int[,] MakeLatinSquare(int n)
        {
            int[,] latinSquare = new int[n, n];

            // Fill the Latin square
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    latinSquare[i, j] = (i + j) % n + 1;
                }
            }

            return latinSquare;
        }
    }
}
