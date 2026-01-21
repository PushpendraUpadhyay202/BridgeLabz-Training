using System;

class Utility
{
    public void GenerateVegetarianMeal()
    {
        Console.Write("Calories: ");
        int calories = int.Parse(Console.ReadLine());

        VegetarianMeal plan = new VegetarianMeal(calories);
        Meal<VegetarianMeal> meal =
            new Meal<VegetarianMeal>(plan);

        GenerateMeal(meal);
    }

    public void GenerateVeganMeal()
    {
        Console.Write("Calories: ");
        int calories = int.Parse(Console.ReadLine());

        VeganMeal plan = new VeganMeal(calories);
        Meal<VeganMeal> meal =
            new Meal<VeganMeal>(plan);

        GenerateMeal(meal);
    }

    public void GenerateKetoMeal()
    {
        Console.Write("Fat grams: ");
        int fat = int.Parse(Console.ReadLine());

        KetoMeal plan = new KetoMeal(fat);
        Meal<KetoMeal> meal =
            new Meal<KetoMeal>(plan);

        GenerateMeal(meal);
    }

    public void GenerateHighProteinMeal()
    {
        Console.Write("Protein grams: ");
        int protein = int.Parse(Console.ReadLine());

        HighProteinMeal plan =
            new HighProteinMeal(protein);

        Meal<HighProteinMeal> meal =
            new Meal<HighProteinMeal>(plan);

        GenerateMeal(meal);
    }

    private void GenerateMeal<T>(Meal<T> meal)
        where T : IMealPlan
    {
        meal.Display();
    }
}
