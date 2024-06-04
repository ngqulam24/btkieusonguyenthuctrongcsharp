using System;

class Program
{
    static void Main(string[] args)
    {
        ushort[] arr = new ushort[100];
        int n;
        ushort sum = 0;

        Console.Write("Nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap {0} so nguyen duong (2 byte):", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = ushort.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Tong cac so trong mang: {0}", sum);
    }
}