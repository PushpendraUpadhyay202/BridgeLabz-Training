using System;

public class Bank
{
    public static string bankName = "Buddy Bank";

    // Bank entry password (global)
    public static string bankEntryPassword = "enter123";

    public static Account[] accounts = new Account[20];
    public static int accountCount = 0;

    public static bool EnterBank()
    {
        Console.Write("Enter Bank Entry Password: ");
        string pass = Console.ReadLine();

        if (pass == bankEntryPassword)
        {
            Console.WriteLine("Bank Entry Successful!");
            return true;
        }
        else
        {
            Console.WriteLine("Wrong Bank Entry Password!");
            return false;
        }
    }

    public static Account FindAccount(int accNo)
    {
        for (int i = 0; i < accountCount; i++)
        {
            if (accounts[i].accountNumber == accNo)
                return accounts[i];
        }
        return null;
    }

    public static int FindAccountIndex(int accNo)
    {
        for (int i = 0; i < accountCount; i++)
        {
            if (accounts[i].accountNumber == accNo)
                return i;
        }
        return -1;
    }

    public static void DeleteAccount(int accNo)
    {
        int index = FindAccountIndex(accNo);

        if (index == -1)
        {
            Console.WriteLine("Account not found!");
            return;
        }

        for (int i = index; i < accountCount - 1; i++)
            accounts[i] = accounts[i + 1];

        accounts[accountCount - 1] = null;
        accountCount--;

        Console.WriteLine("Account deleted successfully!");
    }
}
