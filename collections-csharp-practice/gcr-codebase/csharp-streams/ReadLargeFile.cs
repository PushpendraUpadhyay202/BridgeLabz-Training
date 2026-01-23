using System;
using System.IO;

class ReadLargeFiles
{
    static void Main()
    {
        string filePath = "largefile.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        StreamReader reader = new StreamReader(filePath);

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine(line);
            }
        }

        reader.Close();
    }
}
