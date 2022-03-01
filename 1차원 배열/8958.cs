using System;

namespace backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                int cnt = 0;
                string str = Console.ReadLine();

                foreach (char item in str)
                {
                    if (item == 'O')
                    {
                        cnt++;
                    }
                    else
                        cnt = 0;
                    ans[i] += cnt;
                }
                Console.WriteLine(ans[i]);
            }
        }
    }
}
