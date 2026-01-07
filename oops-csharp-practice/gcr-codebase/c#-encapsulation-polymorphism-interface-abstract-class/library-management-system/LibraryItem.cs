using System;

internal abstract class LibraryItem
{
    protected int itemId;
    protected string title;
    protected string author;

    private string borrowerName;
    private string borrowerContact;

    protected LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public int GetItemId()
    {
        return itemId;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void AssignBorrower(string name, string contact)
    {
        borrowerName = name;
        borrowerContact = contact;
    }

    protected string GetBorrowerInfo()
    {
        if (borrowerName == null)
            return "Not Borrowed";

        return borrowerName + " (" + borrowerContact + ")";
    }

    public void GetItemDetails()
    {
        Console.WriteLine(
            $"ID: {itemId} | Title: {title} | Author: {author}"
        );
    }

    public abstract int GetLoanDuration();
}
