using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        //이분탐색을 이용함
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Array.Sort(arr1);
            int M = int.Parse(Console.ReadLine());
            int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < M; i++)
            {
                int left = 0;
                int right = N - 1;
                while(left <= right)
                {
                    int mid = (left + right) / 2;
                    int n = arr1[mid];
                    if (n==m[i])
                    {
                        sb.Append(1 + " ");
                        break;
                    }
                    if (n > m[i])
                        right = mid - 1;
                    else
                        left = mid + 1;
                    if(left>right)
                    {
                        sb.Append(0 + " ");
                        break;
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
