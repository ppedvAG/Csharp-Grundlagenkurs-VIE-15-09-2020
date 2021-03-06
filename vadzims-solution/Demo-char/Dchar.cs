﻿using System;

namespace Demo_char
{
    class Dchar
    {
        static void Main(string[] args)
        {

            // Literals for char

            // char ch1 = "d"; geht nicht, weil "" sind Literal für string
            // char ch2 = new Char('d'); geht nicht, weil Char ein Struct ist. Structs haben keine Konstruktoren;
            char ch3 = 'd';
            
            Console.WriteLine("ch3: {0}", ch3);
            Console.WriteLine("ch3.GetType(): {0}", ch3.GetType()); // System.Char

            ch3 = '4';
            Console.WriteLine("char.GetNumericValue(ch3): {0}", char.GetNumericValue(ch3)); // 4
            // -1, wenn es keine Zahl war

            ch3 = 'a';
            Console.WriteLine("(int)ch3: {0}", (int)ch3); // 97 - ASCII code
            

            Console.WriteLine("char.MinValue: {0}", char.MinValue); // nicht alle Zeichen sind druckbar
            // MinValue kann man in der Definition von System.Char nachschauen und es ist '\0' - Null
            // http://www.fileformat.info/info/charset/UTF-16/list.htm
            Console.WriteLine("char.MaxValue: {0}", char.MaxValue);

            Console.ReadKey();
        }
    }
}
