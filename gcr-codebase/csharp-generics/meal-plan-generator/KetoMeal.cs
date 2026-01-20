using System;

class KetoMeal : IMealPlan
{
    private int fat;

    public KetoMeal(int fat)
    {
        this.fat = fat;
    }

    public void ShowDetails()
    {
        Console.WriteLine(
            "Keto Meal | Fat: " + fat + "g");
    }
}
