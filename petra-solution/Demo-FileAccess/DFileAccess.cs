using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Demo_FileAccess
{
    class DFileAccess
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M09 File Access");

            // die Datei befindet sich im Projektordner > bin > Debug > netcoreapp3.1
            // wenn man gepublisht hat dann in: Demo-FileAccess\bin\Release\netcoreapp3.1\publish
            StreamWriter sw = new StreamWriter("DemoFile.txt");
            sw.WriteLine("Zeile 1");
            sw.WriteLine("Zeile 2");
            // wird Stream nicht geschlossen, kann kein anderer Stream auf die Datei zugreifen
            sw.Close();

            // existiert die erwähne Datei, dann wird sie automatisch überschrieben
            StreamWriter sw2 = new StreamWriter("C:\\Users\\ppedv\\Desktop\\DemoFile2.txt");
            sw2.WriteLine("Zeile 1");
            sw2.WriteLine("Zeile 2");
            sw2.WriteLine(sw.NewLine); // line terminator string
            sw2.WriteLine(sw.Encoding); // UTF8
            Console.WriteLine("sw.NewLine: {0}", sw.NewLine); // neue Zeile
            Console.WriteLine("sw.NewLine: {0}", sw.NewLine.ToString()); // neue Zeile
            sw2.Close();

            // Auslesen
            Console.WriteLine(" --- Stream Reader ---");
            StreamReader sr = new StreamReader("C:\\Users\\ppedv\\Desktop\\DemoFile2.txt");
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
                //Console.WriteLine((char)sr.Read()); // liest je ein Zeichen und gibt den ASCII Code zurück (mit (char) den Character)
            }
            sr.Close();

            // ===========================
            #region JSON
            //Serialisierung mit JSON
            Transport t1 = new Transport("PKW",200,100_000.00);
            Transport t2 = new Transport("Motorad", 150, 30_000.00);

            Transport[] tArr = new Transport[] { t1, t2 };

            foreach (var item in tArr)
            {
                Console.WriteLine(item.BeschreibeMich());
            }

            string tArrAlsJson = JsonConvert.SerializeObject(tArr);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("tArrAlsJson: \n {0}", tArrAlsJson);
            // nur public Props wurden serialisiert!!
            // will man auch andere Props serialisieren muss man das Attribut [JsonProperty] davor stellen (in der Klasse)





            #endregion



            Console.ReadKey();
        }
    }
}
