using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    public void Display() => Console.WriteLine($"ID: {ID}, Name: {Name}, Marks: {Marks}");
}

class Program
{
    static List<Student> students = new();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1.Add  2.DisplayAll  3.Search  4.Remove  5.Topper  6.Exit");
            Console.Write("Choice: ");
            if (!int.TryParse(Console.ReadLine(), out int ch)) continue;

            switch (ch)
            {
                case 1: Add(); break;
                case 2: DisplayAll(); break;
                case 3: Search(); break;
                case 4: Remove(); break;
                case 5: Topper(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    static void Add()
    {
        Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
        if (students.Any(s => s.ID == id)) { Console.WriteLine("ID exists!"); return; }
        Console.Write("Name: "); string name = Console.ReadLine();
        Console.Write("Marks: "); double marks = double.Parse(Console.ReadLine());
        students.Add(new Student { ID = id, Name = name, Marks = marks });
        Console.WriteLine("Added!");
    }

    static void DisplayAll()
    {
        if (students.Count == 0) Console.WriteLine("No students!");
        else students.ForEach(s => s.Display());
    }

    static void Search()
    {
        Console.Write("Enter ID: "); int id = int.Parse(Console.ReadLine());
        var s = students.FirstOrDefault(x => x.ID == id);
        Console.WriteLine(s == null ? "Not found!" : $"Found: ID={s.ID}, Name={s.Name}, Marks={s.Marks}");
    }

    static void Remove()
    {
        Console.Write("Enter ID: "); int id = int.Parse(Console.ReadLine());
        var s = students.FirstOrDefault(x => x.ID == id);
        if (s == null) Console.WriteLine("Not found!");
        else { students.Remove(s); Console.WriteLine("Removed!"); }
    }

    static void Topper()
    {
        if (students.Count == 0) Console.WriteLine("No students!");
        else students.OrderByDescending(s => s.Marks).First().Display();
    }
}
