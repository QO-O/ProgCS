namespace _01_functions;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Question1();
        //a function about running, a string because it's text
        //it's a program, and the name is program
        //I assume the return would be either a string or a bool
        program.Question2();
        program.Question3();
        program.Question4();
        program.Question5();
        program.Question6();
    }
        internal void Question1()
     {
        Console.WriteLine("How long do you think you'll last in a zombie apocalypse?");
        string awnser = Console.ReadLine();

        Console.WriteLine(awnser);
     }
        internal void Question2()
        {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
        string awnser = Console.ReadLine();

        Console.WriteLine(awnser);
        }
        internal void Question3()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
        string awnser = Console.ReadLine();

        Console.WriteLine(awnser);
        }
        internal void Question4()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
        string awnser = Console.ReadLine();

        Console.WriteLine(awnser);
        }internal void Question5()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
        string awnser = Console.ReadLine();

        Console.WriteLine(awnser);
        }internal void Question6()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
        string awnser = Console.ReadLine();

        Console.WriteLine(awnser);
        }

        internal void Run()
    {
        Console.WriteLine("This is now the start of my program");
    }
}
