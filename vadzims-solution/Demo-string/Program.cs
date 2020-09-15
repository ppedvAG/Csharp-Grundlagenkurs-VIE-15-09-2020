using System;

namespace Demo_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Literals for string

            Console.WriteLine("einfaches String");
            string str1 = "text     text" +
                "text"; // Tabulatoren werden übernommen, Enter wird automatisch durch + ersetzt
            Console.WriteLine("str1: {0}", str1);

            Console.WriteLine("Interpolation String (Dollar String)");
            string str2 = $"DateTime.Now: {DateTime.Now}";
            Console.WriteLine("str2: {0}", str2);

            Console.WriteLine("Verbatim String (At-Zeichen String)");
            string str3 = @"text     text
text";
            // Tabs und NewLines werden genauso auch in die Ausgabe(Konsole) übernommen
            // @-Strings werden nicht formatiert, wenn man die Code-Datei formatiert.
            Console.WriteLine("str3: {0}", str3);

            Console.WriteLine("Interpolation & Verbatim String (Dollar & At-Zeichen String)");
            string str4 = $@"DateTime.Now: {DateTime.Now}
DateTime.MinValue: {DateTime.MinValue}
DateTime.MaxValue: {DateTime.MaxValue}";
            Console.WriteLine("str4: {0}", str4);

            Console.WriteLine("String & Escapes");
            string str5 = "text     text\ntext";
            Console.WriteLine("str5: {0}", str5);

            Console.ReadKey();
        }
    }
}
