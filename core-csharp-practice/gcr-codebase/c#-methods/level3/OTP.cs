using System;

class OTP
{
    // Reuse a single Random object
    static Random random = new Random();

    public static void Main()
    {
        int numberOfOTPs = 10;
        int[] otps = new int[numberOfOTPs];

        // Generate OTPs
        for (int i = 0; i < numberOfOTPs; i++)
        {
            otps[i] = GenerateOTP();
        }

        // Display all generated OTPs
        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }

        // Check if all OTPs are unique
        bool allUnique = AreUnique(otps);
        Console.WriteLine("\nAre all OTPs unique? " + (allUnique ? "Yes" : "No"));
    }

    // Method to generate a 6-digit OTP
    static int GenerateOTP()
    {
        return random.Next(100000, 1000000); // 100000 to 999999
    }

    // Method to check if all elements in array are unique
    static bool AreUnique(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
