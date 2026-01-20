namespace ifthen;

class Program
{
    static void Main(string[] args)
    {
        bool playerMovement = true;
        bool playerJumping = true;
        
        Console.WriteLine("Is the player moving? (true/false)");
        Console.ReadLine();
        Console.WriteLine("Is the player jumping? (true/false)");
        Console.ReadLine();
        if (Console.ReadLine() == "true" && Console.ReadLine() == "true" )
        {
            Console.WriteLine("walk");
        }
        

    }
}

