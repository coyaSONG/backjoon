using System;
using System.Linq;

namespace baekjoon
{
    public class Program
    { 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNum = new int[n];

            for (int i = 0; i < n; i++)
                arrNum[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join('\n', arrNum.AsEnumerable().OrderBy(x => x)));
        }
    }
}
