using System.Text.Json;

namespace Schrijven;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

        // string text = "This is my text, totally useful and important and not at all due to a bout of boredom.";
        // string filePath = "mytext.txt";

        // File.WriteAllText(filePath, text);

        // string[] lines = 
        // {
        //     "Time is a tool",
        //     "You can put on the wall,",
        //     "Or wear it on your wrist."
        // };
        // string filePath1 = "mylines.txt";
        // File.WriteAllLines(filePath1, lines);


        List<FavouriteGame> favouriteGames = new List<FavouriteGame>
            {
                new FavouriteGame { Name = "Minecraft", Platform = "Minecraft" },
                new FavouriteGame { Name = "Fallout 4", Platform = "Steam" },
                new FavouriteGame { Name = "Phasmophobia", Platform = "Steam" }
            };

            string gameText = JsonSerializer.Serialize(favouriteGames);
            string gameFilePath = "games.json";
            File.WriteAllText(gameFilePath, gameText);

        string jsonFilePath = "games.json";
        string jsonText = File.ReadAllText(jsonFilePath);

        Console.WriteLine(jsonText);
    }


    internal void Run()
    {
        
    }
}

public class FavouriteGame
{
    public string Name {get; set ;}
    public string Platform {get; set ;}

}