using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]), M = int.Parse(input[1]);
        Console.WriteLine(
            Math.Min( get5cnt(N)-(get5cnt(N-M)+get5cnt(M))
            ,get2cnt(N)-(get2cnt(N-M)+get2cnt(M)))
        );
    }
    static int get2cnt(int num)
    {
        int cnt=0;
        while(num>=2)
        {
            cnt+=num/2;
            num/=2;
        }
        return cnt;
    }
    static int get5cnt(int num)
    {
        int cnt=0;
        while(num>=5)
        {
            cnt+=num/5;
            num/=5;
        }
        return cnt;
    }
}
