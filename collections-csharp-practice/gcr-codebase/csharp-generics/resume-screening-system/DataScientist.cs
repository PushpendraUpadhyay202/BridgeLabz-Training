using System;

class DataScientist : JobRole
{
    private int projects;

    public DataScientist(string candidateName, int projects)
        : base(candidateName)
    {
        this.projects = projects;
    }

    public override void Evaluate()
    {
        Console.WriteLine(
            "Data Scientist: " +
            candidateName +
            " | Projects: " +
            projects);
    }
}
