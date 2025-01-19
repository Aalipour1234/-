using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 40; i += 2) // حلقه برای اعداد زوج
        {
            if (i == 8) // شرط برای چاپ نکردن عدد 8
                continue;

            if (i >= 30) // شرط برای چاپ نکردن اعداد زوج 30 به بعد
                break;

            Console.WriteLine(i); // چاپ عدد
        }
    }
}