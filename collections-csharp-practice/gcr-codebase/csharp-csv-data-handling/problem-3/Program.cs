using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "data.csv";
        StreamReader reader = new StreamReader(path);
        string line;
        int count = 0;
        bool isHeader = true;

        while ((line = reader.ReadLine()) != null)
        {
            if (isHeader)
            {
                isHeader = false;
                continue;
            }

            count++;
        }

        reader.Close();

        Console.WriteLine("Total Records: " + count);
    }
}
