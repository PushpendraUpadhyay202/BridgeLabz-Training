internal class Eagle: Bird, IFlyable
{
    public Eagle(string birdSpecies, string birdColor, string birdScientificName, int birdAge) : base(birdSpecies, birdColor, birdScientificName, birdAge) { }

    public void Fly()
    {
        Console.WriteLine($"{birdSpecies} is flying.");
    }
}