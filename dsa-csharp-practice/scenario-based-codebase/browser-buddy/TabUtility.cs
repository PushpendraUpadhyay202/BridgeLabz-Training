internal class TabUtility: ITab
{

    // "Back" operation logic: Put the current page in the forward stack, pop the last page from the back stack and set it to 
    // current page
    public void GoToPreviousPage(Tab tab)
    {
        if (tab.GetBackStack().IsEmpty())
        {
            Console.WriteLine("\n\tThere is no previous page.\n");
            return;
        }

        tab.GetForwardStack().Push(tab.GetCurrentPage());
        tab.SetCurrentPage(tab.GetBackStack().Pop());
        Console.WriteLine($"\n\tCurrent Page: {tab.GetCurrentPage()}\n");
    }

    // "Forward" operation logic: Put the current page in the back stack, pop the last page from the forward stack and set it to 
    // current page
    public void GoToNextPage(Tab tab)
    {
        if (tab.GetForwardStack().IsEmpty())
        {
            Console.WriteLine("\n\tThere is no next page.\n");
            return;
        }

        tab.GetBackStack().Push(tab.GetCurrentPage());
        tab.SetCurrentPage(tab.GetForwardStack().Pop());
        Console.WriteLine($"\n\tCurrent Page: {tab.GetCurrentPage()}\n");
    }

    public void CreateNewPage(Tab tab)
    {
        Console.Write("\n\tPlease enter page name: ");
        string pageName = Console.ReadLine();
        Console.WriteLine();

        tab.GetBackStack().Push(tab.GetCurrentPage());
        tab.SetCurrentPage(pageName);
        Console.WriteLine($"\n\tCurrent Page: {tab.GetCurrentPage()}\n");
    }

    public void DisplayCurrentPage(Tab tab)
    {
        Console.WriteLine("\n\tCurrent Page: " + tab.GetCurrentPage() + "\n");
    }
}