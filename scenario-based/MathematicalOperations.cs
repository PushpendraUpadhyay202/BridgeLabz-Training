using System;
public class MathematicalOperations{
	public static void Main(string[] args){
		MathematicalOperations mathematicalOperations = new MathematicalOperations();
		mathematicalOperations.StartApplication();
	}

	private void StartApplication(){
		while(true){
			Console.WriteLine("\n=============== MATHEMATICAL OPERATION ===============\n");
			Console.WriteLine("1. Calculate Factorial of a number");
			Console.WriteLine("2. Check if a number is Prime");
			Console.WriteLine("3. Calculate GCD of two numbers");
			Console.WriteLine("4. Determine nth fibonnaci number");
			Console.WriteLine("5. Exit");
			Console.Write("\nEnter your choice: ");
			int userChoice = int.Parse(Console.ReadLine());
			Console.WriteLine("\n======================================================\n");

			switch (userChoice){
				case 1:
					Factorial();
					break;
				case 2:
					CheckPrime();
					break;
				case 3:
					GCD();
					break;
				case 4:
					Fibonnaci();
					break;
				case 5:
					return;
			}
		}
	}

	private void Factorial(){
		Console.Write("Please enter the number to find factorial: ");
		int number = int.Parse(Console.ReadLine());
		
		int factorial = 1;
		for(int i = 1; i <= number; i++){
			factorial *= i;
		}

		Console.WriteLine("Factorial of " + number + " is " + factorial);
	}

	private void CheckPrime(){
		Console.Write("Please enter the number to find if it is prime or not: ");
		int number = int.Parse(Console.ReadLine());

		bool isPrime = true; // Initially considering the number is prime

		if(number == 1) isPrime = false;
		if(number == 2) isPrime = true;

		for(int i = 2; i < number; i++){
			if(number%i == 0){
				isPrime = false;
				break;
			}
		}

		if(isPrime){
			Console.WriteLine("The number " + number + " IS PRIME");
		}
		else{
			Console.WriteLine("The number " + number + " IS NOT PRIME");
		}
	}

	private void GCD(){
		Console.Write("Please enter the first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Please enter the second number: ");
		int num2 = int.Parse(Console.ReadLine());

		while(num2 != 0){
			int remainder = num1 % num2;
			num1 = num2;
			num2 = remainder;
		}
		
		Console.WriteLine("The GCD is: " + num1);
	}

	private void Fibonnaci(){
		Console.Write("Enter the position for the fibonnaci: ");
		int position = int.Parse(Console.ReadLine());
		
		Console.Write(position + "th fibonnaci number is: ");

		if(position <= 1){
			Console.Write(position);
		}
		else{
			int firstNumber = 0;
			int secondNumber = 1;

			for(int i = 2; i <= position; i++){
				int nextNumber = firstNumber + secondNumber;
				firstNumber = secondNumber;
				secondNumber = nextNumber;
			}

			Console.Write(secondNumber);
		}
	}
}