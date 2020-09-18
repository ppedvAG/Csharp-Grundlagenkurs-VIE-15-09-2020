using System;

namespace UE_m2_MiniRechner
{
    class UEm2Rechner
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine Integer-Zahl ein: ");
            int intZahl = int.Parse(Console.ReadLine());
            
            Console.Write("Bitte geben Sie eine Double-Zahl ein: ");
            double doubleZahl = double.Parse(Console.ReadLine());

            int intAddiert = intZahl + (int)doubleZahl;
            Console.WriteLine("{0} + {1} als Integer = {2}", intZahl, doubleZahl, intAddiert);

            double doubleAddiert = intZahl + doubleZahl;
            Console.WriteLine("{0} + {1} als Double = {2}", intZahl, doubleZahl, doubleAddiert);

            double doubleDiv = Math.Max(intZahl, doubleZahl) / Math.Min(intZahl, doubleZahl);
            Console.WriteLine("{0} / {1} = {2}", Math.Max(intZahl, doubleZahl), Math.Min(intZahl, doubleZahl), doubleDiv);



            Console.ReadKey();



        }
    }
}
