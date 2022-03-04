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
            
            if( b < 45)
            {
                if( a == 0) a = 23;
                else a -= 1;
                
                b += 60;
            }
            
            Console.WriteLine(string.Format("{0} {1}", a, b -45));
        }
    }
}
