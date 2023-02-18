using System;
using System.Text;

namespace PalindromeCounter
{
    class Program
    {
        static int count;
        static int Recursion(string s, int l, int r)
        {
            count++;
            if (l >= r) return 1;
            else if (s[l] != s[r]) return 0;
            else return Recursion(s, l + 1, r - 1);
        }

        static int IsPalindrome(string s)
        {
            return Recursion(s, 0, s.Length - 1);
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                count = 0;
                string input = Console.ReadLine().Trim();
                sb.AppendLine($"{IsPalindrome(input)} {count}");
            }

            Console.Write(sb);
        }
    }
}
