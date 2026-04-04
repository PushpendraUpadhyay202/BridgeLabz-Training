using System;

class Person{
    protected string name;
    protected int age;

    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }

    public void DisplayBasicInfo(){
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Teacher : Person{
    private string subject;

    public Teacher(string name, int age, string subject): base(name, age){
        this.subject = subject;
    }

    public void DisplayRole(){
        Console.WriteLine("Role: Teacher");
        Console.WriteLine("Subject: " + subject);
    }
}

class Student : Person{
    private string grade;

    public Student(string name, int age, string grade): base(name, age){
        this.grade = grade;
    }

    public void DisplayRole(){
        Console.WriteLine("Role: Student");
        Console.WriteLine("Grade: " + grade);
    }
}

class Staff : Person{
    private string department;

    public Staff(string name, int age, string department): base(name, age){
        this.department = department;
    }

    public void DisplayRole(){
        Console.WriteLine("Role: Staff");
        Console.WriteLine("Department: " + department);
    }
}

class SchoolSystem{
    static void Main(string[] args){
        Teacher teacher = new Teacher("Mr. Sharma", 40, "Mathematics");
        Student student = new Student("Ananya", 16, "10th Grade");
        Staff staff = new Staff("Ramesh", 35, "Administration");

        teacher.DisplayBasicInfo();
        teacher.DisplayRole();

        Console.WriteLine();

        student.DisplayBasicInfo();
        student.DisplayRole();

        Console.WriteLine();

        staff.DisplayBasicInfo();
        staff.DisplayRole();
    }
}

