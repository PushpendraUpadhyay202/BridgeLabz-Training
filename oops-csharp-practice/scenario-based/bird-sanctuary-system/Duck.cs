internal class Duck : Bird, ISwimmable
{
    public Duck(string birdSpecies, string birdColor, string birdScientificName, int birdAge) : base(birdSpecies, birdColor, birdScientificName, birdAge) { }

    public void Swim()
    {
        Console.WriteLine($"{birdSpecies} is swimming.");
    }
}