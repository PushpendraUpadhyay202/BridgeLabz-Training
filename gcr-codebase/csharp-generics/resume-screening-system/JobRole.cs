abstract class JobRole
{
    protected string candidateName;

    protected JobRole(string candidateName)
    {
        this.candidateName = candidateName;
    }

    public abstract void Evaluate();
}
