internal class Magazine : LibraryItem, IReservable
{
    private bool isAvailable = true;

    public Magazine(int itemId, string title, string author): base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 7;
    }

    public void ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("Magazine reserved successfully.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
