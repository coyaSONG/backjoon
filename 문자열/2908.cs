using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string str1 = string.Empty;
            string str2 = string.Empty;

            for (int i = 2; i >= 0; i--)
            {
                str1 += input[0][i];
                str2 += input[1][i];
            }

            Console.WriteLine(int.Parse(str1) > int.Parse(str2) ? int.Parse(str1) : int.Parse(str2));
        }
    }
}
