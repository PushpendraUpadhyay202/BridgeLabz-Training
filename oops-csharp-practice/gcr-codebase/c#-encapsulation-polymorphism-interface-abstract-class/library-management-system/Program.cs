using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book(1, "Clean Code", "Robert C. Martin"),
            new Magazine(2, "National Geographic", "Various"),
            new DVD(3, "Inception", "Christopher Nolan")
        };

        ProcessLibraryItems(items);
    }

    static void ProcessLibraryItems(List<LibraryItem> items)
    {
        foreach (LibraryItem item in items)
        {
            item.GetItemDetails();
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");

            if (item is IReservable reservable)
            {
                Console.WriteLine("Available: " + reservable.CheckAvailability());
                reservable.ReserveItem();
            }
        }
    }
}
