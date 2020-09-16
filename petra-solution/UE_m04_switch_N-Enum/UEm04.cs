using System;

namespace UE_m04_switch_N_Enum
{
    class UEm04
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
            Console.WriteLine("Geben sie eine Zahl ein:");

            Wochentag tag;

            tag = (Wochentag)int.Parse(Console.ReadLine());

            switch (tag)
            {
                case Wochentag.Mo:
                    Console.WriteLine("Heute ist {0}, 5% Rabatt", tag);
                    break;
                case Wochentag.Di:
                    Console.WriteLine("Heute ist {0}, 6% Rabatt", tag);
                    break;
                case Wochentag.Mi:
                    Console.WriteLine("Heute ist {0}, 8% Rabatt", tag);
                    break;
                case Wochentag.Do:
                    Console.WriteLine("Heute ist {0}, 9% Rabatt", tag);
                    break;
                case Wochentag.Fr:
                    Console.WriteLine("Heute ist {0}, 11% Rabatt", tag);
                    break;
                case Wochentag.Sa:
                case Wochentag.So:
                    Console.WriteLine("Heute ist {0}, 15% Rabatt", tag);
                    break;
                default:
                    break;
            }



            Console.ReadKey();
        }
    }
}
