using System;
using System.Reflection;

class Student
{
    public string Name;
    public int Age;

    public Student()
    {
        Name = "Unknown";
        Age = 0;
    }
}

class DynamicObjectCreation
{
    static void Main()
    {
        Type type = typeof(Student);
        object obj = Activator.CreateInstance(type);

        Student student = (Student)obj;
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Age);
    }
}
