namespace _03_constructors;

class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord ingevuldeAntwoorden;
    
    internal Quiz(int aantalVragen, int ingevuldeAntwoorden)
    {
        vragen = new QuizVraag[aantalVragen];
        vragen = new QuizVraag[ingevuldeAntwoorden];
    }
}


