using System;

class Course<T> where T : CourseType
{
    private string courseName;
    private T courseType;

    public Course(string courseName, T courseType)
    {
        this.courseName = courseName;
        this.courseType = courseType;
    }

    public void Display()
    {
        Console.WriteLine("Course: " + courseName);
        courseType.Evaluate();
    }
}
