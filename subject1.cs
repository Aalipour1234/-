//Increase the number a to the power of b and get the output
using System;

class Program
{
    static void Main(string[] args)
    {
        // Get input for a
        Console.Write("Enter the base number (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        // Get input for b
        Console.Write("Enter the exponent (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Calculate the power
        double result = Math.Pow(a, b);

        // Display the result
        Console.WriteLine($"The result of {a} raised to the power of {b} is: {result}");

        // Wait for user to press a key before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
