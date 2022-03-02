using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            float[] numList = new float[n];
            float max = int.Parse(str[0]);
            float rst = 0;

            for(int i=0;i<n;i++)
            {
                numList[i] = int.Parse(str[i]);
                if (max < numList[i]) max = numList[i];
            }

            for (int i = 0; i < n; i++)
            {
                numList[i] = (numList[i] / max) * 100;
                rst += numList[i];
            }

            Console.WriteLine(rst / n);

        }
    }
}
