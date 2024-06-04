using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        sbyte[] arr = new sbyte[100];
        int n, sum = 0;

        Console.Write("Nhập số lượng phần tử: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập {0} số nguyên có dấu (1 byte):", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = sbyte.Parse(Console.ReadLine());
            if (arr[i] % 2 == 0)
            {
                sum += arr[i];
            }
        }

        Console.WriteLine("Tổng các số chẵn: {0}", sum);
    }
}