using System;
using System.Collections.Generic;

class Utility
{
    private List<Course<CourseType>> courses =
        new List<Course<CourseType>>();

    public void AddExamCourse()
    {
        Console.Write("Course name: ");
        string name = Console.ReadLine();

        Console.Write("Exam duration: ");
        int duration = int.Parse(Console.ReadLine());

        ExamCourse examCourse = new ExamCourse(duration);
        Course<CourseType> course =
            new Course<CourseType>(name, examCourse);

        courses.Add(course);
    }

    public void AddAssignmentCourse()
    {
        Console.Write("Course name: ");
        string name = Console.ReadLine();

        Console.Write("Number of assignments: ");
        int count = int.Parse(Console.ReadLine());

        AssignmentCourse assignmentCourse =
            new AssignmentCourse(count);

        Course<CourseType> course =
            new Course<CourseType>(name, assignmentCourse);

        courses.Add(course);
    }

    public void DisplayCourses()
    {
        foreach (Course<CourseType> course in courses)
        {
            course.Display();
        }
    }
}
