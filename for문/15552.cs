using System;
using System.IO;
using System.Text;

namespace nm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            for(int i=0;i<n;i++)
            {
                using(StringReader sr = new StringReader(Console.ReadLine()))
                {
                    string[] str = sr.ReadLine().Split(' ');
                    int a = int.Parse(str[0]);
                    int b = int.Parse(str[1]);
                    sb.Append(a + b + "\n");    
                }
                
            }
            
            Console.WriteLine(sb);
        }
    }
}
