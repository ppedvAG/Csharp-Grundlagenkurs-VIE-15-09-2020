using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_M16_Delegates
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Innerhalb der Form1-Klasse durfte man die Methode nicht einfach so aufrufen
            // #todo
            // Die Methode wird ausgeführt, nachdem das Formular-Fenster geschlossen wird.

            // wo trifft man oft Delegate?
            void ZeigeFind()
            {
                string[] banken = { "Reiffeisenbank", "SB", "Volksbank", "Zürcher Bank" };

                string result;

                // delegate braucht man in 2 Fällen
                // um die Delegaten zum Abfangen von weiteren Methoden zu bauen
                // und um anonyme Methoden zu schreiben
                //result = Array.Find(banken,
                //    delegate (string s)
                //    {
                //        return s.StartsWith("Z");
                //    }
                //    );

                //result = Array.Find(banken,
                //    (string s) =>
                //    {
                //        return s.StartsWith("Z");
                //    }
                //    );

                // bei anonymen Methoden wird nicht unterschieden, ob was zurückgegeben wird oder nicht
                // result = Array.Find(banken, (string s) => s.StartsWith("Z"));

                // im Array sind nur strings drin, deswegen der Datentyp beim Argument im Prädikat ist optional
                result = Array.Find(banken, s => s.StartsWith("Z"));





                //result = Array.Find(banken, test);
                //bool test(string s)
                //{
                //    return s.StartsWith("Z");
                //}
                // alle Methoden, die bool zurückgeben, können als Predicat genutzt werden

                MessageBox.Show($"result: {result}");
            }
            ZeigeFind();
        }
    }
}
