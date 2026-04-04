using System;

class VeganMeal : IMealPlan
{
    private int calories;

    public VeganMeal(int calories)
    {
        this.calories = calories;
    }

    public void ShowDetails()
    {
        Console.WriteLine(
            "Vegan Meal | Calories: " + calories);
    }
}
