using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] arr;
        int n, sum = 0;

        Console.Write("Nhập số phần tử của mảng: ");
        n = int.Parse(Console.ReadLine());

        arr = new int[n];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phần tử {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Tổng các số trong mảng: " + sum);
    }
}
