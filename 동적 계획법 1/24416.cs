using System;
using System.IO;

class Program
{
    static int[,,] memo = new int[22, 22, 22];

    static int W(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return 1;
        }
        if (a > 20 || b > 20 || c > 20)
        {
            return W(20, 20, 20);
        }
        if (memo[a, b, c] != 0)
        {
            return memo[a, b, c];
        }
        if (a < b && b < c)
        {
            memo[a, b, c] = W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c);
        }
        else
        {
            memo[a, b, c] = W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);
        }
        return memo[a, b, c];
    }

    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        while (true)
        {
            string[] input = sr.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            if (a == -1 && b == -1 && c == -1)
            {
                break;
            }
            sw.WriteLine("w(" + a + ", " + b + ", " + c + ") = " + W(a, b, c));
        }

        sr.Close();
        sw.Close();
    }
}
