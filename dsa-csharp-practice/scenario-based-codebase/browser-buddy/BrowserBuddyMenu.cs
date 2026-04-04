internal class BrowserBuddyMenu
{
    private IBrowser browserUtility;

    public void ShowMenu()
    {
        browserUtility = new BrowserUtility();
        int choice;
        do
        {
            Console.WriteLine("\n==== WELCOME TO BROWSER BUDDY ====\n");
            Console.WriteLine("1. List All Tabs");
            Console.WriteLine("2. Create a new Tab");
            Console.WriteLine("3. Jump to a Tab");
            Console.WriteLine("0. Exit");
            Console.Write("Please enter your choice number: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    browserUtility.ListAllTabs();
                    break;
                case 2:
                    browserUtility.CreateANewTab();
                    break;
                case 3:
                    browserUtility.JumpToATab();
                    break;
            }

        } while (choice != 0);
    }
}