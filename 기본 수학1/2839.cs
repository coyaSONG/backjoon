using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            
            while(n >= 0)
            {
                if(n % 5 == 0)
                {
                    cnt += n / 5;
                    Console.Write(cnt);
                    break;
                }
                n -= 3;
                cnt++;
                if(n < 0)
                {
                    Console.Write(-1);
                }
            }
        }
    }
}
