using System;
class Course{
	private static string instituteName = "Initial Institute Name";

	private string courseName;
	private int duration;
	private float fee;

	internal Course(string courseName, int duration, float fee){
		this.courseName = courseName;
		this.duration = duration;
		this.fee = fee;
	}

	internal void DisplayCourseDetails(){
		Console.WriteLine("\nGiven below are the course details: ");
		Console.WriteLine("Institute Name: " + instituteName);
		Console.WriteLine("Course Name: " + courseName);
		Console.WriteLine("Duration: " + duration + " Years");
		Console.WriteLine("Fee: Rs " + fee );
	}

	internal static void UpdateInstituteName(string instituteUpdatedName){
		instituteName = instituteUpdatedName;
		Console.WriteLine("\nUniveristy Name Updated");
	}
}

class OnlineCourseManagement{
	static void Main(String[] args){
		Course course1 = new Course("B-Tech", 4, 800000);
		Course course2 = new Course("MBA", 3, 2400000);

		course1.DisplayCourseDetails();
		course2.DisplayCourseDetails();

		Course.UpdateInstituteName("Updated Institute Name");

		course1.DisplayCourseDetails();
		course2.DisplayCourseDetails();
	}
}
