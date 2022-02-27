using System;
using System.Text;

namespace nm
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            int b = 1;
            StringBuilder sb = new StringBuilder();
            
            while(a != 0 && b != 0)
            {
                string[] str = Console.ReadLine().Split();
                a = int.Parse(str[0]);
                b = int.Parse(str[1]);
                if(a != 0 && b != 0) sb.Append(a+b+"\n");
            }
            Console.WriteLine(sb);
        }
    }
}
