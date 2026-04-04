using System;

class HandshakeCalculator
{
    // Method to calculate maximum number of handshakes
    static int CalculateHandshakes(int n)
    {
        int handshakes = (n * (n - 1)) / 2;
        return handshakes;
    }

    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calling method
        int result = CalculateHandshakes(numberOfStudents);

        // Output
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + result);
    }
}
