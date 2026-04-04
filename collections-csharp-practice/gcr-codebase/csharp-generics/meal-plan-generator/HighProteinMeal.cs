using System;

class HighProteinMeal : IMealPlan
{
    private int protein;

    public HighProteinMeal(int protein)
    {
        this.protein = protein;
    }

    public void ShowDetails()
    {
        Console.WriteLine(
            "High Protein Meal | Protein: " + protein + "g");
    }
}
