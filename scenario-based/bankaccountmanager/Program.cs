using System;

class Program
{
    static void Main()
    {
        Manager manager = new Manager("admin", "admin123");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== " + Bank.bankName + " ===");

            // 🔐 BANK ENTRY AUTHENTICATION
            if (!Bank.EnterBank())
            {
                Console.ReadLine();
                continue;
            }

            Console.WriteLine("\n1. Manager Login");
            Console.WriteLine("2. Client Login");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Username: ");
                string u = Console.ReadLine();
                Console.Write("Password: ");
                string p = Console.ReadLine();

                if (manager.Authenticate(u, p))
                    ManagerMenu(manager);
                else
                {
                    Console.WriteLine("Invalid Manager Credentials!");
                    Console.ReadLine();
                }
            }
            else if (choice == 2)
            {
                Console.Write("Account Number: ");
                int accNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("PIN: ");
                int pin = Convert.ToInt32(Console.ReadLine());

                Client client = new Client(accNo, pin);

                if (client.Authenticate())
                    ClientMenu(client);
                else
                {
                    Console.WriteLine("Invalid Account or PIN!");
                    Console.ReadLine();
                }
            }
            else
                break;
        }
    }

    static void ManagerMenu(Manager m)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Manager Menu ---");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Update Account");
            Console.WriteLine("3. Delete Account");
            Console.WriteLine("4. View Accounts");
            Console.WriteLine("5. Logout");
            Console.Write("Choice: ");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1) m.CreateAccount();
            else if (ch == 2) m.UpdateAccount();
            else if (ch == 3) m.DeleteAccount();
            else if (ch == 4) m.ViewAllAccounts();
            else break;

            Console.ReadLine();
        }
    }

    static void ClientMenu(Client c)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Client Menu ---");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Change PIN");
            Console.WriteLine("5. Logout");
            Console.Write("Choice: ");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1) c.CheckBalance();
            else if (ch == 2) c.Deposit();
            else if (ch == 3) c.Withdraw();
            else if (ch == 4) c.ChangePIN();
            else break;

            Console.ReadLine();
        }
    }
}
