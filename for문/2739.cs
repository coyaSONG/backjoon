using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            
            for(int i = 0;i<9;i++)
            {
                Console.WriteLine(string.Format("{0} * {1} = {2}",a,i+1,a*(i+1)));
            }
        }
    }
}
