using System;

class AssignmentCourse : CourseType
{
    private int assignmentCount;

    public AssignmentCourse(int assignmentCount)
    {
        this.assignmentCount = assignmentCount;
    }

    public override void Evaluate()
    {
        Console.WriteLine("Assignments: " + assignmentCount);
    }
}
