using System;

namespace backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int min = int.Parse(input[0]);
            int max = int.Parse(input[0]);
            for(int i=0;i<n;i++)
            {
                int t = int.Parse(input[i]);
                if(min > t) min = t;
                if(max < t) max = t;
            }
            Console.WriteLine(min + " " + max);
        }
    }
}
