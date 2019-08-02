using System;

namespace _06A2Zeitzerlegung
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SproTag = 86400;// Sekunden pro Tag
            const int SproStunde = 3600; // Sekunden pro Stunde
            const int SproMinute = 60;   // Sekunden pro Minute
            int eingabe, sekunden, minuten, stunden, tage, wert;

            Console.Write("Hallo, Sekunde mal! ");
            //if (int.TryParse(Console.ReadLine(), out eingabe))
            for (eingabe = 1; eingabe < 86402; eingabe++)
            {
                wert = eingabe;

                tage = wert / (SproTag);
                wert = wert - (tage * SproTag);

                stunden = wert / (SproStunde);
                wert = wert - (stunden * SproStunde);

                minuten = wert / SproMinute;
                sekunden = wert - (minuten * SproMinute);

                Console.WriteLine("{0} Sekunden sind {1} Tag(e), {2} Stunden, {3} Minute(n) und {4} Sekunde(n). ", eingabe, tage, stunden, minuten, sekunden);
            }
        }
    }
}
