using System;
namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            
            string[] str = s1.Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(s2);
            int d = c / 60;
            int e = c - (60 * d);
            
            if(b + e >= 60)
            {
                if(b + e == 60) a += 1;
                else a += 1; b -= 60;
            }
            
            Console.WriteLine(string.Format("{0} {1}",a + d > 23 ? a + d - 24 : a + d, b + e));
            
        }
    }
}
