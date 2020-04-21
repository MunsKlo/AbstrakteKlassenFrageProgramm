using System;
using System.Collections.Generic;
using System.Text;

namespace FrageProgramm
{
    class FreitextFrage : Frage
    {
        public FreitextFrage()
        {
            var list = new List<string>();
            while (true)
            {
                list = Controller.BekommeFrage(Controller.freitextFragen);
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
                    Console.WriteLine("Besser raten als nichts schreiben!");
                }
                else
                    break;
            }
            BewerteAntwort(nutzer, input);
        }

        protected override bool ÜberprüfeAntwort(string input)
        {
            return input.Length == 0;
        }

        protected override bool IstAntwortRichtig(string input)
        {
            return input.ToLower() == Antwort.ToLower();
        }
    }
}
