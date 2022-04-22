using System;
using System.IO;

class Program
{
    static void Main()
    {
        using(StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
        {
            int[] num = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            Console.WriteLine(GCD(num[0],num[1]));
            Console.WriteLine((num[0]*num[1])/GCD(num[0],num[1]));
        }
    }
    
    static int GCD(int a, int b)
    {
        return (b==0?a:GCD(b,a%b));
    }
}
