internal class FitTrackApp
{
    static UserProfile[] Members = new UserProfile[10];
    static int MemberCount = 0;

    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. View Members");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                AddMember();
            else if (choice == 2)
                ViewMembers();

        } while (choice != 3);
    }

    static void AddMember()
    {
        if (MemberCount >= 10)
        {
            Console.WriteLine("Member limit reached");
            return;
        }

        Console.Write("Enter Member ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Member Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Select Workout Program");
        Console.WriteLine("1. Cardio");
        Console.WriteLine("2. Strength");
        int workoutChoice = Convert.ToInt32(Console.ReadLine());

        Workout workout;

        if (workoutChoice == 1)
        {
            Console.Write("Enter Cardio Type: ");
            string cardioType = Console.ReadLine();

            Console.Write("Enter Duration: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            workout = new CardioWorkout(duration, cardioType);
        }
        else
        {
            Console.Write("Enter Muscle Group: ");
            string muscle = Console.ReadLine();

            Console.Write("Enter Duration: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            workout = new StrengthWorkout(duration, muscle);
        }

        Members[MemberCount] = new UserProfile(id, name, workout);
        MemberCount++;

        Console.WriteLine("Member Added Successfully");
    }

    static void ViewMembers()
    {
        if (MemberCount == 0)
        {
            Console.WriteLine("No members found");
            return;
        }

        for (int i = 0; i < MemberCount; i++)
        {
            Members[i].DisplayProfile();
        }
    }
}