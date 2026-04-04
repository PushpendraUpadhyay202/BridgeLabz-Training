using System;
using System.IO;

class PrimitiveDataStorage
{
    static void Main()
    {
        string filePath = "student.dat";

        int rollNo = 101;
        string name = "Gaurav";
        double gpa = 8.6;

        FileStream fsWrite = new FileStream(filePath, FileMode.Create);
        BinaryWriter writer = new BinaryWriter(fsWrite);

        writer.Write(rollNo);
        writer.Write(name);
        writer.Write(gpa);

        writer.Close();
        fsWrite.Close();

        FileStream fsRead = new FileStream(filePath, FileMode.Open);
        BinaryReader reader = new BinaryReader(fsRead);

        int r = reader.ReadInt32();
        string n = reader.ReadString();
        double g = reader.ReadDouble();

        reader.Close();
        fsRead.Close();

        Console.WriteLine("Roll No: " + r);
        Console.WriteLine("Name: " + n);
        Console.WriteLine("GPA: " + g);
    }
}
