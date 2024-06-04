using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        sbyte[] arr = new sbyte[100];
        int n;
        sbyte max, min;

        Console.Write("Nhập số lượng phần tử: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập {0} số nguyên có dấu (1 byte):", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = sbyte.Parse(Console.ReadLine());
        }

        max = sbyte.MinValue;
        min = sbyte.MaxValue;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine("Số lớn nhất: {0}", max);
        Console.WriteLine("Số nhỏ nhất: {0}", min);
    }
}