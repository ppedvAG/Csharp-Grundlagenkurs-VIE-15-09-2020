using System;

namespace Demo_Conditions
{
    class DConditions
    {
        static void Main(string[] args)
        {
            // binäre boolesche Algebra 
            #region TrueOrFalse
            Console.WriteLine("TrueOrFalse");
            #region if()
            bool t = true;
            bool f = false;
            string result;
            if (t)
            {
                result = "ich bin in True-Block";
            }
            else
            {
                result = "ich bin in False-Block";
            }
            Console.WriteLine(result);

            // oder kürzer bei nur einer Anweisung pro Block
            if (t)
                result = "ich bin in True-Block";
            else
                result = "ich bin in False-Block";
            Console.WriteLine(result);

            // oder kürzer bei nur einer Anweisung pro Block
            if (t) result = "ich bin in True-Block";
            else result = "ich bin in False-Block";
            Console.WriteLine(result);

            #endregion if()

            #region TernärerOperator
            // Bedingung ? true-Ausdruck : false-Ausdruck
            result = f ? "ich bin in True-Block" : "ich bin in False-Block";
            Console.WriteLine(result);
            #endregion

            #endregion TrueOrFalse

            #region ObEsEinemDatentypEntspricht
            // patternMatching
            string result2 = "irgendwas";
            if (result2 is string)
                Console.WriteLine("Pattern Matching mit anderen Datentypen");
            else
                Console.WriteLine("Mismatch");
            #endregion

            #region NULLorNotNULL
            Console.WriteLine("\n\nNULLorNotNULL");
            // option 1
            #region patternMatching 
            string str1 = default;

            if (str1 is null)
                result2 = "bin in null-Block";
            else
                result2 = "bin in nicht-null-Block";
            Console.WriteLine(result2);
            #endregion

            // option 2
            #region ??-Operator
            result2 = (str1 ?? "bin da, wenn links null");
            Console.WriteLine(result2);
            #endregion

            #endregion NULLorNotNULL



            Console.ReadKey();
        }
    }
}
