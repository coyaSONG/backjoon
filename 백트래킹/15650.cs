using System;
using System.IO;
using System.Linq;

namespace baekjoon
{
    class Program
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        static bool[] visited = new bool[9];
        static int[] arrNum = new int[9];
        static int[] input = new int[2];
        static int preNum = 0;
        static void Main(string[] args)
        {
            input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            DFS(0);

            sw.Flush();
            sr.Close();
            sw.Close();
        }

        static void DFS(int depth)
        {
            if (depth == input[1])
            {
                sw.WriteLine(string.Join(' ', arrNum.Where(x => x != 0)));
                return;
            }
            else
            {
                for (int i = preNum+1; i <= input[0]; i++)
                {
                    if (visited[i]) continue;

                    visited[i] = true;
                    preNum = i;
                    arrNum[depth] = i;
                    DFS(depth + 1);
                    visited[i] = false;
                }
            }

        }
    }
}
