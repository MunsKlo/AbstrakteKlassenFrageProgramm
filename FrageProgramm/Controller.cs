using System;
using System.Collections.Generic;
using System.Text;

namespace FrageProgramm
{
    class Controller
    {
        public static Dictionary<string, string> freitextFragen = new Dictionary<string, string>
        {
            { "Wann wurde Karl der Große zum König gekrönt", "800" },
            { "Was ist die Hauptstadt von Mexiko?", "Mexiko-Stadt"},
            { "Wie heißt die Spezialeinheit der Bundeswehr?", "Kommando Spezialkräfte"}
        };

        public static Dictionary<string, string> matheFragen = new Dictionary<string, string>
        {
            { "400 + 600 : 200 * (1200 - 1000)", "1000" },
            { "0^0", "1"}
        };

        public static Random random = new Random();

        public static List<string> BekommeFrage(Dictionary<string, string> fragen)
        {
            var counter = random.Next(0, fragen.Count);
            var count = 0;
            List<string> list = new List<string>();
            foreach (var item in fragen)
            {
                if (counter == count)
                {
                    list.Add(item.Key);
                    list.Add(item.Value);
                }
                count++;
            }
            return list;
        }
    }
}
