using System;
class ATMDispenser{
	static void Main(string[] args){
		ATMDispenser dispenser = new ATMDispenser();
		dispenser.StartApplication();
	}


	void StartApplication(){
		Console.WriteLine("\n====== WELCOME ======\n");
		Console.Write("Please enter amount: ");
		int amount = int.Parse(Console.ReadLine());
		Console.WriteLine("1. Find optimal combo for amount (with 500): ");
		Console.WriteLine("2. Find optimal combo for amount (without 500): ");
		Console.WriteLine("Enter your choice: ");
		int userChoice = int.Parse(Console.ReadLine());

		if(userChoice == 1){
			FindOptimalVersion1(amount);
		}
		else if(userChoice == 2){
			FindOptimalVersion2(amount);
		}
	}

	void FindOptimalVersion1(int amount){
		int[] notes = {500, 200, 100, 50, 20, 10, 5, 2, 1};
		foreach(int note in notes){
			int numberOfNotes = amount/note;
			amount = amount%note;

			Console.WriteLine(numberOfNotes + " notes of ₹" + note);
		}
	}

	void FindOptimalVersion2(int amount){
		int[] notes = {200, 100, 50, 20, 10, 5, 2, 1};
		foreach(int note in notes){
			int numberOfNotes = amount/note;
			amount = amount%note;

			Console.WriteLine(numberOfNotes + " notes of ₹" + note);
		}
	}
}
