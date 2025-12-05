namespace RijSchool;

class Program
{
    internal void Run()
    {
        Auto auto1 = new Auto()
        {
        automaat = true,
        kenteken = "AA824H",
        kilometerStand = 20567,
        merk = "Volkswagen"
        };

        Auto auto2 = new Auto()
        {
        automaat = false,
        kenteken = "KU786G",
        kilometerStand = 65739,
        merk = "Volvo"
        };

    RijLeraar rijLeraar = new RijLeraar()
        {
        leeftijd = 30,
        naam = "John",
        zzp = false
        };

    LesUur lesUur = new LesUur()
        {
        auto = auto1,
        rijLeraar = rijLeraar,
        tijd = 1130
        };

    LesPakket lesPakket = new LesPakket(){
        urenGekocht = 20,
        urenVerbruikt = 12,
        examenPogingen = 1,
        automaat = true
    };

    TheorieTest theorieTest = new TheorieTest(){
        aantalFouten = 10,
        gehaald = true,
        afnameDatum = new DateTime(2024, 12, 9),
    };

    RijTest rijTest = new RijTest()
    {
        gehaald = true,
        afnameDatum = new DateTime(2024, 12, 10),
    };

    Dag dag = new Dag()
    {
        date = new DateTime(2024, 12, 09),
    };

    Student student = new Student()
    {
       naam = "Quin",
       leefttijd = 18,
       lesPakket = lesPakket,
       rijLeraar = rijLeraar,
       theorieTest = theorieTest,
       rijTest = rijTest
    };
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    
}

