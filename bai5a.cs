using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        float[] arr = new float[100];
        int n;
        float max, min;

        Console.Write("Nhập số lượng phần tử: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập {0} số thực (4 byte):", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = float.Parse(Console.ReadLine());
        }

        max = arr[0];
        min = arr[0];

        for (int i = 1; i < n; i++)
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

        Console.WriteLine("Giá trị lớn nhất: {0}", max);
        Console.WriteLine("Giá trị nhỏ nhất: {0}", min);
    }
}