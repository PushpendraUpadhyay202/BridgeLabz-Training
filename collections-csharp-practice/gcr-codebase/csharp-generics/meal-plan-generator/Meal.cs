using System;

class Meal<T> where T : IMealPlan
{
    private T plan;

    public Meal(T plan)
    {
        this.plan = plan;
    }

    public void Display()
    {
        plan.ShowDetails();
    }
}
