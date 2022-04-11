using System;
using System.Collections.Generic;
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

            int n = int.Parse(sr.ReadLine());

            Dictionary<int, int> p = new Dictionary<int, int>();
            int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] sorted = nums.Distinct().ToArray();

            Array.Sort(sorted);

            int cnt = 0;
            for (int i = 0; i < sorted.Length; i++)
            {
                if (p.ContainsKey(sorted[i]))
                    continue;

                p.Add(sorted[i], cnt);
                cnt++;
            }

            for (int i = 0; i < n; i++)
                sw.Write(p[nums[i]] + " ");


            sw.Flush();
            sr.Close();
            sw.Close();
        }
    }
}
