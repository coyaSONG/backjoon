using System;

namespace nm
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            int a = int.Parse(x);
            int b = int.Parse(y);
            int q = 0;
            if(a > 0 && b > 0) q = 1;
            else if (a < 0 && b > 0) q = 2;
            else if (a < 0 && b < 0) q = 3;
            else q = 4;
            Console.WriteLine(q);
        }
    }
}
