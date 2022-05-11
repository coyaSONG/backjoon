using System;

class Program
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int wh = (input[1]*input[1])+(input[2]*input[2]);
        for(int i=0;i<input[0];i++)
        {
            int n = int.Parse(Console.ReadLine());
            if(wh >= n*n) Console.WriteLine("DA");
            else Console.WriteLine("NE");
        }
    }
}
