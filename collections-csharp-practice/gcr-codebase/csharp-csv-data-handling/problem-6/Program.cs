using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputPath = "employees.csv";
        string outputPath = "employees_updated.csv";

        StreamReader reader = new StreamReader(inputPath);
        StreamWriter writer = new StreamWriter(outputPath);

        string line;
        bool isHeader = true;

        while ((line = reader.ReadLine()) != null)
        {
            if (isHeader)
            {
                writer.WriteLine(line);
                isHeader = false;
                continue;
            }

            string[] parts = line.Split(',');

            int id = int.Parse(parts[0]);
            string name = parts[1];
            string department = parts[2];
            double salary = double.Parse(parts[3]);

            if (department == "IT")
            {
                salary = salary + (salary * 0.10);
            }

            writer.WriteLine(id + "," + name + "," + department + "," + salary);
        }

        reader.Close();
        writer.Close();
    }
}
