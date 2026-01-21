using System;

class ExamCourse : CourseType
{
    private int duration;

    public ExamCourse(int duration)
    {
        this.duration = duration;
    }

    public override void Evaluate()
    {
        Console.WriteLine("Exam Duration: " + duration + " hours");
    }
}
