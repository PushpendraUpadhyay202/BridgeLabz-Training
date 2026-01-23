using System;
using System.IO;
class FileNotFoundException
{
    static void Main(string[] args)
    {
        try
        {
            string content = File.ReadAllText("data.txt");
            Console.WriteLine(content);
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
