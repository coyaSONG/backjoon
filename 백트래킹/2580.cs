using System;
using System.IO;

namespace baekjoon
{
    class Program
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        static int[,] sdk = new int [9,9];
        
        // 스도쿠 값을 row 와 col 형식 탐색을 위해 2차원 배열에 저장
        // 유망성 체크 3가지
        // 현재 탐색중인 깊이의 
        // 1. 같은 행
        // 2. 같은 열
        // 3. 그 값이 포함된 3x3 영역에서 같은 값이 있는지 검색
        // 없을 시 -> 계속 탐색 진행
        // 있을 시 -> 값을 다시 되돌린 후 처음부터 다시 탐색
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < 9; j++)
                {
                    sdk[i,j] = input[j];
                }
            }

            DFS(0,0);

        }

        static void DFS(int row,int col)
        {
            // 9번째 col이면
            // 다음 행(row+1)의 첫번째 열(col=0) 부터 다시 탐색
            if(col == 9)
            {
                DFS(row + 1, 0);
                return;
            }
            
            // row = 9 되면 row index 0~8까지
            // 모든 탐색이 종료 후 라는 뜻이므로
            // sdk 배열을 출력 후 프로그램 종료 Environment.Exit(0) 사용
            if(row == 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        sw.Write(sdk[i, j] + " ");
                    }
                    sw.WriteLine();
                }
                Environment.Exit(0);
            }

            // 빈 값인 깊이인가?
            if(sdk[row,col]==0)
            {
                // 1~9 까지 돌며 들어갈 값 찾기
                for (int i = 1; i < 10; i++)
                {
                    // 유망성 체크
                    if(dupNumCheck(row, col, i))
                    {
                        sdk[row, col] = i;
                        DFS(row, col + 1);
                    }
                }
                sdk[row, col] = 0;
                return;
            }
            // 빈 값이 아니면 다음 열
            else
                DFS(row, col + 1);
        }

        static bool dupNumCheck(int row,int col, int num)
        {
            // 행 열에서 중복값 검색
            for (int i = 0; i < 9; i++)
            {
                if (sdk[row, i] == num
                  || sdk[i, col] == num)
                    return false;
            }
            
            // 현재 좌표(num)가 포함된 3x3 영역에서 중복값 탐색
            for (int i = getRecSeq(row); i < getRecSeq(row)+3; i++)
            {
                for (int j = getRecSeq(col); j < getRecSeq(col)+3; j++)
                {
                    if (sdk[i, j] == num) return false;
                }
            }

            return true;
        }

        static int getRecSeq(int num)
        {
            return (num / 3) * 3;
        }

    }
}
