using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int startNum = n-(9*n.ToString().Length);
            
            for(int i=startNum;i<n;i++)
            {
                if(n==i+sumEachNum(i))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            
            Console.WriteLine("0");
        }
        
        static int sumEachNum(int num)
        {
            if(num < 10)
                return num;
            else
            {
                int n = num%10;
                return sumEachNum(num/10)+n;
            }
        }
    }
}
