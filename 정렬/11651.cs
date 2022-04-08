using System;
using System.Linq;
using System.IO;
using System.Drawing;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        int n = int.Parse(sr.ReadLine());
        Point[] p = new Point[n];
        
        for(int i=0;i<n;i++)
        {
            int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            p[i].X = input[0];
            p[i].Y = input[1];
        }
        
        var pp = p.OrderBy(a => a.Y).ThenBy(a=>a.X);
        
        foreach(var pt in pp)
            sw.WriteLine(pt.X + " " + pt.Y);
        sr.Close();
        sw.Close();
    }
}
