internal class Book : LibraryItem, IReservable
{
    private bool isAvailable = true;

    public Book(int itemId, string title, string author): base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("Book reserved successfully.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
