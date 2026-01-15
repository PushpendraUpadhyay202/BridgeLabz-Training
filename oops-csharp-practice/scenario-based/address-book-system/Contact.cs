using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;

namespace AddressBookSystem
{
    internal class Contact
    {
        // UC 01 - Ability to create a Contacts in Address Book with first and last names,
        // address, city, state, zip, phone number and email

        //Creating Every Field Property and their getter and setter
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Address { get; set; }
        private string City {  get; set; }
        private string State {  get; set; }
        private string Zip {  get; set; }
        private string PhoneNumber {  get; set; }
        private string Email {  get; set; }


        //Constructor to set the initial values of these above private filed Properties
        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        //Overriding ToString to allow printing a Contact
        public override string? ToString()
        {
            return $"\nFirst Name: {FirstName} | Last Name: {LastName} | Address: {Address} | City: {City} | State: {State} | Zip: {Zip} | Phone Number: {PhoneNumber} | Email: {Email}";
        }
    }
}
