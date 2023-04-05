using System;

namespace HyeasDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N / 4; i++)
            {
                Console.Write("long ");
            }
            Console.WriteLine("int");
        }
    }
}
