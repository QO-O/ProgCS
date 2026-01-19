using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace _05_dictionaries;

class Program
{
    Dictionary<string,Room> rooms = new Dictionary<string,Room>();
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        personeelOpNummer.Add(382942, "Jim");
        personeelOpNummer.Add(789432, "Tim");

        string Jim = personeelOpNummer[382942];

        foreach (KeyValuePair<int, string> item in personeelOpNummer)
        {
            int nummer = item.Key;
            string naam = item.Value;
            Console.WriteLine(nummer + ": " + naam);
        }
    }
    private void ShowRoom (int x, int y)
        {
            Room room = rooms[$"{x}, {y}"];

            Console.WriteLine($"You are in room {x}, {y}");
            foreach (string r in room.level)
            {
                Console.WriteLine(r);
            }
            bool hasRoom = rooms.ContainsKey($"{x}, {y}");

             string key = $"{x}, {y}";
            if (rooms.TryGetValue(key, out Room foundRoom))
            {
                Console.WriteLine($"You are in room {x}, {y}");
                foreach (string line in foundRoom.level)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"Room {x}, {y} does not exist.");
            }
        }
     internal void Run()
    {
        Room start1 = new Room (0, 0, [
            "xxxxx",
            "x...x",
            "x...x",
            "x...x",
            "xxxxx"
        ]);
        Room start2 = new Room (0, 1, [
            "xxxxx",
            "x...x",
            "xxxxx",
            "x...x",
            "xxxxx"
        ]);
        Room start3 = new Room (0, 2, [
            "xxxxx",
            "xx..x",
            "x...x",
            "x..xx",
            "xxxxx"
            ]);

        rooms.Add(start1.GetRoomLocationKey(), start1);
         rooms.Add(start2.GetRoomLocationKey(), start2);
         rooms.Add(start3.GetRoomLocationKey(), start3);

        ShowRoom(0, 0);
        ShowRoom(0, 1);
        ShowRoom(0, 2);
        ShowRoom(3,0);
    }
}

class Room
{
    internal int x, y;
    internal string[] level;

    internal Room(int x, int y, string[] level)
    {
        this.x = x;
        this.y = y;
        this.level = level;

    }

    internal string GetRoomLocationKey()
    {
        return $"{x}, {y}";
    }
}
