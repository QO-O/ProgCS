namespace _03_constructors;

 internal void Run()
{
    QuizVraag quizVraag = new QuizVraag("Hier komt de vraag", "Hier komt het antwoord");

    Quiz quiz = new Quiz(10);
    quiz.VoegVraagToeOpIndex(0, quizVraag);
    quiz.VoegVraagToeOpIndex(1, qVraag);
    quiz.VoegVraagToeOpIndex(2, quizVraag);
    quiz.VoegVraagToeOpIndex(3, qVraag);
    quiz.VoegVraagToeOpIndex(4, quizVraag);
    quiz.VoegVraagToeOpIndex(5, qVraag);
    quiz.VoegVraagToeOpIndex(6, quizVraag);
    quiz.VoegVraagToeOpIndex(7, qVraag);
    quiz.VoegVraagToeOpIndex(8, quizVraag);
    quiz.VoegVraagToeOpIndex(9, qVraag);
}
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}