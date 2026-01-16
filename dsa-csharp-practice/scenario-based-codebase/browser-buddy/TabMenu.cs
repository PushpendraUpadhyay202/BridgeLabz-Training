internal class TabMenu
{
    private ITab tabUtility;

    public void ShowMenuForTab(Tab tab)
    {
        tabUtility = new TabUtility();
        Console.WriteLine($"\n\t========== {tab.GetTabName()} ==========\n");
        Console.WriteLine($"\tCurrent Open Page: {tab.GetCurrentPage()}\n");
        int choice;

        do
        {
            Console.WriteLine("\t1. Go to previous page");
            Console.WriteLine("\t2. Go to next page");
            Console.WriteLine("\t3. Create new page.");
            Console.WriteLine("\t4. Get Current page.");
            Console.WriteLine("\t0. Exit");
            Console.Write("\tPlease enter your choice number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    tabUtility.GoToPreviousPage(tab);
                    break;
                case 2:
                    tabUtility.GoToNextPage(tab);
                    break;
                case 3:
                    tabUtility.CreateNewPage(tab);
                    break;
                case 4:
                    tabUtility.DisplayCurrentPage(tab);
                    break;
            }

        } while (choice != 0);

    }

}