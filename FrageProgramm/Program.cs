using System;

namespace FrageProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            Nutzer Nutzer1 = new Nutzer();
            var input = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{Nutzer1.Name} hat {Nutzer1.ErfolgreicheFragen} von {Nutzer1.GestellteFragen} Fragen richtig beantwortet!");
                input = Input("Loslegen? [j/n]");
                if (input == "j")
                    StelleFrage(Nutzer1);
                else if (input == "n")
                    break;
            }
        }

        private static string Input(string beschreibung)
        {
            Console.WriteLine(beschreibung);
            return Console.ReadLine();
        }

        private static void StelleFrage(Nutzer nutzer)
        {
            if(Controller.random.Next(1, 3) == 1)
            {
                var frage = new FreitextFrage();
                frage.BeantworteFrage(nutzer);
            }
            else
            {
                var frage = new MatheFrage();
                frage.BeantworteFrage(nutzer);
            }
        }
    }
}
