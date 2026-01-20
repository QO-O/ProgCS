namespace of;

class Program
{
    static void Main(string[] args)
    {
        int keuze = int.Parse(Console.ReadLine());
        int mango = 2;
        int watermelon = 1;
        int aarbei = 0;

        if (keuze == mango || keuze == aarbei)
        {
            Console.WriteLine("JUM JUM");
        }

        if (keuze == watermelon)
        {
            Console.WriteLine("BLEH!");
        }
    }
}
