using System;

class Program {
    static void Main(string[] args) {
        int[] nums = new int[5];

        // 5개의 자연수를 입력받는다.
        for (int i = 0; i < 5; i++) {
            nums[i] = int.Parse(Console.ReadLine());
        }

        // 총합과 평균을 구한다.
        int sum = 0;
        for (int i = 0; i < 5; i++) {
            sum += nums[i];
        }
        int mean = sum / 5;

        // 오름차순으로 정렬한다.
        Array.Sort(nums);

        // 중앙값을 찾아 출력한다.
        int median = nums[2];

        // 평균과 중앙값을 출력한다.
        Console.WriteLine(mean);
        Console.WriteLine(median);
    }
}
