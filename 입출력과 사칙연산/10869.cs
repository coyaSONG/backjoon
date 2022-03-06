using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] str = s.Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            Console.WriteLine(string.Format("{0}\n{1}\n{2}\n{3}\n{4}",a+b,a-b,a*b,a/b,a%b));
        }
    }
}
