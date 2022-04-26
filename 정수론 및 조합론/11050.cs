using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        Console.Write(getFactorial(N)/(getFactorial(N-K)*getFactorial(K)));
    }
    static int getFactorial(int num)
    {
        int a = 1;
        for(int i=2;i<=num;i++) a*=i;
        return a;
    }
}
