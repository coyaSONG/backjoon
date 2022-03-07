using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cnt = n;
            for (int i = 0; i < n; i++)
            {
                bool[] isUsedWord = new bool[26];
                string input = Console.ReadLine();

                char prevC = ' ';
                for (int j = 0; j < input.Length; j++)
                {
                    char c = input[j];
                    int num = (int)c - (int)'a';

                    if(c != prevC && isUsedWord[num])
                    {
                        cnt--;
                        break;
                    }
                    else
                    {
                        isUsedWord[num] = true;
                        prevC = c;
                    }
                }
            }

            Console.WriteLine(cnt);

        }
    }
}
