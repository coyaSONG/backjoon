using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            
            Console.Write(string.Format("{0:F6}\n{1:F6}",n*n*Math.PI,n*n*2));
        }
    }
}
