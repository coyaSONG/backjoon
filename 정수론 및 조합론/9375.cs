using System;
using System.Collections.Generic;
using System.Text;

// 옷의 종류별로 조합을 따로 구하고 나온 조합들을 모두 곱해준 뒤
// 알몸인 경우 1개를 제외하면 되는 문제
class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < T; i++)
        {
            // 옷의 종류를 Key로 두고 같은 종류가 나왔을때마다 카운트를 1개씩 올려주기 위한 딕셔너리
            // (옷의 이름은 쓸모없으므로 받는 인풋의 인덱스 1만 저장)
            Dictionary<string, int> cloth = new Dictionary<string, int>();
            int N = int.Parse(Console.ReadLine());
            for (int j = 0; j < N; j++)
            {
                string input = Console.ReadLine().Split()[1];
                if (cloth.ContainsKey(input)) cloth[input]++;
                else cloth.Add(input, 1);
            }
            
            // 딕셔너리 키 = 옷의 종류, 밸류 = 옷의 갯수
            // 1. 같은 종류의 옷은 입지 않는다 => 한종류에선 한가지만 선택한다 고로 nC1 이라고 생각할수있음.
            // 2. 조합을 할 때 옷 종류별로 반드시 한가지를 골라야하는것은 아님
            // ex) 옷의 종류가 모자와 안경의 경우, 모자는 골랐지만 안경은 고르지 않아도됨
            // => 즉, 옷을 고르지 않았을 경우를 조합에 포함시킴.
            // 그 후 각 종류별로 나온 모든 조합의 경우의 수를 곱하면 전체 조합의 수가 됨.
            // (단, 옷을 고르지 않았을 경우를 넣어서 생각했기때문에 모든 옷을 선택하지 않는 경우의 수 1개를 최종 결과에서 빼줘야함.)
            
            int sum = 1;
            foreach (var item in cloth)
                sum *= item.Value + 1;
            sb.AppendLine((sum - 1).ToString());
        }
        Console.WriteLine(sb);
    }
}
