using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int x1 = int.Parse(input[0]);
                int y1 = int.Parse(input[1]);
                int r1 = int.Parse(input[2]);
                int x2 = int.Parse(input[3]);
                int y2 = int.Parse(input[4]);
                int r2 = int.Parse(input[5]);

                if (x1 == x2 && y1 == y2)
                {
                    if (r1 == r2)
                        Console.WriteLine("-1");
                    else
                        Console.WriteLine("0");
                }
                else
                {
                    int xy = ((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2));
                    int rMax = (r1 + r2) * (r1 + r2);
                    int rMin = (r1 - r2) * (r1 - r2);

                    if (xy > rMax || xy < rMin)
                        Console.WriteLine("0");
                    else if (xy == rMax || xy == rMin)
                        Console.WriteLine("1");
                    else
                        Console.WriteLine("2");
                }

            }
        }
    }
}
