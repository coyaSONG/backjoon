using System;
using System.IO;

namespace baekjoon
{
    class Program
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        static int N = int.Parse(sr.ReadLine());
        static int[] arrNum = new int[N];
        static int[] arrOp = new int[4];
        static int MAX = -1000000000;
        static int MIN = -MAX;
        static void Main(string[] args)
        {
            arrNum = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            arrOp = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            DFS(1,arrNum[0]);

            sw.WriteLine(MAX);
            sw.WriteLine(MIN);
            sw.Close();
            sr.Close();
        }

        static void DFS(int depth, int sum)
        {

            if(depth == N)
            {
                MAX = MAX < sum ? sum : MAX;
                MIN = MIN > sum ? sum : MIN;
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                if(arrOp[i] > 0)
                {
                    arrOp[i]--;
                    if (i == 0) DFS(depth + 1, sum + arrNum[depth]);
                    if (i == 1) DFS(depth + 1, sum - arrNum[depth]);
                    if (i == 2) DFS(depth + 1, sum * arrNum[depth]);
                    if (i == 3) DFS(depth + 1, sum / arrNum[depth]);
                    arrOp[i]++;
                }
            }

        }

    }
}
