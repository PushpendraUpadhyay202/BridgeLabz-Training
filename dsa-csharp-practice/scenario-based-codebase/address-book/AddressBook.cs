internal class AddressBook
{
    private readonly ContactLinkedList _contacts;
    private string _addressBookName;

    public AddressBook(string addressBookName)
    {
        _contacts = new ContactLinkedList();
        _addressBookName = addressBookName;
    }
    
    public ContactLinkedList GetContacts()
    {
        return _contacts;
    }

    public string GetAddressBookName()
    {
        return _addressBookName;
    }

    public void SetAddressBookName(string addressBookName)
    {
        _addressBookName = addressBookName;
    }
}