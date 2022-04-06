using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrChar = Console.ReadLine().ToCharArray();
            Array.Sort(arrChar);
            Array.Reverse(arrChar);
            Console.Write(arrChar);
        }
    }
}
