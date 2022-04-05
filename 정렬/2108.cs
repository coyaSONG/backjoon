using System;
using System.Linq;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrInput = new int[n];

            for (int i = 0; i < n; i++)
                arrInput[i] = int.Parse(Console.ReadLine());

            var avg = Math.Round((double)arrInput.Sum() / (double)n);
            Console.WriteLine(avg == -0 ? 0: avg);

            Array.Sort(arrInput);
            Console.WriteLine(arrInput[n/2]);

            int[] arrCnt = new int[8001];
            for (int i = 0; i < n; i++)
                arrCnt[arrInput[i] + 4000]++;

            int cntMax = arrCnt.AsEnumerable().Max();
            int[] secondNum = new int[2];
            int t = 0;
            for (int i = 0; i < arrCnt.Length; i++)
            {
                if (t == 2) break;
                if (arrCnt[i] == cntMax)
                {
                    secondNum[t] = i;
                    t++;
                }
            }
            Console.WriteLine(t == 2 ? secondNum[1] - 4000 : secondNum[0] - 4000);
            Console.WriteLine(arrInput.AsEnumerable().Max() - arrInput.AsEnumerable().Min());
        }
    }
}
