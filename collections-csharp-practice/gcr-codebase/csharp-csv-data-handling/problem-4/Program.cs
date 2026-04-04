using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "students.csv";
        StreamReader reader = new StreamReader(path);
        string line;
        bool isHeader = true;

        while ((line = reader.ReadLine()) != null)
        {
            if (isHeader)
            {
                isHeader = false;
                continue;
            }

            string[] parts = line.Split(',');

            int marks = int.Parse(parts[3]);

            if (marks > 80)
            {
                Console.WriteLine("ID: " + parts[0]);
                Console.WriteLine("Name: " + parts[1]);
                Console.WriteLine("Age: " + parts[2]);
                Console.WriteLine("Marks: " + parts[3]);
                Console.WriteLine("-----");
            }
        }

        reader.Close();
    }
}
