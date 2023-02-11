int X = int.Parse(Console.ReadLine()); // 영수증에 적힌 총 금액
int N = int.Parse(Console.ReadLine()); // 구매한 물건의 종류의 수
int total = 0; // 구매한 물건의 가격과 개수를 계산한 총 금액

for (int i = 0; i < N; i++)
{
    string[] line = Console.ReadLine().Split(); // 각 물건의 가격과 개수
    int a = int.Parse(line[0]); // 각 물건의 가격
    int b = int.Parse(line[1]); // 각 물건의 개수
    total += a * b; // 구매한 물건의 가격과 개수를 계산
}

if (total == X) // 구매한 물건의 가격과 개수로 계산한 총 금액이 영수증에 적힌 총 금액과 일치하는지 확인
{
    Console.WriteLine("Yes"); // 일치하면 Yes 출력
}
else
{
    Console.WriteLine("No"); // 일치하지 않으면 No 출력
}
