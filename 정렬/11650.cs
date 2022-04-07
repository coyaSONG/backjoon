using System;
using System.Linq;
using System.IO;
using System.Drawing;

class main {
  static void Main() {
      StreamReader reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      int n = int.Parse(reader.ReadLine());
      Point[] p = new Point[n];
      
      for(int i = 0 ; i < n; i++)
      {
          int[] input = Array.ConvertAll(reader.ReadLine().Split(), int.Parse);
          p[i].X = input[0];
          p[i].Y = input[1];
      }
      var pp = p.OrderBy(a => a.X).ThenBy(a => a.Y);
      foreach(var pt in pp)
      {
          writer.WriteLine(pt.X + " " + pt.Y);
      }
      
      reader.Close();
      writer.Close();   
  }
}
