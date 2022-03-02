using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int rst = a*b*c;
            int[] arrNum = {0,0,0,0,0,0,0,0,0,0};
            
            while(true)
            {
                arrNum[rst%10]++;
                rst = rst/10;
                if(rst < 1) break;
            }
            
            for(int i=0;i<arrNum.Length;i++)
                Console.WriteLine(arrNum[i]);
        }
    }
}
