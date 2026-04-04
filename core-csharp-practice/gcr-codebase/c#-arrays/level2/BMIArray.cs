using System;

class BMIArray
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());  // number of persons

        double[] weight = new double[n]; // weight array
        double[] height = new double[n]; // height array
        double[] bmi = new double[n];    // BMI array
        string[] status = new string[n];  // BMI status

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter weight (kg): ");
            weight[i] = double.Parse(Console.ReadLine());

            Console.Write("Enter height (m): ");
            height[i] = double.Parse(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);  // calculating the bmi using this formula

            if (bmi[i] < 18.5) status[i] = "Underweight";
            else if (bmi[i] < 25) status[i] = "Normal";
            else if (bmi[i] < 30) status[i] = "Overweight";
            else status[i] = "Obese";
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Weight: "+ weight[i] +", Height: "+ height[i] +", BMI: "+ bmi[i] +", Status: "+ status[i]);
        }
    }
}
