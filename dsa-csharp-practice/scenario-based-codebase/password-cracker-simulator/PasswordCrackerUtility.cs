using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Password_Cracker_Simulator
{
    internal class PasswordCrackerUtility : IPasswordCracker
    {
        private static string password;
        private static int passwordTried;
        private static readonly string characterSpace;
        private static readonly int characterSpaceLength;

        static PasswordCrackerUtility()
        {
            characterSpace = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[]{}|;:'\",.<>?/\\`~";
            passwordTried = 0;
        }
        public void SetPassword()
        {
            Console.WriteLine("\n==== ACCEPT PASSWORD ====\n");
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            PasswordCrackerUtility.password = password;
            Console.WriteLine("\nPassword accepted successfully.\n");
        }
        public void CrackPassword()
        {
            passwordTried = 0;
            Console.WriteLine("\n==== PASSWORD CRACKING SIMULATOR ====\n");
            if (password == null)
            {
                Console.WriteLine("\nPlease enter a password first.\n");
                return;
            }

            SimulatePassword("", password.Length);
        }

        private bool SimulatePassword(string generatedPassword, int passwordLength)
        {
            if (generatedPassword.Length == passwordLength)
            {
                passwordTried++;
                Console.WriteLine($"\nGenereated Password: {generatedPassword}");
                if (generatedPassword.Equals(password))
                {
                    Console.WriteLine($"Password matches with original password. Passwords tried: {passwordTried}\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("Password doesn't match with original password. Searching more...\n");
                    return false;
                }
            }

            foreach (char c in characterSpace)
            {
                if (SimulatePassword(generatedPassword + c, passwordLength)) return true;
            }

            return false;
        }
    }
}