internal class Program
{
    private static Bird[] birds;
    static Program(){
        birds = new Bird[5];
    }
    static void Main(string[] args)
    {
        birds[0] = new Eagle("Bald Eagle", "Dark Brown", "Haliaeetus leucocephalus", 3);
        birds[1] = new Sparrow("White-Throated Sparrow", "White Striped", "Zonotrichia albicollis", 1);
        birds[2] = new Duck("Mallard", "Brown", "Anas platyrhynchos", 2);
        birds[3] = new Penguin("Emperor Penguin", "Black and White", "Aptenodytes forsteri", 10);
        birds[4] = new Seagull("Herring Gull", "White and gray", "Larus argentatus", 5);

        foreach(Bird bird in birds)
        {
            Console.WriteLine(bird);
            if(bird is IFlyable flayableBird)
            {
                flayableBird.Fly();
            }
            else if(bird is ISwimmable swimableBird)
            {
                swimableBird.Swim();
            }
        }
    }
}