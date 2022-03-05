using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            int cnt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != "") cnt++;
            }
            Console.WriteLine(cnt);

        }
    }
}
