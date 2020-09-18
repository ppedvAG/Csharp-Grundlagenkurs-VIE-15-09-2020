using System;

namespace Demo_Char
{
    class Dchar
    {
        static void Main(string[] args)
        {
            //Literals for char
            //char ch1 = "d"; geht nicht weil "" = String
            //char ch2 = new Char('d'); geht nicht weil Char ein Struct ist, Structs haben keine Konstruktoren
            char ch3 = 'a';
            
            Console.WriteLine("ch3: {0}", ch3);
            Console.WriteLine("ch3.GetType(): {0}", ch3.GetType()); //System.Char
            Console.WriteLine("char.GetNumericValue(ch3): {0}", char.GetNumericValue(ch3)); // -1 wenn keine Zahl gespeichert
            Console.WriteLine("(int)ch3: {0}", (int)ch3); // ASCII Code



            Console.WriteLine("char.MinValue: {0}", char.MinValue); // nicht alle Zeichen sind druckbar
                                    //MinValue kann man in System.Char nachsehen = \0 = NULL
            Console.WriteLine("char.MaxValue: {0}", char.MaxValue);

           

            Console.ReadKey();
        }
    }
}
