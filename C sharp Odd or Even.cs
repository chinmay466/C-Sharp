using System;
namespace square
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Invalid number");
                return;
            }
            Console.WriteLine($"{num} = {num*num}");
        }

    }
}





