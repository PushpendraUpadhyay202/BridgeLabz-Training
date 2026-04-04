using System;

class Student{
    public static string universityName = "State University";
    private static int totalStudents = 0;

    public readonly int rollNumber;
    public string name;
    public char grade;

    public Student(string name, int rollNumber, char grade){
        this.name = name;
        this.rollNumber = rollNumber;
        this.grade = grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents(){
        Console.WriteLine("Total Students: " + totalStudents);
    }

    public void ShowStudent(object obj){
        if (obj is Student){
	    Console.WriteLine("Name: " + name);
	    Console.WriteLine("Roll Number: " + rollNumber);
	    Console.WriteLine("Grade: " + grade);
        }
    }
}

class UniversityStudentManagement{
    static void Main(string[] args){
        Student s = new Student("Neha", 45, 'A');
        s.ShowStudent(s);
        Student.DisplayTotalStudents();
    }
}
