namespace _03_constructors;

 internal void Run()
{
    QuizVraag quizVraag = new QuizVraag("Hier komt de vraag", "Hier komt het antwoord");
}
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}