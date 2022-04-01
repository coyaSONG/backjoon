using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int sixCnt = 0;
            int six = 0;
            while(n != sixCnt)
            {
                six++;
                if(six.ToString().Contains("666"))
                    sixCnt++;
            }
            Console.Write(six);
        }
    }
}
