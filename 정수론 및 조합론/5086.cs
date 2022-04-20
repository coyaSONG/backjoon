using System;
using System.IO;

class Program
{
    static void Main()
    {
        using(StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
        {
            while(true)
            {
                string input = sr.ReadLine();
                if(input == "0 0") break;
                int[] num = Array.ConvertAll(input.Split(),int.Parse);
                
                if(num[1]%num[0]==0) Console.WriteLine("factor");
                else if(num[0]%num[1]==0) Console.WriteLine("multiple");
                else Console.WriteLine("neither");
            }
        }
    }
}
