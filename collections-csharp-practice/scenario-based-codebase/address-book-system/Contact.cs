internal class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Contact(string firstName, string lastName, string city, string state,
                   string zipCode, string phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        City = city;
        State = state;
        ZipCode = zipCode;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public override string ToString()
    {
        return $"First Name: {FirstName}, Last Name: {LastName}, City: {City}, State: {State}, Zip: {ZipCode}, Phone: {PhoneNumber}, Email: {Email}";
    }
}
