using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Array.ConvertAll<string,int>(Console.ReadLine().Split(),int.Parse);
            int[] input2 = Array.ConvertAll<string,int>(Console.ReadLine().Split(),int.Parse);
            
            int output = 0;
            for(int i=0;i<input2.Length;i++)
            {
                for(int j=i+1;j<input2.Length;j++)
                {
                    for(int k=j+1;k<input2.Length;k++)
                    {
                        int sum = input2[i] + input2[j] + input2[k];
                        
                        if(sum>input1[1]) continue;
                        if(sum == input1[1])
                        {
                            output = input1[1];
                            break;
                        }
                        if(sum>output) output = sum;
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
