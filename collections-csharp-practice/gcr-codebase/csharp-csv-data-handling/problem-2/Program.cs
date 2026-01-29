using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "students.csv";
        StreamReader reader = new StreamReader(path);
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');

            int id = int.Parse(parts[0]);
            string name = parts[1];
            int age = int.Parse(parts[2]);
            int marks = int.Parse(parts[3]);

            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Marks: " + marks);
            Console.WriteLine("-----");
        }

        reader.Close();
    }
}
