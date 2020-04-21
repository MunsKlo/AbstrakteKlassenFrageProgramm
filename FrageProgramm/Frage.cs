using System;
using System.Collections.Generic;
using System.Text;

namespace FrageProgramm
{
    abstract class Frage
    {
        public string Fragestellung { get; set; }
        public string Antwort { get; set; }
        
        protected void ZeigeFrageStellung()
        {
            Console.WriteLine(Fragestellung);
        }

        public abstract void BeantworteFrage(Nutzer nutzer);
        protected abstract bool ÜberprüfeAntwort(string input);
        protected abstract bool IstAntwortRichtig(string input);

        protected void BewerteAntwort(Nutzer nutzer, string input)
        {
            if (IstAntwortRichtig(input))
                nutzer.ErfolgreicheFragen++;
        }
    }
}
