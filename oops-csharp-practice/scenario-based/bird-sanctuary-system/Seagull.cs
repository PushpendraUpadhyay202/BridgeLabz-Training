internal class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string birdSpecies, string birdColor, string birdScientificName, int birdAge) : base(birdSpecies, birdColor, birdScientificName, birdAge) { }

    public void Fly()
    {
        Console.WriteLine($"{birdSpecies} is flying.");
    }

    public void Swim()
    {
        Console.WriteLine($"{birdSpecies} is swimming.");
    }
}