using System;
using System.IO;
using System.Linq;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine());
            (int idx, int old, string nm)[] arr = new (int idx, int old, string nm)[N];

            for (int i = 0; i < N; i++)
            {
                string[] input = sr.ReadLine().Split();
                arr[i].idx = i;
                arr[i].old = int.Parse(input[0]);
                arr[i].nm = input[1];
            }

            var sortArr = arr.OrderBy(x => x.old).ThenBy(x => x.idx).ToArray();

            for (int i = 0; i < N; i++)
            {
                sw.WriteLine(sortArr[i].old + " " + sortArr[i].nm);
            }

            sr.Close();
            sw.Close();
        }
    }
}
