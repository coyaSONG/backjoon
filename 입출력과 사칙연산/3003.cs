using System;

class Program
{
    static void Main()
    {
        // 입력받은 체스 말의 수를 배열로 변환
        int[] piecesDelivered = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        // 완전한 체스 세트에 대한 표준 말의 수를 배열로 정의
        int[] piecesStandard = new int[] { 1, 1, 2, 2, 2, 8 };
        // 필요한 말의 수를 저장할 배열을 초기화
        int[] piecesNeeded = new int[6];

        // 말의 수를 비교하고 필요한 말의 수를 계산하여 배열에 저장
        for (int i = 0; i < 6; i++)
        {
            piecesNeeded[i] = piecesStandard[i] - piecesDelivered[i];
        }

        // 필요한 말의 수를 문자열로 변환하여 출력
        Console.WriteLine(string.Join(" ", piecesNeeded));
    }
}
