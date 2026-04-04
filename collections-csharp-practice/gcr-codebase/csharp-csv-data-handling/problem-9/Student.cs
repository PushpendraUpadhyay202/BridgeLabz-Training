class Student
{
    public int Id;
    public string Name;
    public int Age;
    public int Marks;

    public Student(int id, string name, int age, int marks)
    {
        Id = id;
        Name = name;
        Age = age;
        Marks = marks;
    }

    public void Print()
    {
        System.Console.WriteLine("ID: " + Id);
        System.Console.WriteLine("Name: " + Name);
        System.Console.WriteLine("Age: " + Age);
        System.Console.WriteLine("Marks: " + Marks);
        System.Console.WriteLine("-----");
    }
}
