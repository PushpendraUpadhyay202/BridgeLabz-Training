internal class CardioWorkout : Workout
{
    private string CardioType;

    public CardioWorkout(int duration, string cardioType) : base(duration)
    {
        CardioType = cardioType;
    }

    public override void ShowWorkoutDetails()
    {
        Console.WriteLine("Workout Type: Cardio");
        Console.WriteLine("Cardio Type: " + CardioType);
        Console.WriteLine("Duration: " + Duration + " minutes");
    }
}