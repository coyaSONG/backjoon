using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = new int[10];
            for (int i=0;i<10;i++)
            {
                numList[i] = int.Parse(Console.ReadLine()) % 42;
            }

            int ans = 0;
            for(int i=0; i<10;i++)
            {
                int cnt = 0;
                for (int j = i+1; j < 10; j++)
                {
                    if (numList[i] == numList[j]) cnt++;
                }
                if (cnt == 0) ans++;
            }
            Console.WriteLine(ans);

        }
    }
}
