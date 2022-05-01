using System;
using System.Text;

class Program
{
    static StringBuilder sb = new StringBuilder();
    static string prevStr = "";
    static void Main()
    {
        sb.AppendLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
        int n = int.Parse(Console.ReadLine());
        func(n);
        Console.WriteLine(sb);
    }

    static void func(int n)
    {
        sb.AppendLine(prevStr + "\"재귀함수가 뭔가요?\"");

        if (n == 0)
        {
            sb.AppendLine(prevStr + "\"재귀함수는 자기 자신을 호출하는 함수라네\"");
            sb.AppendLine(prevStr + "라고 답변하였지.");
            return;
        }
        else
        {
            sb.AppendLine(prevStr + "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");
            sb.AppendLine(prevStr + "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");
            sb.AppendLine(prevStr + "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");
        }

        prevStr += "____";
        
        func(n - 1);
        prevStr = prevStr.Substring(0, prevStr.Length - 4);
        sb.AppendLine(prevStr + "라고 답변하였지.");
    }
}
