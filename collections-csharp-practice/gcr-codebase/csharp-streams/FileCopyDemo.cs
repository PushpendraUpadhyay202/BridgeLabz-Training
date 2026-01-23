using System;
using System.IO;

class FileCopyDemo
{
    static void Main(string[] args)
    {
        string sourcePath = "file-copy-demo-source.txt";
        string destinationPath = "file-copy-demo-destination.txt";

        // Avoid IOException by checking first
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        FileStream sourceStream = new FileStream(
            sourcePath,
            FileMode.Open,
            FileAccess.Read
        );

        FileStream destinationStream = new FileStream(
            destinationPath,
            FileMode.Create,
            FileAccess.Write
        );

        int data;
        while ((data = sourceStream.ReadByte()) != -1)
        {
            destinationStream.WriteByte((byte)data);
        }

        sourceStream.Close();
        destinationStream.Close();

        Console.WriteLine("File copied successfully.");
    }
}
