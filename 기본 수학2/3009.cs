using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[3];
            int[] x = new int[3];
            int[] y = new int[3];
            
            for(int i=0;i<3;i++)
            {
                input = Console.ReadLine().Split();
                x[i] = int.Parse(input[0]);
                y[i] = int.Parse(input[1]);
            }
            
            int maxX=1,minX=1000;
            int maxY=1,minY=1000;
            int sumX=0,sumY=0;
            
            for(int i=0;i<3;i++)
            {
                if(maxX<x[i]) maxX=x[i];
                if(minX>x[i]) minX=x[i];
                if(maxY<y[i]) maxY=y[i];
                if(minY>y[i]) minY=y[i];
                sumX+=x[i];
                sumY+=y[i];
            }
            
            Console.Write(string.Format("{0} {1}",maxX*2+minX*2-sumX,maxY*2+minY*2-sumY));
        }
    }
}
