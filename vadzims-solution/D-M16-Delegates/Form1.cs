using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_M16_Delegates
{
    public partial class Form1 : Form
    {
        // types
        // einen Delegaten selber bauen:
        delegate int Customized_IntIntIntDelegate(int a, int b);

        // fields & props
        Customized_IntIntIntDelegate iiiDel;
        // einen fertigen Delegaten nutzen:
        Func<int, int, int> BuiltIn_IntIntIntDelegate;

        // ctor
        public Form1()
        {
            InitializeComponent();
        }

        

        // using methods


        // methods definitions
        // Methoden für Delegaten
        int Addiere(int a, int b)
        {
            MessageBox.Show($"Summe: {a + b}");
            // textBoxPlus.Text = (a + b).ToString();
            return a + b;
        }
        int Subtrahiere(int a, int b)
        {
            MessageBox.Show($"Differenz: {a - b}");
            // textBoxMinus.Text = (a - b).ToString();
            return a - b;
        }
        int Multipliziere(int a, int b)
        {
            MessageBox.Show($"Produkt: {a * b}");
            // textBoxPlus.Text = (a * b).ToString();
            return a * b;
        }
        int Dividiere(int a, int b)
        {
            MessageBox.Show($"Quotient: {a / b}");
            // textBoxPlus.Text = (a * b).ToString();
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //iiiDel = new Customized_IntIntIntDelegate(Addiere);
            // oder:
            iiiDel = Addiere;
            // textBoxPlus.Text = iiiDel.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            // oder ohne Invoke()
            textBoxPlus.Text = iiiDel(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iiiDel = new Customized_IntIntIntDelegate(Subtrahiere);
            textBoxMinus.Text = iiiDel(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        // Einsetzen vom eingebauten Delegaten
        private void button3_Click(object sender, EventArgs e)
        {
            BuiltIn_IntIntIntDelegate = Addiere;
            BuiltIn_IntIntIntDelegate += Subtrahiere;
            BuiltIn_IntIntIntDelegate += Multipliziere;
            BuiltIn_IntIntIntDelegate += Dividiere;
            textBoxAlles.Text = BuiltIn_IntIntIntDelegate(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();

        }


    }
}
