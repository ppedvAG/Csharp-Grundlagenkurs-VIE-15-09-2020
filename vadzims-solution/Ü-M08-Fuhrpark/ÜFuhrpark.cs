using System;
using System.Text;

namespace Ü_M08_Fuhrpark
{
    class ÜFuhrpark
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Übung M08 Fuhrpark");

            Transportmittel transportmittel = new Transportmittel("Kutsche", 450.23, 200);
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(transportmittel.BeschreibeMich());


            Console.ReadKey();


        }
    }
}
