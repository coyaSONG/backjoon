using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
        {
            int N = int.Parse(sr.ReadLine());
            int[] arrNum = new int[N];
            for (int i = 0; i < N; i++)
                arrNum[i] = int.Parse(sr.ReadLine());
            Array.Sort(arrNum);
            int gcd = arrNum[1]- arrNum[0];
            for (int i = 2; i < N; i++)
                gcd = GCD(gcd, arrNum[i] - arrNum[i - 1]);
            for (int i = 2; i <= gcd; i++)
                if (gcd % i == 0) sb.Append(i + " ");
            Console.Write(sb);
        }
    }
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int r = a;
            a = b;
            b = r % b;
        }
        return a;
    }
}
