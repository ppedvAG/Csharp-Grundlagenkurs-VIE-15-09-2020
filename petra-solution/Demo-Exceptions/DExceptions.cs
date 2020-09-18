using System;

namespace Demo_Exceptions
{
    class DExceptions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M12 Ausnahme /Fehler");

            try
            {
                PlayWithStrings();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler von der aufgerufenen Methode: {0}", e.Message);
            }



            void PlayWithStrings()
            {

                string[] strings = { "s1", "s" };
                string ausgabe = "initial";

                // Verwendet man throw im try-Block, wird der Fehler im catch-Block abgefangen
                // Verwendet man throw im catch-Block wird der Fehler an der Caller-Stelle abgefangen
                try
                {
                    //ausgabe = strings[2];                
                    ausgabe = strings[1];
                    if (ausgabe.Length < 2)
                    {
                        throw new C_TooShortException("String ist kürzer als 2 Zeichen");
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Fehler: {0}", e.Message);
                    Console.WriteLine("Das letzte Element im Array hat den Index {0}!", strings.Length - 1);
                }
                catch (C_TooShortException e)
                {
                    Console.WriteLine("Fehler Too Short: {0}", e.Message);
                    throw new C_TooShortException("String ist kürzer als 2 Zeichen");

                }
                finally
                {
                    Console.WriteLine("ausgabe: {0}", ausgabe);
                }
            }

            //System.IndexOutOfRangeException: 

            Console.ReadKey();

        }
    }
}
