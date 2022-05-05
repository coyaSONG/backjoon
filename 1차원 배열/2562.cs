using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0, max = 0;
            for(int i=0;i<9;i++)
            {
                int n = int.Parse(Console.ReadLine());
                if(max <= n) { max = n; cnt = i+1; }
            }
            Console.WriteLine(max + "\n" + cnt);
        }
    }
}
