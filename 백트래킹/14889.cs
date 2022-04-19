using System;
using System.IO;

class Program
{
    
    static int N;
    static int[,] playerList;
    static bool[] visited;
    static int MIN = int.MaxValue;
    static int preNum = -1;
    
    static void Main()
    {
        using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
        {
            N = int.Parse(sr.ReadLine());
            playerList = new int[N,N];
            visited = new bool[N];
            for(int i=0;i<N;i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
                for(int j=0;j<N;j++)
                {
                    playerList[i,j] = input[j];
                }
            }    
        }
        
        DFS(0);
        
        using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
            sw.WriteLine(MIN);
    }
    
    static void DFS(int depth)
    {
        //방문을 N의 절반까지만 하면 나머지 방문 안한곳은 자연스럽게 상대팀 조합이 됨.
        if(depth == N / 2)
        {
            int startTeam = 0,linkTeam = 0;
            for(int i=0;i<N;i++)
            {
                for(int j=0;j<N;j++)
                {
                    if(i==j)continue;
                    if(visited[i]&&visited[j])
                        startTeam += playerList[i,j];
                    else if(!visited[i]&&!visited[j])
                        linkTeam += playerList[i,j];
                }
            }
            MIN = Math.Min(MIN,Math.Abs(startTeam-linkTeam));
            return;
        }
        
        // 깊이가 깊어질수록 오름차순으로 검색
        // ex) 1,2,3번과 2,1,3번은 어차피 같은 능력치 총합임.
        for(int i=preNum+1;i<N;i++)
        {
            if(visited[i]) continue;
            visited[i]=true;
            preNum=i;
            DFS(depth+1);
            visited[i]=false;
        }
    }
}
