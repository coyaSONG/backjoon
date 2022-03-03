using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);
            int[] arrN = new int[n];
            
            for(int i = 0;i<n;i++)
            {
                s1 = Console.ReadLine();
                string[] str = s1.Split();
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                arrN[i] = a+b;
            }
            
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine(arrN[i]);
            }
        }
    }
}
