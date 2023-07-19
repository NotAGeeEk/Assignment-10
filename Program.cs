using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Document Management System");

        while (true)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Create a new file");
            Console.WriteLine("2. Read a file");
            Console.WriteLine("3. Append to a file");
            Console.WriteLine("4. Delete a file");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter file name: ");
                    string createFileName = Console.ReadLine();
                    Console.Write("Enter content: ");
                    string createContent = Console.ReadLine();
                    CreateFile(createFileName, createContent);
                    Console.WriteLine("File created successfully.");
                    break;

                case 2:
                    Console.Write("Enter file name to read: ");
                    string readFileName = Console.ReadLine();
                    ReadFile(readFileName);
                    break;

                case 3:
                    Console.Write("Enter file name to append: ");
                    string appendFileName = Console.ReadLine();
                    Console.Write("Enter content to append: ");
                    string appendContent = Console.ReadLine();
                    AppendToFile(appendFileName, appendContent);
                    Console.WriteLine("Content appended successfully.");
                    break;

                case 4:
                    Console.Write("Enter file name to delete: ");
                    string deleteFileName = Console.ReadLine();
                    DeleteFile(deleteFileName);
                    Console.WriteLine("File deleted successfully.");
                    break;

                case 5:
                    Console.WriteLine("Exiting the application...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateFile(string fileName, string content)
    {
        File.WriteAllText(fileName, content);
    }

    static void ReadFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine("File Content:");
            Console.WriteLine(fileContent);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    static void AppendToFile(string fileName, string content)
    {
        File.AppendAllText(fileName, content);
    }

    static void DeleteFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}