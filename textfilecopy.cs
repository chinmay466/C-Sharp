using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourceFilePath = "source.txt";
        string destinationFilePath = "destination.txt"; 

        try
        {
            string content = File.ReadAllText(sourceFilePath);

            File.WriteAllText(destinationFilePath, content);

            Console.WriteLine("File copied successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Source file not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
