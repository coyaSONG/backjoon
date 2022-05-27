using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        string input = sr.ReadLine();
        
        var listA = new HashSet<string>(sr.ReadLine().Split());
        var listB = new HashSet<string>(sr.ReadLine().Split());
        var a = listA.Intersect(listB);
        
        sw.WriteLine(listA.Count+listB.Count-(a.Count()*2));
        
        sr.Close();
        sw.Flush();
        sw.Close();
    }
}
