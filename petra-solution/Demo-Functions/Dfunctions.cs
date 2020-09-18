using System;

namespace Demo_Functions
{
    class Dfunctions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M07 Methoden");
            Random rnd = new Random();

            #region MyRegion

            //// out, ref, in
            //// Szenario: Der Methode wird ein Array gegeben, um Dublikate im Array zu eliminieren und zu ersetzen.

            ////int[] numbers = new int[] { 4, 5, 5, 8 };
            ////int[] numbers2 = new int[] { 4, 5, 6, 8 };
            //int counter;
            //Console.Write("Wie viele Zahlen möchten Sie angeben:");
            //counter = int.Parse(Console.ReadLine());

            //int[] enterNumbers = new int[counter];

            ////// klassische Variante
            ////int[] ReplaceDuplicate(int[] zahlen)
            ////{

            ////    for (int i = 0; i < zahlen.Length; i++)
            ////    {
            ////        for (int j = 0; j < zahlen.Length; j++)
            ////        {

            ////            while (i != j && zahlen[i] == zahlen[j])
            ////            zahlen[j] = rnd.Next(1, 10);

            ////        }
            ////    }  
            ////    return zahlen;
            ////}



            //for (int i = 0; i < enterNumbers.Length; i++)
            //{
            //    Console.Write("Enter a Number:");
            //    enterNumbers[i] = int.Parse(Console.ReadLine());

            //}


            ////Console.WriteLine("Old:");
            ////foreach (var item in enterNumbers)
            ////{
            ////    Console.Write(item);
            ////}

            ////Console.WriteLine("\nNew:");

            //// int[] newNumbers = ReplaceDuplicate(enterNumbers);

            ////foreach (var item in enterNumbers)
            ////{
            ////    Console.Write(item);
            ////}
            ////foreach (var item in newNumbers)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// =========================
            //// Das ursprüngliche Array wird geändert
            ////  Variante 2 
            //void ReplaceDuplicate2(ref int[] zahlen)
            //{
            //    for (int i = 0; i < zahlen.Length; i++)
            //    {
            //        for (int j = 0; j < zahlen.Length; j++)
            //        {

            //            while (i != j && zahlen[i] == zahlen[j])
            //                zahlen[j] = rnd.Next(1, 10);

            //        }
            //    }
            //}

            //ReplaceDuplicate2(ref enterNumbers);

            //foreach (var item in enterNumbers)
            //{
            //    Console.Write(item);
            //}
            #endregion

            // =====================================

            #region MehrHandlungen

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

            int summand1_0 = 4;
            int summand2_0 = 5;
            int diff_0;
            int prod_0;
            int quot_0;
            int diffInit_0 = 3;
            int prodInit_0 = 3;
            int quotInit_0 = 3;
            // Variablen mit Werten werden mit out ignoriert

            Console.WriteLine("\nout mit Variablen ohne Werten:");
            Console.WriteLine($@"
{summand1_0} + {summand2_0} = {WendeVierMathOpsAn(summand1_0, summand2_0, out diff_0, out prod_0, out quot_0)}
{summand1_0} - {summand2_0} = {diff_0}
{summand1_0} * {summand2_0} = {prod_0}
{summand1_0} / {summand2_0} = {quot_0}
");

            Console.WriteLine("\nout mit Variablen mit Werten:");
            Console.WriteLine($@"
{summand1_0} + {summand2_0} = {WendeVierMathOpsAn(summand1_0, summand2_0, out diffInit_0, out prodInit_0, out quotInit_0)}
{summand1_0} - {summand2_0} = {diffInit_0}
{summand1_0} * {summand2_0} = {prodInit_0}
{summand1_0} / {summand2_0} = {quotInit_0}
");

            // out vs ref
            int WendeVierMathOpsAnR(int a, int b, ref int differenz, ref int produkt, ref int quotient)
            {
                differenz = a - b;
                produkt = a * b;
                quotient = a / b;

                int summe = a + b;
                return summe;
            }

            int summand1_r = 4;
            int summand2_r = 5;
            // Variablen ohne Werte rufen mit ref einen Fehler auf
            int diff_r;
            int prod_r;
            int quot_r;
            int diffInit_r = 3;
            int prodInit_r = 3;
            int quotInit_r = 3;



            Console.WriteLine("\nref mit Variablen ohne Werten:");
            Console.WriteLine("Ruft Fehler auf");
//            Console.WriteLine($@"
//{summand1_r} + {summand2_r} = {WendeVierMathOpsAnR(summand1_r, summand2_r, ref diff_r, ref prod_r, ref quot_r)}
//{summand1_r} - {summand2_r} = {diff_r}
//{summand1_r} * {summand2_r} = {prod_r}
//{summand1_r} / {summand2_r} = {quot_r}
//");

            Console.WriteLine("\nref mit Variablen mit Werten:");
            Console.WriteLine($@"
{summand1_r} + {summand2_r} = {WendeVierMathOpsAnR(summand1_r, summand2_r, ref diffInit_r, ref prodInit_r, ref quotInit_r)}
{summand1_r} - {summand2_r} = {diffInit_r}
{summand1_r} * {summand2_r} = {prodInit_r}
{summand1_r} / {summand2_r} = {quotInit_r}
");


            #endregion MehrHandlungen

            // =====================================

            #region in
            //in-Parameter (Parameter = beim definieren der Methode, Argument beim Ausführen)

            string PrüfeÄnderbarkeit(string arg1, in string arg2)
            {
                // arg2 += "test"; // nicht möglich, einen Wert zuzuweisen, weil nur lesbar
                return arg1 += arg2;
            }

            // Beim Aufrufen muss in nicht nochmal erwähnt werden
            Console.WriteLine("PrüfeÄnderbarkeit(\"str1\",\"str2\"): {0}", PrüfeÄnderbarkeit("str1","str2"));


            #endregion


            



            Console.ReadKey();
        }
    }
}
