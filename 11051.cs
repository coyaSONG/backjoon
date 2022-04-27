using System;
class Program
{
    // 동적 계획법 사용을 위해 캐시 배열 이용
    static int[,] cache;
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        
        // 해당 문제는 이항 계수의 N의 범위가 1000까지이기 때문에 
        // 결과 값이 굉장히 클것이라 판단
        // 이항계수의 정의를 이용하여 이항계수를 나눈다.
        // 쪼개진 이항계수 부분문제마다 %10007을 이용하여 integer로 커버함
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        cache = new int[N+1,K+1];

        Console.Write(func(N, K));
    }
    static int func(int n, int k)
    {
        if (cache[n, k] > 0)
            return cache[n, k];

        if (k == 0 || n == k)
            return cache[n, k] = 1;

        return cache[n, k] = (func(n - 1, k - 1) + func(n - 1, k)) % 10007;
    }
}
