using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            int[] num = new int[26];

            foreach (char c in input)
            {
                int t = (int)c;
                num[t - (int)'A']++;
            }

            int max  = 0;
            char maxChar = ' ';
            for (int i = 0; i < 26; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                    maxChar = (char)(i + (int)'A');
                }
            }

            int cntMax = 0;
            for (int i = 0; i < 26; i++)
            {
                if (num[i] == max) cntMax++;
            }

            if (cntMax > 1) Console.WriteLine("?");
            else Console.WriteLine(maxChar);
        }
    }
}
