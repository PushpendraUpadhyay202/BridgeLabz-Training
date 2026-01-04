using System;

class Course{
    protected string courseName;
    protected int duration;

    public Course(string courseName, int duration){
        this.courseName = courseName;
        this.duration = duration;
    }

    public virtual void DisplayDetails(){
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " hours");
    }
}

class OnlineCourse : Course{
    protected string platform;
    protected bool isRecorded;

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded): base(courseName, duration){
        this.platform = platform;
        this.isRecorded = isRecorded;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Platform: " + platform);
        Console.WriteLine("Recorded: " + (isRecorded ? "Yes" : "No"));
    }
}

class PaidOnlineCourse : OnlineCourse{
    private double fee;
    private double discount;

    public PaidOnlineCourse(
        string courseName, int duration, string platform, bool isRecorded, double fee, double discount): base(courseName, duration, platform, isRecorded){
        this.fee = fee;
        this.discount = discount;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Fee: ₹" + fee);
        Console.WriteLine("Discount: " + discount + "%");
        Console.WriteLine("Final Price: ₹" + (fee - (fee * discount / 100)));
    }
}

class EducationalCourseHierarchy{
    static void Main(string[] args){
        PaidOnlineCourse course = new PaidOnlineCourse("C# Fundamentals", 40, "Coursera", true, 5000, 20);

        course.DisplayDetails();
    }
}

