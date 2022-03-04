using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            for(int i = 0;i < n;i++)
            {
                string[] str = Console.ReadLine().Split();

                int cnt = int.Parse(str[0]);
                foreach (char c in str[1])
                {
                    sb.Append(c, cnt);
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
