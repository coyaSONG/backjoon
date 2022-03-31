using System;

namespace baekjoon
{
    public class Program
    { 
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] arrWB = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string arr = Console.ReadLine();
                for (int j = 0; j < m; j++)
                    arrWB[i,j] = arr[j];
            }

            int rst = 50*50;
            for (int i = 0; i < n-7; i++)
            {
                for (int j = 0; j < m-7; j++)
                {
                    int w = 0, b = 0;
                    for (int k = i; k < i+8; k++)
                    {
                        for (int l = j; l < j+8; l++)
                        {
                            if((k+l)%2==0)
                            {
                                if (arrWB[k , l] != 87)
                                    w++;
                                else
                                    b++;
                            }
                            else
                            {
                                if (arrWB[k , l] != 66)
                                    w++;
                                else
                                    b++;
                            }
                        }
                    }
                    if(rst > w || rst > b)
                    {
                        if (w > b) rst = b;
                        else rst = w;
                    }
                }
            }

            Console.Write(rst);
        }
    }
}
