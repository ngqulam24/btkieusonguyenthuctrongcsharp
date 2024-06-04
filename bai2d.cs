using System;

class Program
{
    static void Main(string[] args)
    {
        byte num;
        byte sum = 0;

        Console.Write("Nhap so nguyen duong (1 byte): ");
        num = byte.Parse(Console.ReadLine());

        while (num != 0)
        {
            sum += (byte)(num % 10);
            num /= 10;
        }

        Console.WriteLine("Tong cac chu so: {0}", sum);
    }
}