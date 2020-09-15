using System;
using System.Text;

namespace Demo_double
{
    class Ddouble
    {
        static void Main(string[] args)
        {
            // Literals 

            double d1 = 2.2;
            // oder mit einem D-Suffix, wenn man double von einem anderen Literal unterscheiden möchte
            double d2 = 4.4D;
            float f1 = 4.4F;

            // ===============================================
            // default-Wert 
            double d0 = default;
            Console.WriteLine("d0: {0}", d0); // 0, nicht 0.0

            // ===============================================
            // Einlesen von Doubles aus der Konsole
            Console.Write("Geben Sie eine Double-Zahl ein: ");
            double d3 = double.Parse(Console.ReadLine());
            Console.WriteLine("d3: {0}", d3); // 4.4 => 44, 4,4 => 4,4

            double d4 = double.Parse("5.5");
            Console.WriteLine("d4: {0}", d4); // 55

            // Lösung für die Länder, wo Kommazahlen mit Punkt geschrieben werden
            Console.Write("Geben Sie eine Double-Zahl mit Punktnotation ein: ");
            double d5 = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("d5: {0}", d5); // 4.4 => 4,4 (in der Konsole), 4.4 => 4.4 (im Code)
            // aber jetzt das Problem mit Kommanotation: 4,4 => 44           
            
            // ===============================================
            Console.ReadKey();
        }
    }
}
