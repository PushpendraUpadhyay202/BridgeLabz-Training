using System;

class Bonus
{
    public static void Main()
    {
        Random random = new Random();
        double totalBonus = 0;
        int numberOfEmployees = 10;

        Console.WriteLine("Employee Salary | Years | Bonus");

        for (int i = 0; i < numberOfEmployees; i++)
        {
            // Generate random salary between 10,000 and 99,999
            double salary = random.Next(10000, 100000); // 100000 is exclusive

            // Generate random years of service between 1 and 10
            int years = random.Next(1, 11);

            // Calculate bonus: 5% if years > 5, else 2%
            double bonus = years > 5 ? salary * 0.05 : salary * 0.02;

            // Add bonus to total
            totalBonus += bonus;

            // Display individual employee details
            Console.WriteLine(salary + "\t" + years + "\t" + Math.Round(bonus, 2));
        }

        // Display total bonus
        Console.WriteLine("\nTotal Bonus for all employees: " + Math.Round(totalBonus, 2));
    }
}
