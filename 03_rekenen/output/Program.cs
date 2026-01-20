namespace output;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int a = 1;
        float b = 1.9f;
        double vx = 9.87;
        bool yes = true;
        double insert = 1.3459345679323;

        Console.WriteLine($"My int with the name of a has a value of {a}");
        Console.WriteLine($"My float with the name of b has a value of {b}");
        Console.WriteLine($"My double with the name of vx has a value of {vx}");
        Console.WriteLine($"My bool with the name of yes has a value of {yes}");
        Console.WriteLine($"My double with the name of insert has a value of {insert}");
    }
}
