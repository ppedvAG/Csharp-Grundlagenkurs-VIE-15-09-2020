using System;

namespace D_M07_Functions
{
    class DFunctions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M07 METHODS");

            // out, ref, in

            // Szenario: der Methode wird ein Array übergeben, um Duplikate im Array zu eliminieren und zu ersetzen

            int[] numbers = new int[] { 4, 5, 5, 8 };
            int[] numbers2 = new int[] { 4, 5, 6, 8 };

            // klassische Variante
            int[] ReplaceDuplicate(int[] zahlen)
            {
                //int[] SubArray(this int[] origArr, int index, int length)
                //{
                //    int[] result = new int[length];
                //    Array.Copy
                //}
                for (int i = 0; i < zahlen.Length; i++)
                {
                    int vergleichsZahl = zahlen[i];
                    int[] restArr = new int[zahlen.Length-i];
                    Array.Copy(zahlen, restArr, zahlen.Length - (i + 1));
                    
                    Console.WriteLine("\nrestArr");
                    foreach (var item in restArr)
                    {
                        Console.WriteLine(item);
                    }
                }
                return zahlen;
            }

            // Console.WriteLine(ReplaceDuplicate(numbers));   

            ReplaceDuplicate(numbers);

// #todo zum Ende bringen dieses Beispiel

            // ====================================================
            // Vier Handlungen mit 2 Operanden
            // die Werte der Variablen, die an die out-Parameter übergeben werden, werden auch geändert
            int WendeVierMathOpsAn(int a, int b, out int differenz, out int produkt, out int quotient)
            {
                differenz = a - b;
                produkt = a * b;
                quotient = a / b;
                int summe = a + b;
                return summe;
            }

            int summand1_O = 4;
            int summand2_O = 5;
            int diff_O;
            int prod_O;
            int quot_O;
            int diffInit_O = 3;
            int prodInit_O = 3;
            int quotInit_O = 3;
            // Variablen mit Werten werden mit out ignoriert

            Console.WriteLine("\nout mit Variablen ohne Werte");
            Console.WriteLine($@"
{summand1_O} + {summand2_O} = {WendeVierMathOpsAn(summand1_O, summand2_O, out diff_O, out prod_O, out quot_O)}
{summand1_O} - {summand2_O} = {diff_O}
{summand1_O} * {summand2_O} = {prod_O}
{summand1_O} / {summand2_O} = {quot_O}
");

            Console.WriteLine("\nout mit Variablen mit Werten");
            Console.WriteLine($@"
{summand1_O} + {summand2_O} = {WendeVierMathOpsAn(summand1_O, summand2_O, out diffInit_O, out prodInit_O, out quotInit_O)}
{summand1_O} - {summand2_O} = {diffInit_O}
{summand1_O} * {summand2_O} = {prodInit_O}
{summand1_O} / {summand2_O} = {quotInit_O}
");

            // out vs ref
            int summand1_R = 4;
            int summand2_R = 5;
            // Variaben ohne Werte rufen mit ref einen Fehler auf
            int diff_R;
            int prod_R;
            int quot_R;
            int diffInit_R = 3;
            int prodInit_R = 3;
            int quotInit_R = 3;
           
            int WendeVierMathOpsAnREF(int a, int b, ref int differenz, ref int produkt, ref int quotient)
            {
                differenz = a - b;
                produkt = a * b;
                quotient = a / b;
                int summe = a + b;
                return summe;
            }

            Console.WriteLine("\nref mit Variablen ohne Werte");
            Console.WriteLine("ruft Fehler auf");
//            Console.WriteLine($@"
//{summand1_R} + {summand2_R} = {WendeVierMathOpsAnREF(summand1_R, summand2_R, ref diff_R, ref prod_R, ref quot_R)}
//{summand1_R} - {summand2_R} = {diff_R}
//{summand1_R} * {summand2_R} = {prod_R}
//{summand1_R} / {summand2_R} = {quot_R}
//");

            Console.WriteLine("\nref mit Variablen mit Werten");
            Console.WriteLine($@"
{summand1_R} + {summand2_R} = {WendeVierMathOpsAnREF(summand1_R, summand2_R, ref diffInit_R, ref prodInit_R, ref quotInit_R)}
{summand1_R} - {summand2_R} = {diffInit_R}
{summand1_R} * {summand2_R} = {prodInit_R}
{summand1_R} / {summand2_R} = {quotInit_R}
");


            // ========================================
            // in-Parameter
            string PrüfeÄnderbarkeit(string arg1, in string arg2)
            {
                // arg2 += "test"; // nicht möglich, einen Wert zuzuweisen, weil nur lesbar
                return arg1 += arg2;
            }

            // beim Aufrufen soll in nicht nochmal erwähnt werden
            Console.WriteLine("PrüfeÄnderbarkeit(\"str1\", \"strg2\"): {0}", PrüfeÄnderbarkeit("str1", "strg2"));

            Console.ReadKey();


        }
    }
}
