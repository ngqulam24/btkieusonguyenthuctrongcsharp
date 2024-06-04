using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        uint num;

        Console.Write("Nhập số nguyên không dấu (4 byte): ");
        num = uint.Parse(Console.ReadLine());

        uint reversedNum = 0;
        while (num > 0)
        {
            reversedNum = reversedNum * 10 + (num % 10);
            num /= 10;
        }

        Console.WriteLine("Số đảo ngược: " + reversedNum);
    }
}