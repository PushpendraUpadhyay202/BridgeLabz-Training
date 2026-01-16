internal class Tab
{
    // backStack contains pages which would appear when the user performs the "back" operation on a tab
    private PageStack backStack;
    // forwardStack contains pages which would appear when the user performs the "forward" operation on a tab
    private PageStack forwardStack;
    private string currentPage;
    private string tabName;
    private static int tabCount = 0;

    // When a new tab is just created, its backStac and forwardStack are empty and it has a default page called "Default Page"
    public Tab()
    {
        backStack = new PageStack();
        forwardStack = new PageStack();
        currentPage = "Default Page";
        tabName = "Tab " + (tabCount++);
    }

    public Tab(string tabName): this()
    {
        this.tabName = tabName;
    }

    public string GetCurrentPage()
    {
        return currentPage;
    }

    public void SetCurrentPage(string currentPage)
    {
        this.currentPage = currentPage;
    }

    public PageStack GetBackStack()
    {
        return backStack;
    }

    public PageStack GetForwardStack()
    {
        return forwardStack;
    }

    public string GetTabName()
    {
        return tabName;
    }
}