using System;
using System.Collections.Generic;
using System.Text;

namespace FrageProgramm
{
    class MatheFrage : Frage
    {
        public MatheFrage()
        {
            var list = new List<string>();
            while (true)
            {
                list = Controller.BekommeFrage(Controller.matheFragen);
                if (list.Count == 2)
                    break;
            }
            Fragestellung = list[0];
            Antwort = list[1];
            ZeigeFrageStellung();
        }

        public override void BeantworteFrage(Nutzer nutzer)
        {
            var input = "";
            nutzer.GestellteFragen++;
            while (true)
            {
                input = Console.ReadLine();
                if (ÜberprüfeAntwort(input))
                {
                    Console.WriteLine("Besser raten als nichts schreiben oder Sie haben keine Zahl geschrieben!");
                }
                else
                    break;
            }
            BewerteAntwort(nutzer, input);
        }

        protected override bool ÜberprüfeAntwort(string input)
        {
            return int.TryParse(input, out int numb) && input.Length == 0;
        }

        protected override bool IstAntwortRichtig(string input)
        {
            return input.ToLower() == Antwort.ToLower();
        }
    }
}
