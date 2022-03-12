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
            int v = int.Parse(input[2]);

            Console.Write((v-b)%(a-b) == 0 ? (v - b) / (a - b) : (v - b) / (a - b) + 1);

        }
    }
}
