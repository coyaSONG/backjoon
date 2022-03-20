using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int m = int.Parse(Console.ReadLine());
                if (m == 0) break;
                int n = m*2;
                int cnt = 0;

                bool[] output = getPrimeList(m, n);

                for (int i = m+1; i <= n; i++)
                    if (output[i])
                        cnt++;

                Console.WriteLine(cnt);

            }
            
        }

        static bool[] getPrimeList(int start,int end)
        {
            bool[] arr = new bool[end + 1];

            for (int i = 2; i < arr.Length; i++)
                arr[i] = true;

            arr[0] = false;
            arr[1] = false;

            for (int i= 2; i<= end; i++)
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
