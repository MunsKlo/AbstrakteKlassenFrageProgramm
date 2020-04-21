using System;
using System.Collections.Generic;
using System.Text;

namespace FrageProgramm
{
    class Nutzer
    {
        public int GestellteFragen { get; set; }
        public int ErfolgreicheFragen { get; set; }
        public string Name { get; set; }

        public Nutzer()
        {
            GestellteFragen = 0;
            ErfolgreicheFragen = 0;
            ErstelleNutzername();
        }

        private void ErstelleNutzername()
        {
            var input = "";
            while (true)
            {
                Console.WriteLine("Bitte geben Sie einen Namen ein!");
                input = Console.ReadLine();
                Console.Clear();
                if (input.Length == 0)
                    continue;
                else
                    break;
            }
            Name = input;
            
        }
    }
}
