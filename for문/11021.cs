using System;

namespace baekjoon
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for(int i=0;i<n;i++)
            {
                string[] str = Console.ReadLine().Split();
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                Console.WriteLine(string.Format("Case #{0}: {1}",i+1,a+b));
            }
        }
    }
}
