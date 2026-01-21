using System;
using System.Collections.Generic;

class Utility
{
    private List<Resume<JobRole>> resumes =
        new List<Resume<JobRole>>();

    public void AddSoftwareEngineerResume()
    {
        Console.Write("Candidate name: ");
        string name = Console.ReadLine();

        Console.Write("Years of experience: ");
        int experience = int.Parse(Console.ReadLine());

        SoftwareEngineer role =
            new SoftwareEngineer(name, experience);

        Resume<JobRole> resume =
            new Resume<JobRole>(role);

        resumes.Add(resume);
    }

    public void AddDataScientistResume()
    {
        Console.Write("Candidate name: ");
        string name = Console.ReadLine();

        Console.Write("Projects completed: ");
        int projects = int.Parse(Console.ReadLine());

        DataScientist role =
            new DataScientist(name, projects);

        Resume<JobRole> resume =
            new Resume<JobRole>(role);

        resumes.Add(resume);
    }

    public void ScreenAllResumes()
    {
        foreach (Resume<JobRole> resume in resumes)
        {
            Screen(resume);
        }
    }

    private void Screen<T>(Resume<T> resume)
        where T : JobRole
    {
        resume.Process();
    }
}
