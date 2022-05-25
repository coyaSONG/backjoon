using System;
using System.IO;

class Program
{
    static int[] arrN;
    static void Main()
    {
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        int N = int.Parse(sr.ReadLine());
        arrN = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
        Array.Sort(arrN);
        
        string M = sr.ReadLine();
        int[] arrM = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
        
        foreach(var item in arrM)
            sw.Write(up_bnd(item)-lo_bnd(item) + " ");
        
        sr.Close();
        sw.Flush();
        sw.Close();
    }
    
    static int lo_bnd(int num)
    {
        int start = 0, end = arrN.Length;
        int mid = 0;
        while(start<end)
        {
            mid = start + (end-start)/2;
            if(num <= arrN[mid]) end = mid;
            else start = mid + 1;
        }
        return start;
    }
    
    static int up_bnd(int num)
    {
        int start = 0, end = arrN.Length;
        int mid = 0;
        while(start<end)
        {
            mid = start + (end-start)/2;
            if(num >= arrN[mid]) start = mid+1;
            else end = mid;
        }
        return start;
    }
}
