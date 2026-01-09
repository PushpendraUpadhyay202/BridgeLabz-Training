internal class UserProfile
{
    public int MemberId;
    public string MemberName;
    public Workout WorkoutProgram;

    public UserProfile(int id, string name, Workout workout)
    {
        MemberId = id;
        MemberName = name;
        WorkoutProgram = workout;
    }

    public void DisplayProfile()
    {
        Console.WriteLine("Member ID: " + MemberId);
        Console.WriteLine("Member Name: " + MemberName);
        WorkoutProgram.ShowWorkoutDetails();
        Console.WriteLine();
    }
}