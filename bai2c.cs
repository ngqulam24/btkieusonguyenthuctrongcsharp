using System;

class Program
{
    static void Main(string[] args){
        
        byte n;
        uint sum = 0;

        Console.Write("Nhap so nguyen duong (1 byte): ");
        n = byte.Parse(Console.ReadLine());

        for (byte i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Tong cac so tu 1 den {0} la: {1}", n, sum);
    }
}