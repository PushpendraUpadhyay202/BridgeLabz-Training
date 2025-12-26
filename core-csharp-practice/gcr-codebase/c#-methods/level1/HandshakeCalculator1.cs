using System;

class HandshakeCalculator1
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("Maximum number of possible handshakes: " + handshakes);
    }
}
