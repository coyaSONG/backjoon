using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            int i = 2;
            while(i<=m)
            {
                if(m%i==0)
                {
                    sb.AppendLine(i.ToString());
                    m /= i;
                }
                else
                    i++;
            }
            Console.Write(sb);
        }
    }
}
