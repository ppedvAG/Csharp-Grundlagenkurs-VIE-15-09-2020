using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json.Serialization;

namespace D_M09_FileAccess
{
    class DFileAccess
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M09 File Access");

            // die Datei befindet sich im Projekt-Ordner > bin > Debug > dotnetcoreapp3.1 
            // wenn man gepublisht hat, dann in:
            // Projekt-Ordner > bin > Publish > dotnetcoreapp3.1
            StreamWriter sw = new StreamWriter("DemoFile.txt");
            sw.WriteLine("Zeile 1");
            sw.WriteLine("Zeile 2");
            // wird Stream nicht geschlossen, kann anderer Stream auf die Datei nicht zugreifen
            sw.Close();

            StreamWriter sw2 = new StreamWriter("C:\\Users\\vn3\\Desktop\\DemoFile2.txt");
            // existiert die erwähnte Datei, dann wird sie automatisch überschrieben
            sw2.WriteLine("Zeile 1");
            sw2.WriteLine("Zeile 2");
            sw2.WriteLine(sw.NewLine); // line terminator string
            sw2.WriteLine(sw.Encoding); // System.Text.UTF8Encoding
            Console.WriteLine("sw.NewLine: {0}", sw.NewLine); // neue Zeile
            Console.WriteLine("sw.NewLine: {0}", sw.NewLine.ToString()); // neue Zeile
            sw2.Close();

            Console.WriteLine("\n\nStreamReader");
            StreamReader sr = new StreamReader("C:\\Users\\vn3\\Desktop\\DemoFile2.txt");
            while(!sr.EndOfStream)
            {
                // Console.WriteLine(sr.ReadLine());
                Console.WriteLine(sr.Read()); // liest je ein Zeichen und gibt sein Code zurück 
            }
            sr.Close();

            // =======================================================
            // Serializierung mit JSON
            Transportmittel t1 = new Transportmittel("PKW", 100_000.00, 230);
            Transportmittel t2 = new Transportmittel("Motorrad", 30_000.00, 150);

            Transportmittel[] tArr = new Transportmittel[] { t1, t2 };
            foreach (var item in tArr)
            {
                Console.WriteLine("item: {0}", item);
            }
            /*
item: D_M09_FileAccess.Transportmittel
item: D_M09_FileAccess.Transportmittel
            */
            foreach (var item in tArr)
            {
                Console.WriteLine("item: {0}", item.BeschreibeMich());
            }
            /*
item:
PKW, (100000 ?)
Maximale Geschwindigkeit: 230 km/h
Zustand: aus
Aktuelle Geschwindigkeit: 0
item:
Motorrad, (30000 ?)
Maximale Geschwindigkeit: 150 km/h
Zustand: aus
Aktuelle Geschwindigkeit: 0
            */


            string tArrAlsJson = JsonConvert.SerializeObject(tArr);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("tArrAlsJson: \n {0}", tArrAlsJson);
            //  [{"Preis":100000.0,"AktuelleGeschwindigkeit":0},{"Preis":30000.0,"AktuelleGeschwindigkeit":0}]
            // nur public Props wurden serializiert!!!

            // will man auch non-public Members serializieren, 
            // muss man das Attribut [JsonProperty] unmittelbar vor den gewünschten Members verwenden
       



            Console.ReadKey();
        }
    }
}
