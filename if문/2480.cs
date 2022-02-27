using System;

namespace nm
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] str = s.Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);
            
            if(a == b && b==c)
            {
                Console.WriteLine(10000 + (a * 1000));
            }
            else if(a==b || b==c || a==c)
            {
                if(b==c) a = b;
                Console.WriteLine(1000+(a*100));
            }
            else
            {
                if(b>a) a=b;
                if(c>a) a=c;
                Console.WriteLine(a * 100);
            }
        }
    }
}
