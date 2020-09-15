using System;
using System.Text;

namespace Demo_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Vadzim";
            string name2 = "Petra";
            string eingabe;
            int input;

            #region WriteLine

            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello {0}!", name);

            Console.WriteLine("Hello {0} und {1}!", name, name2);

            #endregion

            Console.Write("Hello World!");

            eingabe = Console.ReadLine();

            Console.WriteLine("Sie haben eingegeben: {0}", eingabe);

            input = Console.Read();

            Console.WriteLine("Sie haben eingegeben: {0}", input); // 114, weil ASCII

            Console.WriteLine(args); // System.String[]

            // ===========================================
            // Enconding 
            // Output: von Code zur Oberfläche
            Console.WriteLine("Eurozeichen: {0}", "€");
            Console.WriteLine("Console.OutputEncoding.EncodingName: {0}", Console.OutputEncoding.EncodingName); // Codepage - 850
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Eurozeichen: {0}", "€");

            // Input: von Oberfläche zum Code
            Console.WriteLine("Console.InputEncoding: {0}", Console.InputEncoding); // System.Text.OSEncoding
            Console.WriteLine("Console.InputEncoding.EncodingName: {0}", Console.InputEncoding.EncodingName); // Codepage - 850

            // ===========================================
            Console.ReadKey();
        }
    }
}
