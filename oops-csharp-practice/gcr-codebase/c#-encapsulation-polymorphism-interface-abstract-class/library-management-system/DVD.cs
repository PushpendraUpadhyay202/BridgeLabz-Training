internal class DVD : LibraryItem
{
    public DVD(int itemId, string title, string author): base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 3;
    }
}
