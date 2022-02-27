using System;

namespace nm
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for(int i=0;i<n;i++)
            {
                string str = string.Empty;
                for(int j=1;j<=n;j++)
                {
                    if(j<=n-1-i) str += ' ';
                    else str += '*';
                }
                Console.WriteLine(str);
            }
        }
    }
}
