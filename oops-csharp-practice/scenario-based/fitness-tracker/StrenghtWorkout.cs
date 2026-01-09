internal class StrengthWorkout : Workout
{
    private string MuscleGroup;

    public StrengthWorkout(int duration, string muscleGroup) : base(duration)
    {
        MuscleGroup = muscleGroup;
    }

    public override void ShowWorkoutDetails()
    {
        Console.WriteLine("Workout Type: Strength");
        Console.WriteLine("Muscle Group: " + MuscleGroup);
        Console.WriteLine("Duration: " + Duration + " minutes");
    }
}