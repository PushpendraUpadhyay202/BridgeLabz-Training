using System;

class Menu
{
    private Utility utility = new Utility();

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Meal Plan Generator ---");
            Console.WriteLine("1. Vegetarian Meal");
            Console.WriteLine("2. Vegan Meal");
            Console.WriteLine("3. Keto Meal");
            Console.WriteLine("4. High Protein Meal");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.GenerateVegetarianMeal();
                    break;

                case 2:
                    utility.GenerateVeganMeal();
                    break;

                case 3:
                    utility.GenerateKetoMeal();
                    break;

                case 4:
                    utility.GenerateHighProteinMeal();
                    break;

                case 5:
                    return;
            }
        }
    }
}
