using System;
using System.Text;

namespace Demo_Console
{
    class Dconsole
    {
        static void Main(string[] args)
        {
            string name = "Petra";
            string name2 = "Vadzim";
            string eingabe;
            int input;

            #region WriteLine

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello {0}!", name);
            Console.WriteLine("Hello {0} und {1}!", name, name2);

            #endregion


            Console.Write("Hello World!");

            eingabe = Console.ReadLine();

            Console.WriteLine("Sie haben {0} eingegeben.", eingabe);

            input = Console.Read();
            Console.WriteLine("Sie haben {0} eingegeben.", input); //ASCII Code

            Console.WriteLine(args); //System.String[]
            Console.WriteLine("args.Length: {0}", args.Length);

            if((args.Length>0))
                    Console.WriteLine("args[0]: {0}", args[0]);

            // ==============================
            //Encoding
            // Output: von Code zur Oberfläche
            Console.WriteLine("Eurozeichen: {0}","€");
            Console.WriteLine("Console.OutputEncoding.EncodingName: {0}", Console.OutputEncoding.EncodingName); // Codepage - 850
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Eurozeichen: {0}","€");

            // Input: von Oberfläche zu Code
            Console.WriteLine("Console.InputEncoding: {0}", Console.InputEncoding); // System.Text.OSEncoding
            Console.WriteLine("Console.InputEncoding.EncodingName: {0}", Console.InputEncoding.EncodingName); // Codepage - 850
            
            // ==============================



            Console.ReadKey();
        }
    }
}
