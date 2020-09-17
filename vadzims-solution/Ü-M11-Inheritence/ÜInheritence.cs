using System;

namespace Ü_M11_Inheritence
{
    class ÜInheritence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Übung M11 Vererbung");

            PKW pkw = new PKW("Audi", 45.45, 189, 3, 45);
            Console.WriteLine(pkw.BeschreibeMich());

            Schiff schiff = new Schiff("Titanic", 2000000.00, 150, Schiff.SchiffsTreibstoff.Diesel);
            Console.WriteLine(schiff.BeschreibeMich());

            Flugzeug flugzeug = new Flugzeug("Boeing", 356433222.22, 500, 7, 20000);
            Console.WriteLine(flugzeug.BeschreibeMich());

            Console.WriteLine("static");
            Console.WriteLine("\nSchiff.KmZuMeilen(45): {0}", Schiff.KmZuMeilen(45));
            ;

            Console.ReadKey();
        }
    }
}
