using System;

namespace nm
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string[] str = new string[s2.Length];
            int a = int.Parse(s1);
            int b = int.Parse(s2);
            
            for(int i = 0; i < s2.Length; i++)
            {
                str[i] = s2.Substring(i,1);
            }
            
            int b1 = int.Parse(str[0]);
            int b2 = int.Parse(str[1]);
            int b3 = int.Parse(str[2]);
            
            Console.WriteLine(string.Format("{0}\n{1}\n{2}\n{3}",a*b3,a*b2,a*b1,a*b));
        }
    }
}
