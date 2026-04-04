using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string path = "employees.csv";
        StreamReader reader = new StreamReader(path);

        List<string[]> records = new List<string[]>();
        string line;
        bool isHeader = true;

        while ((line = reader.ReadLine()) != null)
        {
            if (isHeader)
            {
                isHeader = false;
                continue;
            }

            records.Add(line.Split(','));
        }

        reader.Close();

        for (int i = 0; i < records.Count - 1; i++)
        {
            for (int j = i + 1; j < records.Count; j++)
            {
                double salary1 = double.Parse(records[i][3]);
                double salary2 = double.Parse(records[j][3]);

                if (salary2 > salary1)
                {
                    string[] temp = records[i];
                    records[i] = records[j];
                    records[j] = temp;
                }
            }
        }

        int limit = 5;
        if (records.Count < 5)
        {
            limit = records.Count;
        }

        for (int i = 0; i < limit; i++)
        {
            Console.WriteLine("ID: " + records[i][0]);
            Console.WriteLine("Name: " + records[i][1]);
            Console.WriteLine("Department: " + records[i][2]);
            Console.WriteLine("Salary: " + records[i][3]);
            Console.WriteLine("-----");
        }
    }
}
