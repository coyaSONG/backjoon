using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < testNum; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[,] apart = new int[k+1,n];


                for (int j = 0; j < n; j++)
                    apart[0,j] = j + 1;

                for (int c = 0; c <= k; c++)
                {
                    for (int d = 0; d < n; d++)
                    {
                        if (d == 0)
                            apart[c, d] = 1;
                        else if(c != 0)
                            apart[c, d] = apart[c - 1, d] + apart[c, d - 1];
                    }
                }

                Console.WriteLine(apart[k, n-1]);
            }
        }
    }
}
