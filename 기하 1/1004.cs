using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int T = int.Parse(Console.ReadLine());
        for(int i=0;i<T;i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int x1 = input[0], y1 = input[1], x2 = input[2], y2 = input[3];
            int cnt = 0;
            int n = int.Parse(Console.ReadLine());
            for(int j=0;j<n;j++)
            {
                int[] c = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                if(c[2]*c[2]>(c[0]-x1)*(c[0]-x1)+(c[1]-y1)*(c[1]-y1)
                  && c[2]*c[2]<(c[0]-x2)*(c[0]-x2)+(c[1]-y2)*(c[1]-y2)) cnt++;
                if(c[2]*c[2]>(c[0]-x2)*(c[0]-x2)+(c[1]-y2)*(c[1]-y2)
                  && c[2]*c[2]<(c[0]-x1)*(c[0]-x1)+(c[1]-y1)*(c[1]-y1)) cnt++;
            }
            sb.AppendLine(cnt.ToString());
        }
        Console.WriteLine(sb);
    }
}
