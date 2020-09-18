using System;

namespace D_M12_Exceptions
{
    class DExceptions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M12 Ausnahme / Fehler");
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

                // verwendet man throw in try-Block, wird der Fehler im catch-Block abgefangen
                // verwendet man throw im catch-Block, wird der Fehler an der Caller-Stelle abgefangen
                try
                {
                    // ausgabe = strings[2];
                    ausgabe = strings[1];
                    if (ausgabe.Length < 2)
                        throw new TooShortException("String ist kürzer als 2 Zeichen");
                }
                // catch (Exception e)
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Fehler: {0}", e.Message);
                    Console.WriteLine("Das letzte Element im Array hat den Index {0}", strings.Length - 1);
                }
                catch (TooShortException e)
                {
                    Console.WriteLine("Fehler: {0}", e.Message);
                    throw new TooShortException("String ist kürzer als 2 Zeichen");
                }
                finally
                {
                    Console.WriteLine("ausgabe in finally: {0}", ausgabe);
                }
            }

            Console.ReadKey();
        }
    }
}
