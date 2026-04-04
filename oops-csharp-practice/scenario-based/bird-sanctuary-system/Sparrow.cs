internal class Sparrow : Bird, IFlyable
{
    public Sparrow(string birdSpecies, string birdColor, string birdScientificName, int birdAge) : base(birdSpecies, birdColor, birdScientificName, birdAge) { }

    public void Fly()
    {
        Console.WriteLine($"{birdSpecies} is flying.");
    }
}