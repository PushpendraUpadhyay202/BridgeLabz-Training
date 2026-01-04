using System;

class Student{
    public int rollNumber;
    protected string name;
    private float CGPA;

    internal Student(int rollNumber, string name, float CGPA){
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    public float GetCGPA(){
        return CGPA;
    }

    public void SetCGPA(float CGPA){
        this.CGPA = CGPA;
        Console.WriteLine("\nCGPA Updated");
    }

    internal void DisplayStudentDetails(){
        Console.WriteLine("\nGiven below are the student details: ");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("CGPA: " + CGPA);
    }
}

class PostGraduateStudent : Student{
    private string courseName;

    internal PostGraduateStudent(string courseName, string name): base(0, name, 0.0f){
        this.courseName = courseName;
    }

    internal void DisplayPostGraduateStudentName(){
        Console.WriteLine("\nGiven below are the post graduate student details: ");
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Course Name: " + this.courseName);
    }
}

class UniversityManagementSystem{
    static void Main(string[] args){
        Student student1 = new Student(1, "Amit", 8.0f);
        PostGraduateStudent postGraduateStudent1 = new PostGraduateStudent("M-Tech", "Rohit");

        student1.DisplayStudentDetails();
        postGraduateStudent1.DisplayPostGraduateStudentName();

        student1.SetCGPA(8.5f);

        student1.DisplayStudentDetails();
    }
}

