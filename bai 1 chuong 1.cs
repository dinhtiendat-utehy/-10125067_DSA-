using System;
class Program
{
    static void Main()
    {
        Random rd = new Random();
        int[] A = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            A[ i ] = rd.Next(0,1001);
        }
        int Max = A[0];
        int Min = A[0];
        for (int i = 1; i < 1000; i++)
        {
            if (A[i] > Max)
            {
                Max = A[i];
            }
            if (A[i] < Min)
            {
                Min = A[i];
            }
        }
        Console.WriteLine("So lon nhat: " + Max);
        Console.WriteLine("So nho nhat:" + Min);
            
    }
}