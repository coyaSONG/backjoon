using System;
using System.Text;

namespace baekjoon
{
    public class Program
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int i = 0; i < n-1; i++)
            {
                sum = sum * 2 + 1;
            }
            sb.AppendLine(sum.ToString());

            move(n - 1, 1, 2, 3);

            Console.Write(sb);
        }

        static void move(int n, int a, int b,int c)
        {
            if (n == 0)
                sb.AppendLine(a+" "+c);
            else
            {
                move(n - 1, a, c, b);
                sb.AppendLine(a + " " + c);
                move(n - 1, b, a, c);
            }

        }
    }
}
