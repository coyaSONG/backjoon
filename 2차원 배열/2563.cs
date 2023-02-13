using System;

class MainClass {
  public static void Main (string[] args) {
    // 100x100 2차원 배열을 생성하고 모든 요소를 0으로 초기화합니다.
    int[,] grid = new int[100, 100];

    // 색종이의 개수를 입력 받습니다.
    int n = int.Parse(Console.ReadLine());

    // 각 색종이에 대해 그림을 그립니다.
    for (int k = 0; k < n; k++) {
      // 색종이의 좌표를 입력 받습니다.
      string[] inputs = Console.ReadLine().Split(' ');
      int x = int.Parse(inputs[0]);
      int y = int.Parse(inputs[1]);

      // 색종이가 덮는 10x10 부분 그리드의 모든 요소를 1로 설정합니다.
      for (int i = x; i < x + 10; i++) {
        for (int j = y; j < y + 10; j++) {
          grid[i,j] = 1;
        }
      }
    }

    // 모든 요소를 순회하면서 1의 개수를 세고, 그 합을 출력합니다.
    int count = 0;
    for (int i = 0; i < 100; i++) {
      for (int j = 0; j < 100; j++) {
        count += grid[i,j];
      }
    }
    Console.WriteLine(count);
  }
}
