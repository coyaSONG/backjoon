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
                string[] str = Console.ReadLine().Split();

                float p = float.Parse(str[0]);
                float cnt = 0;
                float sum = 0;

                for (int j = 1; j <= p; j++)
                {
                    sum += float.Parse(str[j]);
                }

                float avg = 0;
                avg = sum / p;

                for (int k = 1; k <= p; k++)
                {
                    if (avg < float.Parse(str[k])) cnt++;
                }

                string fmt = string.Format("{0:f3}", Math.Round(cnt / p * 100, 3));

                Console.WriteLine(fmt+"%");
            }
            
        }
    }
}
