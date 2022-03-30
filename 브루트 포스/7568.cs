using System;

namespace baekjoon
{
    public class Program
    { 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] x = new int[n];
            int[] y = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                x[i] = input[0];
                y[i] = input[1];
            }

            for (int i = 0; i < n; i++)
            {
                int cnt = 0;
                for (int j = 0; j < n; j++)
                {
                    if (x[i] < x[j] && y[i] < y[j])
                        cnt++;
                }
                Console.Write((cnt + 1).ToString() + ' ');
            }
        }
    }
}
