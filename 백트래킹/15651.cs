using System;
using System.IO;
using System.Linq;

class Program
{
    static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    static int[] arrNum = new int[8];
    static int N,M;
    
    static void Main()
    {
        int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
        N = input[0];
        M = input[1];
        
        func(0);
        
        sr.Close();
        sw.Close();
    }
    
    static void func(int depth)
    {
        if(depth == M)
        {
            sw.WriteLine(string.Join(' ',arrNum.Where(x=>x!=0)));
            return;
        }
        else
        {
            for(int i=1;i<=N;i++)
            {
                arrNum[depth]=i;
                func(depth+1);
            }
        }
    }
}
