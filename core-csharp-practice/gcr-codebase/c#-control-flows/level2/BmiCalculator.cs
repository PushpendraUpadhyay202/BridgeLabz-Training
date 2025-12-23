using System;

class BmiCalculator
{
    static void Main(string[] args)
    {
        double bodyWeight = double.Parse(Console.ReadLine());
        double heightInCm = double.Parse(Console.ReadLine());

        double heightInMeter = heightInCm / 100;
        double bmiResult = bodyWeight / (heightInMeter * heightInMeter);

        if (bmiResult < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmiResult < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (bmiResult < 40)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}
