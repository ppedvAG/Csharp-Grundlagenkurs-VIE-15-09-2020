using System;

namespace Ü_M04_Switch_N_Enum
{
    class Üswitch
    {
        enum Wochentag
        {
            Mo,
            Di,
            Mi,
            Do,
            Fr,
            Sa,
            So
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Today); // 15.09.2020 00:00:00
            Console.WriteLine(DateTime.Today.Day); // 15
            Console.WriteLine(DateTime.Today.DayOfWeek); // Tuesday

            Wochentag tag;

            Console.WriteLine(@"Für welchen Wochentag möchten Sie die Rabattgröße wissen?: 
Geben Sie 0 für Montag ein
Geben Sie 1 für Dienstag ein
Geben Sie 2 für Mittwoch ein
Geben Sie 3 für Donnerstag ein
Geben Sie 4 für Freitag ein
Geben Sie 5 für Samstag ein
Geben Sie 6 für Sonntag ein");
            tag = (Wochentag)int.Parse(Console.ReadLine());
            switch (tag)
            {
                case Wochentag.Mo:
                    Console.WriteLine("Am Mo: 10% Rabatt");
                    break;
                case Wochentag.Di:
                    Console.WriteLine("Am Di: 20% Rabatt");
                    break;
                case Wochentag.Mi:
                    Console.WriteLine("Am Mi: 30% Rabatt");
                    break;
                case Wochentag.Do:
                    Console.WriteLine("Am Do: 40% Rabatt");
                    break;
                case Wochentag.Fr:
                    Console.WriteLine("Am Fr: 50% Rabatt");
                    break;
                case Wochentag.Sa:                    
                case Wochentag.So:
                    Console.WriteLine("Am WE: 60% Rabatt");
                    break;
                default:
                    Console.WriteLine("Sie sollten eine Zahl zwischen 0 und 7 eingeben. Kein Rabatt für Sie!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
