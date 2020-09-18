using System;

namespace UE_m8_Fahrzeug_Listen
{
    class UE_FahrzeugListen
    {
        static void Main(string[] args)
        {
            Transport transport1 = new Transport("Porsche", 200, 150000.00);
            Sub_Schiff sub_Schiff1 = new Sub_Schiff("Donau1", 50, 50_000, 90);

            Sub_Flugzeug sub_Flugzeug1 = new Sub_Flugzeug("Boeing", 1000, 20_000_000, 1_000, 2);
            Sub_PKW sub_PKW1 = new Sub_PKW("Renault", 150, 25_000, true);
            Sub_PKW sub_PKW2 = new Sub_PKW("PKW", 200, 100_000.00, false);
            Sub_PKW sub_PKW3 = new Sub_PKW("Motorad", 150, 30_000.00, false);



            Console.WriteLine(transport1.BeschreibeMich());
            Console.WriteLine();
            Console.WriteLine(sub_Flugzeug1.BeschreibeMich());
            Console.WriteLine();
            Console.WriteLine(sub_Schiff1.BeschreibeMich());
            Console.WriteLine();
            Console.WriteLine(sub_PKW1.BeschreibeMich());

            // Erweiterung UE7:

            Transport[] tArrPKW = new Transport[] { sub_PKW1, sub_PKW2 };

            Console.WriteLine("\n\n\n--- UE7 Erweiterung ---");
            //Beladen
            Console.WriteLine("\n--- Beladen ---");

            Console.WriteLine("sub_Flugzeug1.AktTransportAnzahl: {0}", sub_Flugzeug1.AktTransportAnzahl);
            Console.WriteLine("sub_Flugzeug1.AktTransMittelLadung: {0}", sub_Flugzeug1.AktTransMittelLadung);
            foreach (var item in tArrPKW)
            {
                Console.WriteLine("\n" + item.BeschreibeMich());
            }
            sub_Flugzeug1.Beladen(tArrPKW);
            Console.WriteLine("sub_Flugzeug1.AktTransportAnzahl: {0}", sub_Flugzeug1.AktTransportAnzahl);
            foreach (var item in sub_Flugzeug1.AktTransMittelLadung)
            {
                Console.WriteLine(item.BeschreibeMich());
            }

            //Entladen
            Console.WriteLine("\n--- Entladen ---");
            tArrPKW = new Transport[] { sub_PKW2 };
            sub_Flugzeug1.Entladen(tArrPKW);
            Console.WriteLine("sub_Flugzeug1.AktTransportAnzahl: {0}", sub_Flugzeug1.AktTransportAnzahl);
            foreach (var item in sub_Flugzeug1.AktTransMittelLadung)
            {
                Console.WriteLine(item.BeschreibeMich());
            }


            // Methode kann transportiern
            bool BeladenWennMöglich(Transport t1, Transport t2)
            {


                return true;
            }




            Console.ReadKey();
        }
    }
}
