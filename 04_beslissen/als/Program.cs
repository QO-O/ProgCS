namespace als;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("You are looking for your key...");

        bool keyLost = Console.ReadLine() == "N";

        if(keyLost)
            {
                Console.WriteLine("Did you find your key? (Y/N)");
                 Console.WriteLine("You have lost your key! The door remains closed.");
            }
        else
        {
            Console.WriteLine("Did you find your key? (Y/N)");
            Console.WriteLine("You have your key! The door now opens.");
        }
    }
}