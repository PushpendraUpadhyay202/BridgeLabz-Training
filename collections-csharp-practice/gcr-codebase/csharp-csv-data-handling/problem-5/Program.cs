using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "employees.csv";
        StreamReader reader = new StreamReader(path);
        string line;
        bool isHeader = true;
        string searchName = "Manish";
        bool found = false;

        while ((line = reader.ReadLine()) != null)
        {
            if (isHeader)
            {
                isHeader = false;
                continue;
            }

            string[] parts = line.Split(',');

            if (parts[1] == searchName)
            {
                Console.WriteLine("Department: " + parts[2]);
                Console.WriteLine("Salary: " + parts[3]);
                found = true;
                break;
            }
        }

        reader.Close();

        if (!found)
        {
            Console.WriteLine("Employee not found");
        }
    }
}
