using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        long[] arr = new long[100];
        int n;
        long sum = 0;

        Console.Write("Nhập số lượng phần tử: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập {0} số nguyên có dấu (8 byte):", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Tổng các số trong mảng: {0}", sum);
    }
}