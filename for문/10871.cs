using System;
using System.Text;

namespace nm
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string[] str = Console.ReadLine().Split();
            string[] numList = Console.ReadLine().Split();
            int n = int.Parse(str[0]);
            int a = int.Parse(str[1]);
            
            for(int i=0;i<n;i++)
            {
                int num = int.Parse(numList[i]);
                if(num < a) sb.Append(string.Format("{0} ",num));
            }
            
            Console.WriteLine(sb);
        }
    }
}
