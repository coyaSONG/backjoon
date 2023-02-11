int n = int.Parse(Console.ReadLine()); // 배열의 크기
string[] line = Console.ReadLine().Split(); // 배열
int k = int.Parse(Console.ReadLine()); // 찾을 정수
int count = 0; // 찾은 정수의 개수

for (int i = 0; i < n; i++)
{
    if (int.Parse(line[i]) == k) // 배열의 i번째 원소가 찾을 정수와 같은지 확인
    {
        count++; // 같다면 카운트 증가
    }
}

Console.WriteLine(count); // 찾은 정수의 개수 출력
