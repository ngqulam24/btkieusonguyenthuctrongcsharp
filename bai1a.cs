using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int a, b;

        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên a (4 byte): ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhập số nguyên b (4 byte): ");
                b = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số nguyên hợp lệ.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Lỗi: Số vượt quá giới hạn của kiểu int (4 byte).");
            }
        }

        Console.WriteLine("Tổng: " + (a + b));
        Console.WriteLine("Hiệu: " + (a - b));
        Console.WriteLine("Tích: " + (a * b));
        Console.WriteLine("Thương (số nguyên): " + (a / b));
        Console.WriteLine("Thương (số thực): " + ((float)a / b));
    }
}