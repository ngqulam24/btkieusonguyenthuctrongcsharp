using System;

class Program
{
    static void Main(string[] args)
    {
        short[] arr = new short[100];
        int n;
        short sum = 0;

        Console.Write("Nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap {0} so nguyen co dau (2 byte):", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = short.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Tong cac so trong mang: {0}", sum);
    }
}
