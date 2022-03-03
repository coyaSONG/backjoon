using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                if (isHanSu(i)) answer++;
            }

            Console.WriteLine(answer);
        }

        static bool isHanSu(int num)
        {
            bool result = false;

            string str = num.ToString();
            if (num < 100)
            {
                result = true;
            }
            else if (num > 99 && num < 1000)
            {
                int diff1 = str[1] - str[0];
                int diff2 = str[2] - str[1];
                if (diff1 == diff2) result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
