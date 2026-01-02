using System;
public class EduQuiz{
	// Since number of questions is same for every student, making it static
	private static int numberOfQuestions;

	// Since correct answer are same for every students, keeping the correctAnswer array static
	private static string[] correctAnswers;

	// Since each student will give different answers, keeping the studentAnswers array non-static
	private string[] studentAnswers;

	// Hardcoding the admin credentials as of now for auth
	string adminEmail = "admin@gmail.com";
	string adminPassword = "adminpassword";

	public static void Main(string[] args){
		EduQuiz eduQuiz = new EduQuiz();
		eduQuiz.StartApplication();
	}

	private void StartApplication(){
		numberOfQuestions = 10;
		correctAnswers = new string[] {"a1", "a2", "a3", "a4", "a5", "a6", "a7", "a8", "a9", "a10"};
		studentAnswers = new string[numberOfQuestions];
		Console.WriteLine("\n=============== EduQuiz - Student Quiz Grader ===============\n");
		RunApplication();
	}

	
	// Displays login window and returns if the user choses to exit the application
	private void RunApplication(){
		while(true){
			Console.WriteLine("\n======================= LOGIN WINDOW =========================\n");
			Console.WriteLine("1. Admin Login");
			Console.WriteLine("2. Student");
			Console.WriteLine("3. Exit");
			Console.Write("\nPlease enter your login choice (1, 2 or 3): ");	
			int loginChoice = int.Parse(Console.ReadLine());		
			
			Console.WriteLine("\n=============================================================\n");

			switch(loginChoice){
				case 1:
					if(AuthenticateAdmin()){
						// Displays admin menu until admin choses to exit the application
						while(AdminMenu());
					}
					break;
				
				case 2:
					// Display student menu until student choses to exit the application
					while(StudentMenu());
					break;

				case 3:
					return;
			}
		}

	}

	// Method to display student menu
	private bool StudentMenu(){
		Console.WriteLine("\n======================== STUDENT MENU =========================\n");
		Console.WriteLine("1. Enter Quiz Answers");
		Console.WriteLine("2. Exit");
		Console.Write("\nPlease enter your choice: ");
		int studentChoice = int.Parse(Console.ReadLine());
		Console.WriteLine("\n================================================================\n");
		
		switch(studentChoice){
			case 1:
				ProcessStudentAnswers();
				break;
			case 2:
				return false;
		}

		return true;
	}

	
	// Method to accept student answers, and process then with the help of other methods
	private void ProcessStudentAnswers(){
		Console.WriteLine("Please enter the answers: \n");
		for(int i = 0; i < numberOfQuestions; i++){
			Console.Write("Please enter the answer for question number: " + (i+1) + ": ");
			studentAnswers[i] = Console.ReadLine();
		}

		Console.WriteLine("\n============================= RESULT =============================\n");

		int studentScore = CalculateScore();
		Console.WriteLine("Your score is: " + studentScore);

		double percentageScore = CalculatePercentage(studentScore);
		Console.WriteLine("Your percentage score is: " + percentageScore + " % ");

		if(percentageScore >= 50){
			Console.WriteLine("You PASSED the quiz");
		}
		else{
			Console.WriteLine("You FAILED the quiz");
		}
	}

	// Method to calculate score and display detialed feedback
	private int CalculateScore(){
		int studentScore = 0;
		for(int i = 0; i < numberOfQuestions; i++){
			if(string.Equals(correctAnswers[i], studentAnswers[i], StringComparison.OrdinalIgnoreCase)){
				studentScore++;
				Console.WriteLine("Your answer for question number " + (i+1) + " is CORRECT\n");
			}
			else{
				Console.WriteLine("Your answer for question number " + (i+1) + " is INCORRECT" );
				Console.WriteLine("Correct answer for questios number " + (i+1) + " is: " + correctAnswers[i]);
				Console.WriteLine();
			}	
		}
		return studentScore;
	}

	// Method to show percentage score
	private double CalculatePercentage(int studentScore){
		double percentageScore = ((double)(studentScore)/(double)(numberOfQuestions))*100;
		return percentageScore;
	}

	// Method to display admin menu
	// Displays menu and returns false if admin choses to exit
	private bool AdminMenu(){
		Console.WriteLine("\n========================= ADMIN MENU ===========================\n");
		Console.WriteLine("1. Update Answers");
		Console.WriteLine("2. Display Correct Answers");
		Console.WriteLine("3. Exit");
		Console.Write("\nPlease enter your choice: ");
		int adminChoice = int.Parse(Console.ReadLine());
		Console.WriteLine("\n================================================================\n");	
		
		switch(adminChoice){
			case 1:
				UpdateAnswers();
				break;

			case 2:
				DisplayCorrectAnswers();
				break;
			case 3:
				return false;
		}

		return true;
		
	}

	// Method to display the correct answers to the admin
	private void DisplayCorrectAnswers(){
		Console.WriteLine("Given below are the correct answers: \n");
		for(int i = 0; i < numberOfQuestions; i++){
			Console.WriteLine("Correct answer for question number " + (i+1) + ": " + correctAnswers[i]);	
		}
	}

	// Method to update the answers
	private void UpdateAnswers(){
		Console.WriteLine("Please enter the updated answers: \n");
		for(int i = 0; i < numberOfQuestions; i++){
			Console.Write("Please enter the updated answer for question number " + (i+1) + ": ");
			correctAnswers[i] = Console.ReadLine();
		}
		Console.WriteLine("\nAnswers Updated Successfully");
	}

	// Method to authenticate admin using the provided credentials
	// Returns true if credentials match and false otherwise
	private bool AuthenticateAdmin(){
		Console.Write("Please enter your admin email id: ");
		string userProvidedEmail = Console.ReadLine();
		Console.Write("Please enter your admin password: ");
		string userProvidedPassword = Console.ReadLine();		
		Console.WriteLine("\n=============================================================\n");

		if(!(userProvidedEmail.Equals(adminEmail)) || !(userProvidedPassword.Equals(adminPassword))){
			Console.WriteLine("Authentication Failed");
			return false;
		}
		Console.WriteLine("Authentication Successfull");
		return true;
	}
}