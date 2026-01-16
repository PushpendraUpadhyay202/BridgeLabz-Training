internal class BrowserUtility: IBrowser
{
    // The following doubly linked list holds all the tabs
    private DoublyLinkedList tabsList;
    private TabMenu tabMenu;

    public BrowserUtility()
    {
        tabsList = new DoublyLinkedList();
        tabMenu = new TabMenu();
    }

    public void ListAllTabs()
    {
        Console.WriteLine("\n=== Here is a list of all the tabs: \n");
        if (tabsList.IsEmpty())
        {
            Console.WriteLine("\nZero tabs opened in the browser as of now. Create a tab first.\n");
            return;
        }
        tabsList.PrintList();
        Console.WriteLine("\n");
    }

    public void CreateANewTab()
    {
        Console.WriteLine("\n==== New Tab Creation Window ====\n");
        Console.Write("Please enter tab name (continue for system given tab name): ");
        string tabName = Console.ReadLine();
        Tab tab;
        if (tabName.Equals(""))
        {
            tab = new Tab();
        }
        else
        {
            tab = new Tab(tabName);
        }

        tabsList.InsertAtEnd(tab);
        Console.WriteLine("\n");
    }

    public void JumpToATab()
    {
        Console.WriteLine("\n==== JUMPT TO A TAB ====\n");
        if (tabsList.IsEmpty())
        {
            Console.WriteLine("\nZero tabs opened in the browser as of now. Create a tab first.\n");
            return;
        }

        Console.Write("Please enter tab name: ");
        string tabName = Console.ReadLine();

        if (!tabsList.IsTabPresent(tabName))
        {
            Console.WriteLine("\nTab with this name doesn't exist\n");
            return;
        }

        Tab tab = tabsList.FindTab(tabName);
        tabMenu.ShowMenuForTab(tab);
    }


}