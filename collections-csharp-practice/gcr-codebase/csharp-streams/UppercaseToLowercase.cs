using System;
using System.IO;
using System.Text;

class UppercaseToLowercase
{
    static void Main()
    {
        string sourceFile = "input.txt";
        string destinationFile = "output.txt";

        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Source file not found.");
            return;
        }

        FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
        FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write);

        BufferedStream bufferedRead = new BufferedStream(fsRead);
        BufferedStream bufferedWrite = new BufferedStream(fsWrite);

        StreamReader reader = new StreamReader(bufferedRead, Encoding.UTF8);
        StreamWriter writer = new StreamWriter(bufferedWrite, Encoding.UTF8);

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            writer.WriteLine(line.ToLower());
        }

        writer.Flush();

        reader.Close();
        writer.Close();
        bufferedRead.Close();
        bufferedWrite.Close();
        fsRead.Close();
        fsWrite.Close();

        Console.WriteLine("File converted successfully.");
    }
}
