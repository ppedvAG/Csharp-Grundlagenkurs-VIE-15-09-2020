using System;
using System.Text;

namespace Demo_Console
{
    class DConsole
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
            // Konvention bei Klassenbezeichnern:
            // Substantiv (Was-Wort) in Singular (Einzelform)
            // z.b. Todo, Transportmittel usw.

            eingabe = Console.ReadLine();

            Console.WriteLine("Sie haben eingegeben: {0}", eingabe);

            input = Console.Read();

            Console.WriteLine("Sie haben eingegeben: {0}", input); // 114, weil ASCII

            Console.WriteLine("args: {0}", args); // System.String[]
            Console.WriteLine("args.Length: {0}", args.Length); // Ein Fehler kommt:
            /*
             * #todo
  *           Unhandled exception. System.FormatException: Index (zero based) must be greater than or equal to zero and less than the size of the argument list.
  * at System.Text.StringBuilder.AppendFormatHelper(IFormatProvider provider, String format, ParamsArray args)
  * at System.IO.StreamWriter.WriteFormatHelper(String format, ParamsArray args, Boolean appendNewLine)
  * at System.IO.StreamWriter.WriteLine(String format, Object[] arg)
  * at System.IO.TextWriter.SyncTextWriter.WriteLine(String format, Object[] arg)
  * at System.Console.WriteLine(String format, Object[] arg)
  * at Demo_Console.DConsole.Main(String[] args) in D:\D_Dokumente\k_csharp\20200915_CSharpAnf_VadzimN_VIE\20200915-CS-GK-VIE\vadzims-solution\Demo-Console\DConsole.cs:line 36
            */

            if (args.Length > 0)
            {
                Console.WriteLine("args[0]: {0}", args[0]);
            }

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
