using System;

public class FestivalLuckyDraw
{
    private string visitorName;
    private int visitorCount;
    public static void Main(string[] args)
    {
        FestivalLuckyDraw festivalLuckyDraw = new FestivalLuckyDraw();
        festivalLuckyDraw.Menu();
    }

    private void Menu()
    {
        Console.WriteLine("-----------------   Welcome to Lucky Draw  ------------------");
        Console.WriteLine("Enter the number of visitors: ");
        
        this.visitorCount = int.Parse(Console.ReadLine());

        for(int i=0; i< this.visitorCount; i++)
        {
            Console.WriteLine("Enter the visitor name: ");
            this.visitorName = Console.ReadLine();
            
            Console.WriteLine("Press Any key ");
            Console.ReadKey();

            int drawnNumber = new Random().Next(1,2000);
            Console.WriteLine("Your Number is "+ drawnNumber);
            if((drawnNumber % 3 == 0) && (drawnNumber % 5 == 0))
            {
                Won();
            }
            else
            {
                Lost();
            }
        }
    }

    private void Won()
    {
        Console.WriteLine(this.visitorName + ", You won the gift");
    }

    private void Lost()
    {
        Console.WriteLine(this.visitorName + ", you didn't won the gift. Try again next time");
    }
}