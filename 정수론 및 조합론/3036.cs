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
            int[] arrNum = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            
            for(int i=1;i<N;i++)
            {
                int gcd = GCD(arrNum[0],arrNum[i]);
                sb.AppendLine(arrNum[0]/gcd+"/"+arrNum[i]/gcd);
            }
            Console.Write(sb);
        }
    }
    static int GCD(int a,int b)
    {
        while(b!=0)
        {
            int r = a;
            a = b;
            b = r%b;
        }
        return a;
    }
}
