using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int cnt=0;
            int num=inputNum;
            
            while(true)
            {
                num = (num%10)*10 + ((num/10)+(num%10))%10;
                
                cnt++;
                
                if(num == inputNum) break;
            }
            Console.WriteLine(cnt);
        }
    }
}
