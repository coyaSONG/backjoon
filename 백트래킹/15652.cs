using System;
using System.IO;
using System.Linq;

namespace baekjoon
{
    class Program
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        static int[] arrNum = new int[9];
        static int[] input = new int[2];
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
                for (int i = 1; i <= input[0]; i++)
                {
                    if (arrNum[depth -1 >= 0 ? depth -1 : depth] > i) continue;

                    arrNum[depth] = i;
                    DFS(depth + 1);
                }
            }

        }
    }
}
