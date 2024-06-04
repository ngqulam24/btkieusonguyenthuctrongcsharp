using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double[] arr = new double[100];
        int n;
        double sum = 0, avg;

        Console.Write("Nhập số lượng phần tử: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập {0} số thực (8 byte):", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
            sum += arr[i];
        }

        avg = sum / n;

        Console.WriteLine("Trung bình cộng của các số trong mảng: {0}", avg);
    }
}