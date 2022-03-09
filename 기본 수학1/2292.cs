using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int wall = 1;
            int wallMax = 1;

            int cnt = 1;
            while (wallMax < input)
            {
                wall++;
                wallMax = wallMax + (6* cnt);
                cnt++;
            }

            Console.WriteLine(wall);
        }
    }
}
