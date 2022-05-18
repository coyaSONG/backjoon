using System;

class Program
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int w = input[0], h = input[1], x = input[2], y = input[3], p = input[4];
        int cnt = 0;
        for(int i=0;i<p;i++)
        {
            int[] pXY = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if (isInside(w,h,x,y,pXY[0],pXY[1])) cnt++;
        }
        Console.WriteLine(cnt);
    }
    static bool isInside(int w,int h,int x,int y,int pX,int pY)
    {
        int r = h/2;
        if(r*r >= (x-pX)*(x-pX)+(y+r-pY)*(y+r-pY)) return true;
        if(r*r >= (x+w-pX)*(x+w-pX)+(y+r-pY)*(y+r-pY)) return true;
        if(pX >= x && pX <= x+w && pY >= y && pY <= y+h) return true;
        return false;
    }
}
