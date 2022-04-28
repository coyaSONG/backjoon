using System;
using System.Text;

class Program
{
    static int[,] cache;
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[1]);
            int K = int.Parse(input[0]);
            cache = new int[N + 1, K + 1];

            sb.AppendLine(func(N, K).ToString());
        }
        Console.WriteLine(sb);
    }
    
    // 강 동쪽 다리수 N
    // 강 서쪽 다리수 K 로 생각한 이항계수를 떠올리고
    // 이항계수의 정의와 동적계획법을 이용하면 쉬운 문제
    static int func(int n, int k)
    {
        if (cache[n, k] > 0)
            return cache[n, k];

        if (k == 0 || n == k)
            return cache[n, k] = 1;

        return cache[n, k] = (func(n - 1, k - 1) + func(n - 1, k));
    }
}
