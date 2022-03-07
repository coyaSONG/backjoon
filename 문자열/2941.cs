using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strList = new string[8]
            {
              "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="
            };

            string input = Console.ReadLine();

            for (int i = 0; i < strList.Length; i++)
            {
                input = input.Replace(strList[i], "*");
            }

            Console.Write(input.Length);

        }
    }
}
