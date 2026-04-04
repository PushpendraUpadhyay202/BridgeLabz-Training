using System;

public class Bonus
{
    public static void Main(string[] args)
    {
        int numberOfEmployees = 10;
        double[] salaries = new double[numberOfEmployees];
        double[] yearOfService = new double[numberOfEmployees];

        double[] bonuses = new double[numberOfEmployees];
        double[] newSalaries = new double[numberOfEmployees];

        double totalbonus = 0;
        double totaloldSalary = 0;
        double totalnewSalary = 0;

        //Taking input for salaries and years of service
        for(int i=0; i< numberOfEmployees; i++)
        {
            Console.WriteLine("Enter the salary of employee "+ (i+1) + ":");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the years Of Service of employee "+ (i+1) + ":");
            double years = double.Parse(Console.ReadLine());

            if(salary <= 0 || years <= 0)
            {
                Console.WriteLine("Invalid input. Please enter again.");
                i--;
                continue;
            }

            salaries[i] = salary;
            yearOfService[i] = years;
        }


        for(int i = 0; i < numberOfEmployees; i++)
        {
            if(yearOfService[i] > 5)
            {
                bonuses[i] = salaries[i] * 0.05;
            }
            else
            {
                bonuses[i] = salaries[i] * 0.02;
            }

            newSalaries[i] = salaries[i] + bonuses[i];

            totalbonus += bonuses[i];
            totaloldSalary += salaries[i];
            totalnewSalary += newSalaries[i];
        }

        Console.WriteLine("Total Old Salary  : " + totaloldSalary);
        Console.WriteLine("Total Bonus Paid  : " + totalbonus);
        Console.WriteLine("Total New Salary  : " + totalnewSalary);
        


    }
}