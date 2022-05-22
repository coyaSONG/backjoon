using System;
using System.Collections.Generic;
namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> p = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            for (int i = 0; i < N; i++)
                p.Add(Console.ReadLine(),null);

            int cnt = 0;
            for (int i = 0; i < M; i++)
                if (p.ContainsKey(Console.ReadLine())) cnt++;

            Console.WriteLine(cnt);
        }
    }
}
