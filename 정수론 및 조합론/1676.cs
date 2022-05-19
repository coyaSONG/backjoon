using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(getZeroCount(N));
    }
    
    // N!의 값에서 끝에 달린 0의 갯수를 구하는 방식은
    // 5의 1,2,3 제곱(N은 500까지이기에 3까지)으로 나눈 값의 총 합과 같음
    static int getZeroCount(int num)
    {
        int five1 = num/5;
        int five2 = num/25;
        int five3 = num/125;
        return five1+five2+five3;
    }
}
