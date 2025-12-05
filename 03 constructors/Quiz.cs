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

    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
        vragen[index] = vraag;
        vragen[index] = vraag;
        vragen[index] = vraag;
        vragen[index] = vraag;

    }
     internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag qVraag = new QuizVraag(vraag, antwoord);
        vragen[index] = qVraag;
        QuizVraag qVraag = new QuizVraag(vraag, antwoord);
        vragen[index] = qVraag; 
        QuizVraag qVraag = new QuizVraag(vraag, antwoord);
        vragen[index] = qVraag; 
        QuizVraag qVraag = new QuizVraag(vraag, antwoord);
        vragen[index] = qVraag;
        QuizVraag qVraag = new QuizVraag(vraag, antwoord);
        vragen[index] = qVraag;
    }
}