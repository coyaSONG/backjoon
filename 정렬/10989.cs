using System;
using System.IO;

namespace baekjoon
{
    public class Program
    { 
        static void Main(string[] args)
        {
            using StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            using StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int N = int.Parse(sr.ReadLine());
            int[] cnt = new int[10001];

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(sr.ReadLine());
                cnt[num]++;
            }
            for (int i = 0; i < cnt.Length; i++)
            {
                for (int j = 0; j < cnt[i]; j++)
                {
                    sw.WriteLine(i);
                }
            }

        }
    }
}
