using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(getFb(n));
        }

        static int getFb(int num)
        {
            if (num == 0 || num == 1)
                return num;
            else
                return getFb(num - 1) + getFb(num - 2);
        }
    }
}
