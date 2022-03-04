using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char x = 'a';
            for (int i = 0; i < 26; i++)
            {
                Console.Write(s.IndexOf((char)(x + i)) + " ");
            }

        }
    }
}
