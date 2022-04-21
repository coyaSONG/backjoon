using System;
using System.IO;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] num = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        Array.Sort(num);
        Console.WriteLine(num[0]*num[n-1]);
    }
}
