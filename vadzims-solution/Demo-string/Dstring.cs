﻿using System;

namespace Demo_string
{
    class Dstring
    {
        static void Main(string[] args)
        {
           
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

            // =================================================
            Console.WriteLine("String & Escapes");
            string str5 = "text     text\ntext";
            Console.WriteLine("str5: {0}", str5);

            // =================================================
            // default-Wert
            string str0 = default;
            Console.WriteLine("str0: {0}", str0);
            // Console.WriteLine("str0: {0}", str0.ToString()); // NullReferenceException

            // =================================================
            // string.Length & index in string
            // public char this[int index] { get; }
            string str6 = "abcde";
            Console.WriteLine("str6.Length: {0}", str6.Length);
            Console.WriteLine("str6[1]: {0}", str6[1]);

            // =================================================
            // Anführungszeichen, die gerendert werden sollen:
            string test = "PrüfeÄnderbarkeit(\"str1\", \"strg2\"): {0}";

            Console.ReadKey();
        }
    }
}
