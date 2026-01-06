internal class Bird
{
    protected string birdSpecies;
    protected string birdColor;
    protected string birdScientificName;
    protected int birdAge;

    public Bird(string birdSpecies, string birdColor, string birdScientificName, int birdAge)
    {
        this.birdSpecies = birdSpecies;
        this.birdColor = birdColor;
        this.birdScientificName = birdScientificName;
        this.birdAge = birdAge;
    }

    public override string ToString()
    {
        return $"\nBird Species: {birdSpecies}\nBird Color: {birdColor}\nBird Scientific Name: {birdScientificName}\nBird Age: {birdAge}\n";
    }
}