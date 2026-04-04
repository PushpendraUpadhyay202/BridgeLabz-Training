using System;
using System.IO;

class UserInputStorage
{
    static void Main()
    {
        StreamReader reader = new StreamReader(Console.OpenStandardInput());

        Console.Write("Enter your name: ");
        string name = reader.ReadLine();

        Console.Write("Enter your age: ");
        string age = reader.ReadLine();

        Console.Write("Enter your favorite programming language: ");
        string language = reader.ReadLine();

        StreamWriter writer = new StreamWriter("user_info.txt");

        writer.WriteLine("Name: " + name);
        writer.WriteLine("Age: " + age);
        writer.WriteLine("Favorite Programming Language: " + language);

        writer.Close();
        reader.Close();

        Console.WriteLine("Data saved successfully.");
    }
}
