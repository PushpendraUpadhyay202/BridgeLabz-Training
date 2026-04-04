internal abstract class Workout : ITrackable
{
    protected int Duration;

    public Workout(int duration)
    {
        Duration = duration;
    }

    public abstract void ShowWorkoutDetails();
}