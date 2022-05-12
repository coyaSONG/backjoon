using System;

class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int[] arrLen = new int[6];
        for(int i=0;i<6;i++) arrLen[i] = int.Parse(Console.ReadLine().Split()[1]);
        
        int aW=0,aH=0,bW=0,bH=0;
        
        for(int i=0;i<6;i++)
        {
            if(i%2==0)
            {
                if(aW<arrLen[i]) aW=arrLen[i];
            }
            else
                if(aH<arrLen[i]) aH=arrLen[i];
        }
        
        for(int i=0;i<6;i++)
        {
            if(i%2==0)
            {
                if(aH == arrLen[i-1<0?5:i-1]+arrLen[i+1>5?0:i+1]) bW = arrLen[i];
            }
            else
                if(aW == arrLen[i-1<0?5:i-1]+arrLen[i+1>5?0:i+1]) bH = arrLen[i];
        }
        
        Console.WriteLine((aW*aH - bW*bH)*K);
    }
}
