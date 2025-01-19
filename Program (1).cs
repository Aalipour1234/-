// فضای نام سیسم
using System;

// تعریف کلاس با نام program
class Program
{
    // متد main
    static void Main(string[] args)
    {
        //اجرا در فضای کنسول
        Console.WriteLine("Please enter a number:");
        //دریافت مقدار ورودی از کنسول 
        string input = Console.ReadLine();
        //تایید شرایط if
        if (double.TryParse(input, out double number))
        {
            //محاسبه قدر مطلق عدد
            double absoluteValue = Math.Abs(number);
            //اگر مقدار وارد شده توسط کاربر قابل تبدیل به عدد نباشد، این قسمت اجرا می‌شود و پیامی به کاربر نمایش می‌دهد.
            Console.WriteLine($"The absolute value of {number} is: {absoluteValue}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}