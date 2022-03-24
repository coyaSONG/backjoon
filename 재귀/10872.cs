using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(getFactorial(n));
        }
        
        static int getFactorial(int num)
        {
            if(num == 0||num == 1)
                return 1;
            else
                return num*getFactorial(num-1);
        }
    }
}
