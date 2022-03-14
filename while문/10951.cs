using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            while(true)
            {
                string str = Console.ReadLine();
                if(string.IsNullOrEmpty(str)) break;
                string[] arrStr = str.Split();
                int a = int.Parse(arrStr[0]);
                int b = int.Parse(arrStr[1]);
                sb.Append(a+b+"\n");
            }
            Console.WriteLine(sb);
        }
    }
}
