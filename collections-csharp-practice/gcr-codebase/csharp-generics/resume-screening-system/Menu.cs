using System;

class Menu
{
    private Utility utility = new Utility();

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Resume Screening System ---");
            Console.WriteLine("1. Add Software Engineer Resume");
            Console.WriteLine("2. Add Data Scientist Resume");
            Console.WriteLine("3. Screen All Resumes");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.AddSoftwareEngineerResume();
                    break;

                case 2:
                    utility.AddDataScientistResume();
                    break;

                case 3:
                    utility.ScreenAllResumes();
                    break;

                case 4:
                    return;
            }
        }
    }
}
