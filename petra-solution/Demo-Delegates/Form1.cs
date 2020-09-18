using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Delegates
{
    public partial class Rechner : Form
    {
        // --- types (Datentypen) ---
        // einen Delegaten selber bauen:
        delegate int CustomizedIntIntIntDelgate(int a, int b);

        // --- fields / props ---
        CustomizedIntIntIntDelgate iiiDel;
        // einen fertigen Delegaten nutzen:
        Func<int, int, int> BuiltInIntIntIntDelegate; // ist eine Variable aber gleich wie delegate

        // --- ctor ---

        public Rechner()
        {
            InitializeComponent();
        }


        // --- using methods ---


        // --- methods definitons ---
        // Methoden für Delegaten
        int Addiere(int a, int b)
        {
            MessageBox.Show($"Summe: {a + b}");
            //textBoxPlus.Text = (a + b).ToString(); // wird später beim Butten befüllt
            return a + b;
        }

        int Subtrahieren(int a, int b)
        {
            MessageBox.Show($"Differenz: {a - b}");
            //textBoxMinus.Text = (a - b).ToString();
            return a - b;
        }
        int Multiplizieren(int a, int b)
        {
            MessageBox.Show($"Produkt: {a * b}");
            //textBoxPlus.Text = (a * b).ToString();
            return a * b;
        }
        int Dividieren(int a, int b)
        {
            MessageBox.Show($"Qutient: {a / b}");
            //textBoxPlus.Text = (a / b).ToString();
            return a / b;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //iiiDel = new CustomizedIntIntIntDelgate(Addiere);
            iiiDel = Addiere;
            //textBoxPlus.Text = iiiDel.Invoke(int.Parse(textBoxZahl1.Text), int.Parse(textBoxZahl2.Text)); //kann auch ohne Invoke aufgerufen werden (wie methode)
            textBoxPlus.Text = iiiDel(int.Parse(textBoxZahl1.Text), int.Parse(textBoxZahl2.Text)).ToString(); //kann auch ohne Invoke aufgerufen werden (wie methode)
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            iiiDel = new CustomizedIntIntIntDelgate(Subtrahieren);
            textBoxMinus.Text = iiiDel(int.Parse(textBoxZahl1.Text), int.Parse(textBoxZahl2.Text)).ToString(); //kann auch ohne Invoke aufgerufen werden (wie methode)
        }

        private void buttonAlles_Click(object sender, EventArgs e)
        {
            BuiltInIntIntIntDelegate = Addiere;
            BuiltInIntIntIntDelegate += Subtrahieren;
            BuiltInIntIntIntDelegate += Multiplizieren;
            BuiltInIntIntIntDelegate += Dividieren;

            textBoxAlles.Text = BuiltInIntIntIntDelegate(int.Parse(textBoxZahl1.Text), int.Parse(textBoxZahl2.Text)).ToString();
        }




    }
}
