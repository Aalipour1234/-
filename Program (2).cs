using System;

class Program
{
    static void Main()
    {
        // تعریف متغیر برای ذخیره جمع اعداد
        int sum = 0;

        Console.WriteLine("Enter 10 number:");

        // حلقه برای دریافت 10 عدد
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"number {i}: ");

            // دریافت عدد از کاربر
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("invalid input . please enter a valid integar:");
            }

            // اضافه کردن عدد به جمع
            sum += number;
        }

        // نمایش جمع اعداد
        Console.WriteLine($"sum of the enterded number is: {sum}");
    }
}
