using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = new int[10001];
            for(int i=1;i<=10000;i++)
            {
                int n = dn(i);
                if(n > 10000) continue;
                numList[n] = 1;
            }
            
            for(int i=1;i<=10000;i++)
            {
                if(numList[i] != 1)
                    Console.WriteLine(i);
            }
        }
        
        static int dn(int num)
        {
            int rst = num;
            
            while(num > 0)
            {
                rst+=num%10;
                num = num/10;
            }
            
            return rst;
        }
    }
}
