using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Delegates
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
            Application.Run(new Rechner());


            // wo trifft man oft Delegate?
            void ZeigeFind()
            {
                string[] banken = { "Raiffeisenbank", "SB", "Volksbank", "Zürcher Kantonalbank" };

                string result1;
                string result2;
                string result3;
                string result4;



                // ohne delegate - methode muss explizit erschaffen werden
                result1 = Array.Find(banken, test);
                bool test(string s)
                {
                    return s.StartsWith("Z");
                }

                result2 = Array.Find(banken,
                    delegate (string s)
                    {
                        return s.StartsWith("Z");
                    }
                    );

                // => wenn etwas zurückkommt dann das sonst void, muss nicht angegeben werden
                result3 = Array.Find(banken, (string s) => s.StartsWith("Z"));

                // wenn nur ein Datentyp (zB string) kann auch weggelassen werden:
                result4 = Array.Find(banken, s => s.StartsWith("Z"));




                // delegate in 2 fällen: 

                MessageBox.Show($"result1: {result1}");
                MessageBox.Show($"result2: {result2}");
                MessageBox.Show($"result2: {result3}");
                MessageBox.Show($"result2: {result4}");


            }


            ZeigeFind();


        }
    }
}
