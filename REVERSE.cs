using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int reversedNumber = 0;
        int original = number;

        while (number != 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        Console.WriteLine($"Reversed number: {reversedNumber}");
    }
}
