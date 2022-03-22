using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] str = s.Split();
            double a = float.Parse(str[0]);
            double b = float.Parse(str[1]);
            Console.WriteLine(a/b);
        }
    }
} 
