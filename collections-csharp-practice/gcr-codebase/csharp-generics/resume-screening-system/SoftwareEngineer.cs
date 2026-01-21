using System;

class SoftwareEngineer : JobRole
{
    private int experience;

    public SoftwareEngineer(string candidateName, int experience)
        : base(candidateName)
    {
        this.experience = experience;
    }

    public override void Evaluate()
    {
        Console.WriteLine(
            "Software Engineer: " +
            candidateName +
            " | Experience: " +
            experience + " years");
    }
}
