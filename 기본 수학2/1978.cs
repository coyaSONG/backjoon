using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(input[i]);
                if (num != 1 && isPrime(num))
                    cnt++;
            }
            Console.WriteLine(cnt);

        }
        static bool isPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

    }

}
