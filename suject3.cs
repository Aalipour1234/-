//این کلاس برای ذخیره اطلاعات هر شخص طراحی شده و سه تا خصوصیت داره
//1- name
//2- Email
//3- ID
// people list : لیستی از نوع (person) برای ذخیره اطلاعات 
//ورودی کاربر: دریافت افراد مورد نظر از کاربر  و وارد کردن اطلاعات 
// خروجی کاربر : اطلاعات افراد وارد شده نمایش داده میشود
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // لیستی برای ذخیره اطلاعات افراد
        List<Person> people = new List<Person>();

        Console.WriteLine("How many people do you want to enter ?");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\n personal information {i + 1}:");

            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("ID: ");
            string id = Console.ReadLine();

            // ذخیره اطلاعات در لیست
            people.Add(new Person { Name = name, Email = email, ID = id });
        }

        // نمایش اطلاعات وارد شده
        Console.WriteLine("\n Enterred personal infomation:");
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Email: {person.Email}, ID: {person.ID}");
        }

        Console.WriteLine("\n Press key to exit" +
            "...");
        Console.ReadKey();
    }
}

// تعریف کلاس برای ذخیره اطلاعات شخص
class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string ID { get; set; }
}