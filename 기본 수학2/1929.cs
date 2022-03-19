using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            StringBuilder sb = new StringBuilder();

            bool[] output = getPrimeList(m,n);

            for (int i = m; i <= n; i++)
                if (output[i])
                    sb.AppendLine(i.ToString());

            Console.Write(sb);
        }

        static bool[] getPrimeList(int start,int end)
        {
            bool[] arr = new bool[end + 1];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = true;

            arr[0] = false;
            arr[1] = false;

            for (int i=2;i<= end; i++)
            {
                if (arr[i])
                {
                    for (int j = 2 * i; j <= end; j += i)
                    {
                        arr[j] = false;
                    }
                }
            }

            return arr;
        }
    }
}
