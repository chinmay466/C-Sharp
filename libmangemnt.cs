using System;
using System.Collections.Generic;

class Book
{
    public int ID { get; set; }
    public string Name { get; set; }
    public override string ToString() => $"ID: {ID}, Name: {Name}";
}

class Program
{
    static List<Book> library = new();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1.Add Book  2.Display  3.Search  4.Remove  5.Count  6.Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddBook(); break;
                case "2": DisplayBooks(); break;
                case "3": SearchBook(); break;
                case "4": RemoveBook(); break;
                case "5": Console.WriteLine($"Total books: {library.Count}"); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        if (library.Exists(b => b.ID == id)) { Console.WriteLine("ID exists!"); return; }
        Console.Write("Enter Name: ");
        library.Add(new Book { ID = id, Name = Console.ReadLine() });
        Console.WriteLine("Book added!");
    }

    static void DisplayBooks()
    {
        if (library.Count == 0) Console.WriteLine("No books.");
        else library.ForEach(b => Console.WriteLine(b));
    }

    static void SearchBook()
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        var book = library.Find(b => b.ID == id);
        Console.WriteLine(book != null ? book.ToString() : "Not found.");
    }

    static void RemoveBook()
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        if (library.RemoveAll(b => b.ID == id) > 0)
            Console.WriteLine("Book removed!");
        else
            Console.WriteLine("Not found.");
    }
}
