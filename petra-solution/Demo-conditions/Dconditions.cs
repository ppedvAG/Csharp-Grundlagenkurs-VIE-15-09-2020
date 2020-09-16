using System;

namespace Demo_conditions
{
    class Dconditions
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
                result = "Ich bin im True-Block";
            else 
                result = "Ich bin im False-Block";
            Console.WriteLine(result);

            #endregion if()

            #region TernärerOperator
            // Bedingung ? true-Ausdruck : false-Ausdruck
            result = f ? "Ich bin im True-Block" : "Ich bin im False-Block";
            Console.WriteLine(result);


            #endregion TernärerOperator

            #endregion TrueOrFalse


            #region Datentypen
            // patternMatching
            string result2 ="irgendetwas";
            if (result2 is int)
                Console.WriteLine("Pattern Matching mit anderen Datentypen");
            else
                Console.WriteLine("Missmatch");
            #endregion Datentypen


            #region NullOrNotNull
            Console.WriteLine("\n\nNullOrNotNull");
            // option 1
            #region PatternMatching
            string str1 = default;            

            if (str1 is null)
              result2 = "null-Block";
            else
             result2 = "nicht im null-Block";
            Console.WriteLine(result2);

            #endregion PatternMatching

            // option 2
            #region ??-Operator
            result2 = str1 ?? "bin da, wenn links null"; //wenn str1=null dann Text
            Console.WriteLine(result2);

            #endregion ??-Operator

            #endregion NullOrNotNull




            Console.ReadKey();

        }
    }
}
