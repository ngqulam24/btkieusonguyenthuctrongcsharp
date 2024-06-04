using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ulong num;

        Console.Write("Nhập một số nguyên dương không dấu (8 byte): ");
        num = ulong.Parse(Console.ReadLine());

        if (IsPalindrome(num))
        {
            Console.WriteLine("{0} là số Palindrome.", num);
        }
        else
        {
            Console.WriteLine("{0} không phải là số Palindrome.", num);
        }
    }

    static bool IsPalindrome(ulong num)
    {
        ulong originalNum = num;
        ulong reversedNum = 0;

        while (num > 0)
        {
            reversedNum = reversedNum * 10 + (num % 10);
            num /= 10;
        }

        return originalNum == reversedNum;
    }
}