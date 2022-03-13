using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCnt; i++)
            {
                string[] input = Console.ReadLine().Split();
                int h = int.Parse(input[0]);
                int w = int.Parse(input[1]);
                int n = int.Parse(input[2]);
                int yy = 0;
                int xx = 0;

                if (n % h == 0)
                {
                    yy = h;
                    xx = n / h;
                }
                else
                {
                    yy = n % h;
                    xx = n / h + 1;
                }

                Console.WriteLine(yy * 100 + xx);
            }
        }
    }
}
