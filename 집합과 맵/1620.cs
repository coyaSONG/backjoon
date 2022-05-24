using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        var getNum = new Dictionary<string,int>();
        StringBuilder sb = new StringBuilder();
        string[] input = sr.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        string[] arr = new string[N+1];
        
        for(int i=1;i<=N;i++)
        {
            string s = sr.ReadLine();
            getNum.Add(s,i);
            arr[i] = s;
        }
        
        for(int i=0;i<M;i++)
        {
            string s = sr.ReadLine();
            if(Int32.TryParse(s,out int n)) sw.WriteLine(arr[n]);
            else sw.WriteLine(getNum[s]);
        }
        sr.Close();
        sw.Flush();
        sw.Close();
    }
}
