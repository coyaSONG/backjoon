using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9x9 행렬의 각 원소를 저장할 변수
            int[,] matrix = new int[9, 9];

            // 각 행마다 9개의 원소를 입력 받아 matrix 배열에 저장
            for (int i = 0; i < 9; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            // 최댓값과 그 위치를 저장할 변수
            int maxValue = 0;
            int row = 0;
            int col = 0;

            // 각 원소를 검사하여 최댓값을 찾고 그 위치를 기록
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        row = i + 1;
                        col = j + 1;
                    }
                }
            }

            // 최댓값과 그 위치 출력
            Console.WriteLine(maxValue);
            Console.WriteLine(row + " " + col);
        }
    }
}
