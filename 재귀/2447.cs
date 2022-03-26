using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    drawStar(i, j, n);
                }
                sb.Append('\n');
            }

            Console.Write(sb);
        }

        static void drawStar(int row,int col,int n)
        {
            if ((row / n) % 3 == 1 && (col / n) % 3 == 1)
                sb.Append(' ');
            else
            {
                if (n / 3 == 0)
                    sb.Append('*');
                else
                    drawStar(row, col, n/3);
            }
        }
    }
}
