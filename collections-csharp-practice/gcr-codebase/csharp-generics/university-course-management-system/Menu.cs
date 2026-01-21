using System;

class Menu
{
    private Utility utility = new Utility();

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- University Course Management ---");
            Console.WriteLine("1. Add Exam Course");
            Console.WriteLine("2. Add Assignment Course");
            Console.WriteLine("3. Display Courses");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.AddExamCourse();
                    break;

                case 2:
                    utility.AddAssignmentCourse();
                    break;

                case 3:
                    utility.DisplayCourses();
                    break;

                case 4:
                    return;
            }
        }
    }
}
