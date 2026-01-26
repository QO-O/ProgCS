using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lists_shit;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
        program.RemoveInLoop();
    

        // string[] characters = new string[]
        // {
        //     "Pac-Man","Samus","Crash Bandicoot","Spyro the Dragon","Donkey Kong","Mario","Luigi",
        //     "Astro","Solid Snake","Master Chief","Kratos","Sonic the Hedgehog","Link"
        // };

        // List<string> characterList = new List<string>();

        // characterList.Add("ELEPHANT PEACH");

        // for (int i = 0; i < characters.Length; i++)
        // {
        //     characterList.Add(characters[i]);
        // }

    
        // for (int i = 0; i < characterList.Count; i++)
        // {
        //     Console.WriteLine(characterList[i]);
        // }

        // foreach(string character in characterList)
        // {
        //     Console.WriteLine(character);
        // }

       
    }
    internal void Remove()
    {
         List<double> reviews = new List<double>() { 9.99, 4.68, 342.97, 12.2 };
         for (int i = 0; i < reviews.Count; i++)
        {
            Console.WriteLine(reviews[i]);
        }
        reviews.Remove(342.97);
        reviews.RemoveAt(0);

        foreach(double review in reviews)
        {
            Console.WriteLine(review);
        }
    }
    internal void RemoveInLoop()
    {
        List<Pickup> pickups = new List<Pickup>();

       for (int i = 0; i < 10; i++)
        {
            Pickup pickup = new Pickup()
            {
                x = i,
                y = 0
            };
            pickups.Add(pickup);
        }


        // foreach (Pickup pickup in Pickups)
        // {
        //     if(pickup.x)
        // ;}
       for (int i = pickups.Count - 1; i > -1; i--)
        {
            Pickup pickup = pickups[i];
           if (pickup.x == 4)
            {
                pickups.Remove(pickup);
                Console.WriteLine($"{i}: picked up");
            }
            else
            {
                Console.WriteLine($"{i}: still here");
            }
        }
    }

    internal void Run()
    {
        
    }
}
class Pickup
    {
        internal int x, y;
    }