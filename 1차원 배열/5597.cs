bool[] submitted = new bool[30]; // 과제 제출 여부 (true: 제출, false: 미제출)

for (int i = 0; i < 28; i++)
{
    int student = int.Parse(Console.ReadLine());
    submitted[student - 1] = true; // 과제 제출 처리
}

for (int i = 0; i < 30; i++)
{
    if (!submitted[i]) // 과제 미제출 체크
    {
        Console.WriteLine(i + 1); // 미제출한 학생의 번호 출력
    }
}
