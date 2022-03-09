using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int n = 0;

            if (c - b > 0)
                n = (a / (c - b)) + 1;
            else
                n = -1;

            Console.WriteLine(n);

        }
    }
}
