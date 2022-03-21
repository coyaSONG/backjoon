using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            bool[] primeList = getPrimeList(10000);
            
            for(int i=0;i<t;i++)
            {
                int n = int.Parse(Console.ReadLine())/2;
                
                int chk = 0;
                while(true)
                {
                    if(primeList[n-chk] && primeList[n+chk])
                    {
                        Console.WriteLine((n-chk)+" "+(n+chk));
                        break;
                    }
                    chk++;
                }
            }
        }
        
        static bool[] getPrimeList(int endNum)
        {
            bool[] arr = new bool[endNum+1];
            
            for(int i=2;i<arr.Length;i++)
                arr[i]=true;
            
            for(int i=2;i<arr.Length;i++)
            {
                for(int j=2*i;j<arr.Length;j+=i)
                    arr[j] = false;
            }
            
            return arr;
        }
    }
} 
