using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine(string.Format("{0}",(a*(a+1))/2));
        }
    }
}
