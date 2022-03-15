using System;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            BigInteger a = BigInteger.Parse(input[0]);
            BigInteger b = BigInteger.Parse(input[1]);
            
            Console.Write(a + b);
        }
    }
}
