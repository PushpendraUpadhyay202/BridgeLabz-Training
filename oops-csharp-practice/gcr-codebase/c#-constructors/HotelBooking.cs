using System;
class HotelBooking{
	// Attributes
	private string guestName;
	private string roomType;
	private int nights;
	
	// Default Constructor
	internal HotelBooking(): this("Default Guest Name", "Standard Room", 1){
		Console.WriteLine("\nDefault Constructor Called");
	}

	// Parameterized Constructor
	internal HotelBooking(string guestName, string roomType, int nights){
		Console.WriteLine("\nParameterized Constructor called");
		this.guestName = guestName;
		this.roomType = roomType;
		this.nights = nights;
	}

	// Copy Constructor
	internal HotelBooking(HotelBooking booking){
		Console.WriteLine("\nCopy Constructor called");
		this.guestName = booking.guestName;
		this.roomType = booking.roomType;
		this.nights = booking.nights;
	}

	// Method to display the details of hotel booking
	internal void DisplayBookingDetails(){
		Console.WriteLine("\nHotel Booking Details: ");
		Console.WriteLine("Name: " + this.guestName);
		Console.WriteLine("Room Type: " + this.roomType);
		Console.WriteLine("Nights: " + this.nights);
	}

	static void Main(string[] args){
		// Creating default, parameterized and copy instances of HotelBooking
		HotelBooking booking1 = new HotelBooking();
		HotelBooking booking2 = new HotelBooking("Raman", "Delux Room", 5);
		HotelBooking booking3 = new HotelBooking(booking2);
		
		// Displaying details
		booking1.DisplayBookingDetails();
		booking2.DisplayBookingDetails();
		booking3.DisplayBookingDetails();
	}
}
