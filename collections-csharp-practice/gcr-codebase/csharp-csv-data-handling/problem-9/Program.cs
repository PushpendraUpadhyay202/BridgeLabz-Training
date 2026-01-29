using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "students.csv";
        StreamReader reader = new StreamReader(path);

        List<Student> students = new List<Student>();
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

            int id = int.Parse(parts[0]);
            string name = parts[1];
            int age = int.Parse(parts[2]);
            int marks = int.Parse(parts[3]);

            Student student = new Student(id, name, age, marks);
            students.Add(student);
        }

        reader.Close();

        int i = 0;
        while (i < students.Count)
        {
            students[i].Print();
            i++;
        }
    }
}
