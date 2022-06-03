using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = sr.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        
        string[] arrN = new string[N];
        
        for(int i=0; i<N; i++) arrN[i] = sr.ReadLine();
        
        Array.Sort(arrN);
        var hs = new HashSet<string>(arrN);
        var rst = new List<string>();

        for(int i=0;i<N;i++)
        {
            string s = sr.ReadLine();
            if(hs.Contains(s)) rst.Add(s);
        }
        
        rst.Sort();
        sw.WriteLine(rst.Count);
        sw.WriteLine(string.Join("\n",rst));
        
        sr.Close();
        sw.Flush();
        sw.Close();
    }
}
