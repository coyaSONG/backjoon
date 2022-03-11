using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int lineNum = 0;
            while (input > 0)
            {
                lineNum++;
                input -= lineNum;
            }


            if (lineNum % 2 == 0)
                Console.Write(string.Format("{0}/{1}", input+lineNum, 1-input));
            else
                Console.Write(string.Format("{0}/{1}", 1-input, input+lineNum));
        }
    }
}
