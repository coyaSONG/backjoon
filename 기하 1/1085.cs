using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int w = int.Parse(input[2]);
            int h = int.Parse(input[3]);
            
            int n1 = w-x;
            int n2 = h-y;
            
            int[] numList = new int[]{x,y,n1,n2};
            
            int output = 1000;
            
            for(int i=0;i<4;i++)
            {
                if(output>numList[i])
                    output = numList[i];
            }
            
            Console.Write(output);
        }
    }
}
