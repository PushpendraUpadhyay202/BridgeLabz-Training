internal class Penguin : Bird, ISwimmable
{
    public Penguin(string birdSpecies, string birdColor, string birdScientificName, int birdAge) : base(birdSpecies, birdColor, birdScientificName, birdAge) { }

    public void Swim()
    {
        Console.WriteLine($"{birdSpecies} is swimming.");
    }
}