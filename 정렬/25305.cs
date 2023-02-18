using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    string[] input = Console.ReadLine().Split();
    int n = int.Parse(input[0]);
    int k = int.Parse(input[1]);

    int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Array.Sort(scores);
    Array.Reverse(scores);

    int cutoff = scores[k-1];
    Console.WriteLine(cutoff);
  }
}
