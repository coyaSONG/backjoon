using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int minNum = 10000;
            for (int i = m; i <= n; i++)
            {
                if (i != 1 && isPrime(i))
                {
                    sum += i;
                    if (minNum > i)
                        minNum = i;
                }
            }
            if(sum == 0)
                Console.WriteLine("-1");
            else
                Console.WriteLine(sum+"\n"+minNum);
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
