using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] sec = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] numWord = new string[]
            {
                "","ABC","DEF","GHI","JKL","MNO","PQRS","TUV","WXYZ"
            };

            int answer = 0;
            foreach (char c in input)
            {
                for (int i = 0; i < numWord.Length; i++)
                {
                    if (numWord[i].Contains(c)) answer += sec[i];
                }
            }

            Console.WriteLine(answer);
        }
    }
}
