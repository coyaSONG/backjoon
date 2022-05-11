using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while(true)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);
                
                if(a==0&&b==0&&c==0) break;
                
                if( a*a+b*b==c*c
                  ||a*a+c*c==b*b
                  ||b*b+c*c==a*a) sb.AppendLine("right");
                else sb.AppendLine("wrong");
            }
            
            Console.Write(sb);
        }
    }
}
