using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        float[] arr = new float[100];
        int n;
        float sum = 0;

        Console.Write("Nhập số lượng phần tử: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập {0} số thực (4 byte):", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = float.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Tổng các số trong mảng: {0}", sum);
    }
}