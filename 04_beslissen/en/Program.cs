namespace en;

class Program
{
    static void Main(string[] args)
    {
        bool doorNeedsKey = Console.WriteLine() == "doorNeedsKey?";
        bool playerHasKey = Console.WriteLine() == "playerHasKey?";

        Console.WriteLine("You are stood infront of a door.");
        
        if(doorNeedsKey && playerHasKey)
        {
            Console.WriteLine("doorNeedsKey? (y/n)");
            Console.WriteLine("playerHasKey? (y/n)");
        }
    }
}
