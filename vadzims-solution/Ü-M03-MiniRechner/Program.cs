﻿using System;

namespace Ü_M03_MiniRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine Integer-Zahl ein: ");
            int intZahl = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie eine Double-Zahl ein: ");
            double doubleZahl = double.Parse(Console.ReadLine());
            int intSumme = intZahl + (int)doubleZahl;
            double doubleSumme = intZahl + doubleZahl;
            Console.WriteLine($"{intZahl} + {doubleZahl} als Integer = {intSumme}");
            Console.WriteLine($"{intZahl} + {doubleZahl} als Double = {doubleSumme}");
            //Console.WriteLine($"{Math.Max(intZahl, (int)doubleZahl)} / {Math.Min(intZahl, (int)doubleZahl)} = {Math.Max((double)intZahl, doubleZahl) / Math.Min((double)intZahl, doubleZahl)}");
            Console.WriteLine($"{Math.Max(intZahl, doubleZahl)} / {Math.Min(intZahl, doubleZahl)} = { Math.Max(intZahl, doubleZahl) / Math.Min(intZahl, doubleZahl)}");
            Console.ReadKey();
        }
    }
}
