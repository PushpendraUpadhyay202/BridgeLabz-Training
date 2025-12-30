using System;

public class TemperatureAnalyzer
{
    // ============================== DATA =================================
    int numberOfDays = 7;            // Change to 30 if needed
    int numberOfHours = 24;

    int[,] temperature;
    double[] avgTemperaturePerDay;

    string[] daysOfTheWeek =
    {
        "Sunday", "Monday", "Tuesday",
        "Wednesday", "Thursday", "Friday", "Saturday"
    };

    // ============================== MAIN =================================
    public static void Main(string[] args)
    {
        TemperatureAnalyzer obj = new TemperatureAnalyzer();
        obj.Initialize();
        obj.CalculateAverageTemperaturePerDay();
        obj.Menu();
    }

    // ============================ INITIALIZE ==============================
    void Initialize()
    {
        temperature = new int[numberOfDays, numberOfHours];
        avgTemperaturePerDay = new double[numberOfDays];
        FillData();
    }

    // ============================== FILL DATA =============================
    void FillData()
    {
        Random random = new Random();

        for (int i = 0; i < numberOfDays; i++)
        {
            for (int j = 0; j < numberOfHours; j++)
            {
                temperature[i, j] = random.Next(8, 51);
            }
        }
    }

    // ============================== MENU ==================================
    void Menu()
    {
        while (true)
        {
            Console.WriteLine("\n-------------------- MENU --------------------");
            Console.WriteLine("1. Show Temperatures");
            Console.WriteLine("2. Find Hottest & Coldest Temperature (Per Day)");
            Console.WriteLine("3. Show Average Temperature Per Day");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    PrintTemperature();
                    break;

                case 2:
                    PrintHottestAndColdestPerDay();
                    break;

                case 3:
                    PrintAverageTemperaturePerDay();
                    break;

                case 4:
                    Console.WriteLine("Exiting Program...");
                    return;

                default:
                    Console.WriteLine("Invalid Option! Choose 1–4 only.");
                    break;
            }
        }
    }

    // ======================== PRINT TEMPERATURE ===========================
    void PrintTemperature()
    {
        Console.WriteLine("\nTemperature Report (Day x Hour)");
        Console.WriteLine("----------------------------------------------");

        for (int i = 0; i < numberOfDays; i++)
        {
            Console.Write("Day " + (i + 1) + " (" + daysOfTheWeek[i % 7] + "): ");

            for (int j = 0; j < numberOfHours; j++)
            {
                Console.Write(temperature[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // ================== CALCULATE AVERAGE TEMP ============================
    void CalculateAverageTemperaturePerDay()
    {
        for (int i = 0; i < numberOfDays; i++)
        {
            int sum = 0;

            for (int j = 0; j < numberOfHours; j++)
            {
                sum += temperature[i, j];
            }

            avgTemperaturePerDay[i] = (double)sum / numberOfHours;
        }
    }

    // ================== PRINT AVERAGE TEMP ================================
    void PrintAverageTemperaturePerDay()
    {
        Console.WriteLine("\nAverage Temperature Per Day");
        Console.WriteLine("--------------------------------");

        for (int i = 0; i < numberOfDays; i++)
        {
            Console.WriteLine(
                "Day " + (i + 1) + " (" + daysOfTheWeek[i % 7] + ") : " + avgTemperaturePerDay[i].ToString("F2") + "°C"
            );
        }
    }

    // ================= HOTTEST & COLDEST PER DAY ==========================
    void PrintHottestAndColdestPerDay()
    {
        Console.WriteLine("\nHottest and Coldest Temperature Per Day");
        Console.WriteLine("--------------------------------------------");

        for (int i = 0; i < numberOfDays; i++)
        {
            int hottest = temperature[i, 0];
            int coldest = temperature[i, 0];

            for (int j = 0; j < numberOfHours; j++)
            {
                if (temperature[i, j] > hottest)
                    hottest = temperature[i, j];

                if (temperature[i, j] < coldest)
                    coldest = temperature[i, j];
            }

            Console.WriteLine(
                "Day " + (i + 1) + " (" + daysOfTheWeek[i % 7] + ") -> Hottest: " + hottest + "°C , Coldest: " + coldest + "°C"
            );
        }
    }
}
