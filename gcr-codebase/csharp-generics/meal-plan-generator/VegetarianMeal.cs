using System;

class VegetarianMeal : IMealPlan
{
    private int calories;

    public VegetarianMeal(int calories)
    {
        this.calories = calories;
    }

    public void ShowDetails()
    {
        Console.WriteLine(
            "Vegetarian Meal | Calories: " + calories);
    }
}
