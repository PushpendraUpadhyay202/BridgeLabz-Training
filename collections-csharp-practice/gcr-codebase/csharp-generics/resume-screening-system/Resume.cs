class Resume<T> where T : JobRole
{
    private T jobRole;

    public Resume(T jobRole)
    {
        this.jobRole = jobRole;
    }

    public void Process()
    {
        jobRole.Evaluate();
    }
}
