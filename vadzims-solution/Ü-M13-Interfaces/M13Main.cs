using System;

namespace Ü_M13_Interfaces
{
    class M13Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M13 Übung Interfaces");

            Flugzeug flugzeug = new Flugzeug("Boeing", 2_000_000.34, 400, 11, 34_999, 15);

            // Transport zum Beladen
            Transportmittel t1 = new Transportmittel("PKW", 100_000.00, 230);
            Transportmittel t2 = new Transportmittel("Motorrad", 30_000.00, 150);
            Transportmittel[] tArr = new Transportmittel[] { t1, t2 };

            // Flugzeug beladen
            Console.WriteLine("flugzeug.AktLadungAnzahl: {0}", flugzeug.AktLadungAnzahl);
            foreach (var item in tArr)
            {
                Console.WriteLine(item.BeschreibeMich());
            }
            flugzeug.Belade(tArr);
            Console.WriteLine("flugzeug.AktLadungAnzahl: {0}", flugzeug.AktLadungAnzahl);


            // Flugzeug entladen
            tArr = new Transportmittel[] { t1 };
            flugzeug.Entlade(tArr);
            Console.WriteLine("\nflugzeug.AktLadungAnzahl: {0}", flugzeug.AktLadungAnzahl);
            foreach (var item in flugzeug.AktTransMittelLadung)
            {
                Console.WriteLine(item.BeschreibeMich());
            }


            // ================================================
            Console.WriteLine("\n\nMethode die Prüft, ob Beladen möglich ist");
            Console.WriteLine("BeladeWennMöglich(flugzeug, t1): {0}", BeladeWennMöglich(flugzeug, t1)); 
            bool BeladeWennMöglich(Transportmittel t1, Transportmittel t2)
            {
                if (t1 is Flugzeug && t2 is PKW)
                {
                    // Belade() ist nicht bei Transportmittel dabei
                    // Casting notwendig
                    // ((Flugzeug)t1).Belade(new Transportmittel[] { t2 });
                    // oder den Typ anpassen
                    (t1 as Flugzeug).Belade(new Transportmittel[] { t2 });
                    return true;
                }
                else if (t1 is PKW && t2 is Flugzeug)
                { 
                    (t2 as Flugzeug).Belade(new Transportmittel[] { t1 });
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.ReadKey();
        }
    }
}
