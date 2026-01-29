using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string path = "users.csv";
        StreamReader reader = new StreamReader(path);

        Regex emailRegex = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
        Regex phoneRegex = new Regex("^[0-9]{10}$");

        string line;
        bool isHeader = true;

        while ((line = reader.ReadLine()) != null)
        {
            if (isHeader)
            {
                isHeader = false;
                continue;
            }

            string[] parts = line.Split(',');

            string email = parts[2];
            string phone = parts[3];

            bool emailValid = emailRegex.IsMatch(email);
            bool phoneValid = phoneRegex.IsMatch(phone);

            if (!emailValid || !phoneValid)
            {
                Console.WriteLine("Invalid Record:");
                Console.WriteLine(line);

                if (!emailValid)
                {
                    Console.WriteLine("Error: Invalid Email");
                }

                if (!phoneValid)
                {
                    Console.WriteLine("Error: Invalid Phone Number");
                }

                Console.WriteLine("-----");
            }
        }

        reader.Close();
    }
}
