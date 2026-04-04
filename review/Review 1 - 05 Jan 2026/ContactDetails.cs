using System;

class User
{
    public string name;
    public string contactNumber;
    public string city;
    public string emailId;


}

public class ContactDetails
{
    static User[] users = new User[100];
    static int count = 0;

    public static void Main(string[] args)
    {
        int option;

        while (true)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("User Contact Details");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Delete User");
            Console.WriteLine("3. Update User");
            Console.WriteLine("4. Display All Users");
            Console.WriteLine("5. Partial Search");
            Console.WriteLine("6. Exit");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddUser();
                    Console.WriteLine("User Added Successfully");
                    break;
                case 2:
                    DeleteUser();
                    Console.WriteLine("User Deleted Successfully");
                    break;
                case 3:
                    UpdateUser();
                    break;
                case 4:
                    DisplayUsers();
                    break;
                case 5:
                    PartialSearch();
                    break;
                case 6:
                    Console.WriteLine("Program Exiting.......");
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    Console.WriteLine("Press the option from 1 to 6 only");
                    break;
            }
        }
    }

    private static void AddUser()
    {
        if(count >= users.Length)
        {
            Console.WriteLine("Storage full");
            return;
        }

        User user = new User();

        Console.Write("Enter Name: ");
        user.name = Console.ReadLine();

        Console.Write("Enter Number: ");
        user.contactNumber = Console.ReadLine();

        Console.Write("Enter City: ");
        user.city = Console.ReadLine();

        Console.Write("Enter id: ");
        user.emailId = Console.ReadLine();

        users[count] = user;
        count++;

    }

    private static void DeleteUser()
    {
        Console.Write("Enter the Contact Number: ");
        string userToBeDeleted = Console.ReadLine();

        int found = -1;

        for(int i=0 ; i<count; i++)
        {
            if(users[i].contactNumber == userToBeDeleted)
            {
                found = i;
                break;
            }

        }
        if(found == -1)
        {
            Console.WriteLine("User Not Found");
            return;
        }

        for(int i=found ; i < count - 1; i++)
        {
            users[i] = users[i+1];
        }

        users[count-1] = null;
        count--;

    }

    private static void DisplayUsers()
    {
        if(count == 0)
        {
            Console.WriteLine("No user Available");
            return;
        }

        Console.WriteLine("--------------   User List --------------");

        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("Name : " + users[i].name );
            Console.WriteLine("Contact Number  : "+ users[i].contactNumber);
            Console.WriteLine("City   : "+ users[i].city);
            Console.WriteLine("Email ID   : "+ users[i].emailId);
        }
    }


    private static void UpdateUser()
    {
        Console.Write("Enter the Contact number of user you want to Update: ");
        string contact = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (users[i].contactNumber == contact)
            {
                Console.Write("Enter new Name: ");
                users[i].name = Console.ReadLine();

                Console.Write("Enter new City: ");
                users[i].city = Console.ReadLine();

                Console.Write("Enter new Email ID: ");
                users[i].emailId = Console.ReadLine();

                Console.WriteLine("User updated successfully!");
                return;
            }
        }
        Console.WriteLine("User Not Found");
    }

    private static void PartialSearch()
    {
        string search = Console.ReadLine();
        bool found = false;

        for(int i = 0; i < count; i++)
        {
            if (users[i].name.ToLower().Contains(search) ||
                users[i].contactNumber.ToLower().Contains(search) ||
                users[i].city.ToLower().Contains(search) ||
                users[i].emailId.ToLower().Contains(search))
            {
                Console.WriteLine("Name   : "+users[i].name);
                Console.WriteLine("Contact Number   : "+users[i].contactNumber);
                Console.WriteLine("City   : "+users[i].city);
                Console.WriteLine("Email ID   : "+users[i].emailId);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching user found");
        }
    }
}