namespace operators;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int plus = 9;
        Console.WriteLine($"number starts at {plus}");
        Console.WriteLine($"number is now {++plus}");
        Console.WriteLine($"number is now {--plus}");
        Console.WriteLine($"number is now {--plus}");

        int assigned1 = 18;
        float assigned2 = 1.8f;
        double assigned3 = 1.345932346;

         Console.WriteLine($"assigned1 minus 2 is: {assigned1 -= 2}");
         Console.WriteLine($"assigned2 times 2 is: {assigned2 *= 2}");
         Console.WriteLine($"assigned3 divided by 2 is: {assigned3 /= 2}");
    }
}
