using System;
using System.Linq;

namespace UE_m3_Zahlenlotto
{
    class UE_m3_Zahlen
    {
        

        static void Main(string[] args)
        {
            #region Variante 1
            // Teil 1
            Console.WriteLine("Variante 1 / Teil 1");
            Random rnd = new Random();

            int zufallszahl = rnd.Next(1, 6);
            int zahlBenutzer;

            Console.Write("Bitte eine Zahl zwischen 1 und 5 eingeben: ");
            zahlBenutzer = int.Parse(Console.ReadLine());

            Console.WriteLine("Zufallszahl = {0}, Eingegebene Zahl = {1}", zufallszahl, zahlBenutzer);

            if (zahlBenutzer > zufallszahl)
            {
                Console.WriteLine("Die Zahl ist größer als die Zufallszahl ({0} > {1})", zahlBenutzer, zufallszahl);
            }
            else if (zahlBenutzer < zufallszahl)
            {
                Console.WriteLine("Die Zahl ist kleiner als die Zufallszahl ({0} < {1})", zahlBenutzer, zufallszahl);

            }
            else
            {
                Console.WriteLine("Die Zahl ist gleich der Zufallszahl ({0} = {1})", zahlBenutzer, zufallszahl);

            }


            //Teil 2
            Console.WriteLine("Variante 1 / Teil 2");
            Console.WriteLine("Bitte erraten Sie die Zahl zwischen 1 und 5:");

            int zufallszahl2 = rnd.Next(1, 6);
            int zahlBenutzer2;
            int anzahlVersuche = 1;
            zahlBenutzer2 = int.Parse(Console.ReadLine());

            while (zahlBenutzer2 != zufallszahl2)
            {
                Console.WriteLine("Leider falsch, bitte versuchen Sie es noch einmal:");
                zahlBenutzer2 = int.Parse(Console.ReadLine());
                anzahlVersuche++;
            }

            Console.WriteLine("Richtig, die Zahl war {0}, Sie haben {1} Versuche benötigt.", zufallszahl2, anzahlVersuche);
            #endregion

            #region Variante2_Lotto
            int ersteZahl;
            int zweiteZahl;
            int dritteZahl;

            Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 10 ein: ");
            ersteZahl = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 10 ein: ");
            zweiteZahl = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 10 ein: ");
            dritteZahl = int.Parse(Console.ReadLine());

            int[] eingegZahlen = new int[] { ersteZahl, zweiteZahl, dritteZahl };


            foreach (var item in eingegZahlen)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            //Zufallszahlen
            int zufallsZahl1 = rnd.Next(1, 11);
            int zufallsZahl2 = rnd.Next(1, 11);
            int zufallsZahl3 = rnd.Next(1, 11);

            while (zufallsZahl1 == zufallsZahl2)
            {
                zufallsZahl2 = rnd.Next(1, 11);
            }

            while (zufallsZahl2 == zufallsZahl3 || zufallsZahl1 == zufallsZahl3)
            {
                zufallsZahl3 = rnd.Next(1, 11);
            }
            
            int[] zufallsZahlen = new int[] { zufallsZahl1, zufallsZahl2, zufallsZahl3 };


            Console.WriteLine("1. Gewinnzahl: {0}", zufallsZahl1);
            Console.WriteLine("2. Gewinnzahl: {0}", zufallsZahl2);
            Console.WriteLine("3. Gewinnzahl: {0}", zufallsZahl3);

            //Vergleich
            int countZahlen = 0;

            for (int i = 0; i < eingegZahlen.Length; i++)
            {
                if (zufallsZahlen.Contains(eingegZahlen[i]))
                {
                    countZahlen++;
                }
            }

            Console.WriteLine("Du hast {0} Zahl(en) richtig eingetippt.", countZahlen);

            #endregion



            Console.ReadKey();
        }
    }
}
