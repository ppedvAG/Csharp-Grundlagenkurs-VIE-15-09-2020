using System;

namespace Demo_string
{
    class Dstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Literals for sting = ""

            Console.WriteLine("einfaches String");
            string str1 = "text     text" +
                "text"; //Tabulatoren werden übernommen, Enter wird automatisch durch + ersetzt
            Console.WriteLine("str1: {0}", str1);

            Console.WriteLine("Interpolation String (Dollar String)");
            string str2 = $"DateTime.Now: {DateTime.Now}";
            Console.WriteLine("str2: {0}", str2);

            Console.WriteLine("Verbatim String (At-Zeichen String)");
            string str3 = @"text     text
text";
            // Tabs und NewLines werden genauso auch in die Ausgabe übernommen
            // @-Strings werden nicht formatiert
            Console.WriteLine("str3: {0}", str3);

            Console.WriteLine("Interpolation & Verbatim String (Dollar & At-Zeichen String)");
            string str4 = $@"DateTime.Now: {DateTime.Now}
DateTime.MinValue: {DateTime.MinValue}
DateTime.MaxValue: {DateTime.MaxValue}";
            Console.WriteLine("str4: {0}", str4);

            // ================

            Console.WriteLine("Strings & Escapes");
            string str5 = "text     text\n\ttext";
            Console.WriteLine("str5: {0}", str5);

            // ================================
            // default
            string str0 = default;
            Console.WriteLine("str0 = {0}", str0);
            //Console.WriteLine("str0 = {0}", str0.ToString()); // NullReferenceException

            // ================================
            //string.Length & index in string
            string str6 = "abcde";
            Console.WriteLine("Länge: {0}", str6.Length);
            Console.WriteLine("Index 1: {0}", str6[1]);



            Console.ReadKey();
        }
    }
}
