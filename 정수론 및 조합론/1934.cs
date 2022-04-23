using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        using(StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
        {
            int N = int.Parse(sr.ReadLine());
            for(int i=0;i<N;i++)
            {
                int[] num = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
                sb.AppendLine(((num[0]*num[1])/GCD(num[0],num[1])).ToString());
            }
        }
        Console.Write(sb);
    }
    
    static int GCD(int a, int b)
    {
        while(b!=0)
        {
            int r = a;
            a = b;
            b = r % a;
        }
        return a;
    }
}
