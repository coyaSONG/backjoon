using System;
using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        int n = int.Parse(sr.ReadLine());
        String[] arrStr = new String[n];
        
        for(int i=0;i<n;i++)
            arrStr[i]=sr.ReadLine();
        var pp = arrStr.Distinct().OrderBy(a=>a.Length).ThenBy(a=>a);
        foreach(var str in pp)
            sw.WriteLine(str);
        sr.Close();
        sw.Close();
    }
}
